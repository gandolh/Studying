﻿using BenchmarkDotNet.Reports;
using System.Linq.Expressions;
using System.Reflection;


namespace AoC.Quest19
{
    internal class Quest19 : BaseQuest
    {
        Dictionary<string, Automaton> Automatas { get; set; } = [];
        public StateMachine stateMachine { get; set; } = new();
        public override Task Solve()
        {
            string inPath = GetPathTo("quest19_0.in");
            string outPath = GetPathTo("questResult.out");
            File.WriteAllText(outPath, "");
            string[] lines = File.ReadAllLines(inPath);
            int stopIndex = ReadAutomatas(lines);
            int totalSum = 0;
            // read xmas values
            //for (int i = stopIndex; i < lines.Length; i++)
            //{
            //    string line = lines[i].Replace("{", "").Replace("}", "");
            //    int[] values = line.Split(",").Select(el => Int32.Parse(el.Split("=")[1])).ToArray();
            //    bool result = Automatas["in"].Run(values[0], values[1], values[2], values[3]);
            //    if (stateMachine.IsCompleted)
            //        totalSum = totalSum + values[0] + values[1] + values[2] + values[3];
            //    Console.WriteLine(stateMachine.IsCompleted);
            //    Console.WriteLine();
            //    stateMachine.Reset();
            //}

            long count = 0;
            int iteration = 0;
            for (int x = 1; x <= 4000; x++)
                for (int m = x+1; m <= 4000; m++)
                    for (int a = m+1; a <= 4000; a++)
                        for (int s = a+1; s <= 4000; s++)
                        {
                            Automatas["in"].Run(x,m,a,s);
                            if (stateMachine.IsCompleted)
                                count++;
                            stateMachine.Reset();
                            
                            iteration++;
                            Console.WriteLine($"{iteration}/{256_000_000_000_000}");
                        }

            Console.WriteLine(count);
            return Task.CompletedTask;
        }

        private int ReadAutomatas(string[] lines)
        {
            int i;
            for (i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "") break;
                string[] splitArray = lines[i].Split('{');
                string label = splitArray[0];
                string allConditions = splitArray[1];
                allConditions = allConditions.Replace("}", "");
                BuildFunction(label, allConditions);

            }
            return i + 1;
        }

        private void BuildFunction(string label, string allConditions)
        {

            ParameterExpression paramX = Expression.Parameter(typeof(int), "x");
            ParameterExpression paramM = Expression.Parameter(typeof(int), "m");
            ParameterExpression paramA = Expression.Parameter(typeof(int), "a");
            ParameterExpression paramS = Expression.Parameter(typeof(int), "s");
            List<Expression> conditionExpressions = new List<Expression>();


            string[] conditions = allConditions.Split(",");
            for (int j = 0; j < conditions.Length; j++)
            {
                string[] splitArrayCondition = conditions[j].Split(":");
                if (j == conditions.Length - 1)
                {
                    string defaultCase = splitArrayCondition[0];
                    conditionExpressions.Add(Expression.Condition(Expression.Constant(true),
                        GetActionExpression(defaultCase, paramX, paramM, paramA, paramS),
                        Expression.Constant(false)));
                    continue;
                }

                string lhs = splitArrayCondition[0];
                string rhs = splitArrayCondition[1];
                (Expression Test, Expression IfTrue, Expression IfElse) = GetExpresions(lhs, rhs, paramX, paramM, paramA, paramS);
                conditionExpressions.Add(Expression.Condition(Test, IfTrue, IfElse));
            }

            Expression finalBody = conditionExpressions[0];
            for (int i = 1; i < conditionExpressions.Count; i++)
                finalBody = Expression.OrElse(finalBody, conditionExpressions[i]);

            // Creating the lambda expression that represents the function
            Expression<Func<int, int, int, int, bool>> dynamicFunction = Expression
                .Lambda<Func<int, int, int, int, bool>>(finalBody, paramX,
                paramM, paramA, paramS);

            // Compiling the lambda expression to create the actual function
            Func<int, int, int, int, bool> evalFunction = dynamicFunction.Compile();
            if (!Automatas.ContainsKey(label))
                Automatas[label] = new Automaton();
            Automatas[label].func = evalFunction;
            Automatas[label].label = label;
        }

        private Expression GetActionExpression(string rhs,
            ParameterExpression paramX, ParameterExpression paramM, ParameterExpression paramA, ParameterExpression paramS)
        {
            Expression actionExpression;
            if (rhs.Last() == 'A')
            {
                var instance = stateMachine;
                MethodInfo methodInfo = instance.GetType().GetMethod(nameof(instance.MarkCompleted))!;
                actionExpression = Expression.Call(Expression.Constant(instance), methodInfo, paramX, paramM, paramA, paramS);

            }
            else if (rhs.Last() == 'R')
            {
                var instance = stateMachine;
                MethodInfo methodInfo = instance.GetType().GetMethod(nameof(instance.MarkFailed))!;
                actionExpression = Expression.Call(Expression.Constant(instance), methodInfo, paramX, paramM, paramA, paramS);
            }
            else
            {
                if (!Automatas.ContainsKey(rhs))
                    Automatas[rhs] = new Automaton();
                Automaton instance = Automatas[rhs];
                MethodInfo methodInfo = instance.GetType().GetMethod(nameof(instance.Run))!;
                actionExpression = Expression.Call(Expression.Constant(instance), methodInfo, paramX, paramM, paramA, paramS);
            }
            return actionExpression;
        }

        private (Expression Test, Expression IfTrue, Expression IfElse) GetExpresions(string lhs, string rhs,
            ParameterExpression paramX, ParameterExpression paramM, ParameterExpression paramA, ParameterExpression paramS)
        {
            ParameterExpression param;
            switch (lhs[0])
            {
                case 'x':
                    param = paramX;
                    break;
                case 'm':
                    param = paramM;
                    break;
                case 'a':
                    param = paramA;
                    break;
                case 's':
                    param = paramS;
                    break;
                default:
                    throw new ArgumentException("Invalid parameter specified in condition.");
            }

            BinaryExpression Test;
            int valueToCompare = Int32.Parse(lhs.Substring(2));
            switch (lhs[1])
            {
                case '<':
                    Test = Expression.LessThan(param, Expression.Constant(valueToCompare));
                    break;
                case '>':
                    Test = Expression.GreaterThan(param, Expression.Constant(valueToCompare));
                    break;
                case '=':
                    Test = Expression.Equal(param, Expression.Constant(valueToCompare));
                    break;
                case '!':
                    Test = Expression.NotEqual(param, Expression.Constant(valueToCompare));
                    break;
                default:
                    throw new ArgumentException("Invalid comparison operator specified in condition.");
            }
            Expression actionExpression = GetActionExpression(rhs, paramX, paramM, paramA, paramS);
            return (Test, actionExpression, Expression.Constant(false));
        }
    }

    internal class Automaton
    {
        public Func<int, int, int, int, bool> func { get; set; }
        public string label { get; set; }


        public bool Run(int x, int m, int a, int s)
        {
            //Console.WriteLine(label);
            return func(x, m, a, s);

        }


    }

    internal class StateMachine
    {
        public bool IsCompleted { get; set; }
        public bool IsFailed { get; set; }


        public bool MarkCompleted(int x, int m, int a, int s)
        {
            IsCompleted = true;
            return true;
        }

        public bool MarkFailed(int x, int m, int a, int s)
        {
            IsFailed = true;
            return true;
        }

        public void Reset()
        {
            IsCompleted = false;
            IsFailed = false;
        }
    }
}

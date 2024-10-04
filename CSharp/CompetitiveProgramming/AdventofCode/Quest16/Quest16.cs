﻿

namespace AoC.Quest16
{
    internal class Quest16 : BaseQuest
    {

        private readonly MatrixDirection UP = new MatrixDirection(-1, 0);
        private readonly MatrixDirection RIGHT = new MatrixDirection(0, 1);
        private readonly MatrixDirection DOWN = new MatrixDirection(1, 0);
        private readonly MatrixDirection LEFT = new MatrixDirection(0, -1);
        private readonly MatrixDirection NONE = new MatrixDirection(-99, -99);
        private char[][] _filledMap = [];
        private char[][] _directionMap = [];

        public override Task Solve()
        {
            string inPath = GetPathTo("quest16_1.in");
            string outPath = GetPathTo("questResult.out");
            File.WriteAllText(outPath, "");
            string[] lines = File.ReadAllLines(inPath);
            char[][] originalMap = lines.ConvertToCharArray();
            int n = originalMap.Length,
                m = originalMap[0].Length;
            int maxResult = -1;
            int result = 0;
            BuildEmptyMap(originalMap, out _filledMap);
            BuildEmptyMap(originalMap, out _directionMap);
            _filledMap = new char[originalMap.Length][];
            for (int i = 0; i < originalMap.Length; i++)
                _filledMap[i] = new char[originalMap[i].Length];

            for (int i = 0; i < n; i++)
            {
                // left border
                EmptyMap(_filledMap);
                Walk(originalMap, i, 0, RIGHT);
                result = GetVisitedNodesCount(_filledMap, n, m);
                if (result > maxResult) maxResult = result;

                // right border
                EmptyMap(_filledMap);
                Walk(originalMap, i, m, LEFT);
                result = GetVisitedNodesCount(_filledMap, n, m);
                if (result > maxResult) maxResult = result;
            }

            for (int i = 0; i < m; i++)
            {
                // up border
                EmptyMap(_filledMap);
                Walk(originalMap, 0, i, DOWN);
                result = GetVisitedNodesCount(_filledMap, n, m);
                if (result > maxResult) maxResult = result;

                // down border
                EmptyMap(_filledMap);
                Walk(originalMap, n,i, UP);
                result = GetVisitedNodesCount(_filledMap, n, m);
                if (result > maxResult) maxResult = result;
            }

            Console.WriteLine(maxResult);
            return Task.CompletedTask;
        }


        private void Walk(char[][] originalMap, int startX, int startY, MatrixDirection dir)
        {
            Console.WriteLine("Coords:" + startX + " " + startY);
            List<WalkInstruction> _occurences = new List<WalkInstruction>();

            int n = originalMap.Length, m = originalMap[0].Length;
            Queue<WalkInstruction> queue = new();
            queue.Enqueue(new WalkInstruction(startX, startY, dir));

            while (queue.Count > 0)
            {
                var currWalk = queue.Dequeue();

                if (OutOfBoundaries(currWalk.coordinates.X, currWalk.coordinates.Y, n, m) == true
                    || _occurences.IndexOf(currWalk) != -1)
                    continue;


                //Console.WriteLine("=============");
                //_directionMap[currWalk.coordinates.X][currWalk.coordinates.Y] = '#';
                //Print(_directionMap, n, m);


                _occurences.Add(currWalk);
                char currentChar = originalMap[currWalk.coordinates.X][currWalk.coordinates.Y];
                MatrixDirection currentDirection = currWalk.Direction;
                MatrixDirection newDirection1 = NONE;
                MatrixDirection newDirection2 = NONE;
                _filledMap[currWalk.coordinates.X][currWalk.coordinates.Y] = '#';
                char directionMapSym = (currentChar == '|' || currentChar == '-')
                    ? currentChar : getSymbolDir(currWalk.Direction);
                _directionMap[currWalk.coordinates.X][currWalk.coordinates.Y] = directionMapSym;
                if (currentChar == '\\')
                {
                    newDirection1 = new MatrixDirection(currentDirection.Y, currentDirection.X);
                }
                else if (currentChar == '/')
                {
                    newDirection1 = new MatrixDirection(currentDirection.Y * -1, currentDirection.X * -1);
                }
                else if (currentChar == '|')
                {
                    if (currentDirection.Equals(LEFT) || currentDirection.Equals(RIGHT))
                    {
                        newDirection1 = UP;
                        newDirection2 = DOWN;
                    }
                    else newDirection1 = currentDirection;
                }
                else if (currentChar == '-')
                {
                    if (currentDirection.Equals(DOWN) || currentDirection.Equals(UP))
                    {
                        newDirection1 = LEFT;
                        newDirection2 = RIGHT;
                    }
                    else newDirection1 = currentDirection;
                }
                else if (currentChar == '.')
                {
                    newDirection1 = currentDirection;
                }

                queue.Enqueue(new WalkInstruction(currWalk.coordinates.X + newDirection1.X,
                    currWalk.coordinates.Y + newDirection1.Y, newDirection1));
                if (newDirection2 != NONE)
                {
                    queue.Enqueue(new WalkInstruction(currWalk.coordinates.X + newDirection2.X,
                        currWalk.coordinates.Y + newDirection2.Y, newDirection2));
                }
            }
        }

        private char getSymbolDir(MatrixDirection direction)
        {
            if (direction.Equals(UP)) return '^';
            if (direction.Equals(DOWN)) return 'v';
            if (direction.Equals(RIGHT)) return '>';
            if (direction.Equals(LEFT)) return '<';
            return '*';
        }

        private bool OutOfBoundaries(int i, int j, int n, int m)
        {
            if (i < 0 || j < 0) return true;
            if (i >= n || j >= m) return true;
            return false;
        }

        private int GetVisitedNodesCount(char[][] map, int n, int m)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (map[i][j] == '#')
                        count++;
            return count;
        }

        private void BuildEmptyMap(char[][] originalMap, out char[][] resultMap)
        {
            resultMap = new char[originalMap.Length][];
            for (int i = 0; i < originalMap.Length; i++)
                resultMap[i] = new char[originalMap[i].Length];
        }

        private void EmptyMap(char[][] resultMap)
        {
            int m = resultMap[0].Length;
            for (int i = 0; i < resultMap.Length; i++)
                for (int j = 0; j < m; j++)
                    resultMap[i][j] = (char)0;
        }


        private void Print(char[][] mat, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i][j] == 0)
                        Console.Write('.');
                    Console.Write(mat[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

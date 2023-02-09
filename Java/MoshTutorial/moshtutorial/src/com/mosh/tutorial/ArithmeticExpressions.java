package com.mosh.tutorial;

import java.sql.SQLOutput;

public class ArithmeticExpressions {
    public static void main(String[] args) {
        int result;
        result = 10 + 3;
        System.out.println(result);
        result = 10 - 3;
        System.out.println(result);
        result = 10 * 3;
        System.out.println(result);
        result = 10 / 3;
        System.out.println(result);
        result = 10 % 3;
        System.out.println(result);
        double result2 = (double) 10 / (double) 3;
        System.out.println(result2);
        int x = 1;
        x++;
        System.out.println(x);
        ++x;
        System.out.println(x);
        int y = x++;
        System.out.println(x + ", " + y);
        y = ++x;
        System.out.println(x + ", " + y);

        x = 1;
        x = x + 2;
        System.out.println(x);
        x += 2;
        System.out.println(x);
        x-=2;
        System.out.println(x);
    }
}

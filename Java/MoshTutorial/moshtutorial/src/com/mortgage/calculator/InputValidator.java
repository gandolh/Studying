package com.mortgage.calculator;

import java.io.BufferedReader;
import java.util.Scanner;

public class InputValidator {
    public static int pickPrincipal() {
        Scanner scanner = new Scanner(System.in);
        int principal;
        do{
            principal = scanner.nextInt();
            if(principal >= 1_000 && principal <= 1_000_000)
                break;
            System.out.println("Enter a value between 1.000 and 1.000.000");
        }while (true);
        return principal;
    }

    public static float pickInterest(){
        Scanner scanner = new Scanner(System.in);
        float anualInterest;
        do{
            anualInterest = scanner.nextFloat();
            if(anualInterest >= 1 && anualInterest <= 30)
                break;
            System.out.println("Enter a value between 1 and 30");
        }while (true);
        return anualInterest;
    }
    public static byte pickYears(){
        Scanner scanner = new Scanner(System.in);
        byte years;
        do{
            years = scanner.nextByte();
            if(years >= 1 && years <= 30)
                break;
            System.out.println("Enter a value between 1 and 30");
        }while (true);
        return years;
    }
}

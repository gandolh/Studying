package com.mosh.tutorial;

public class Conditions {
    public static void main(String[] args) {
        int temp = 32;
        if (temp > 30) {
            System.out.println("It's a hot day");
            System.out.println("Drink water");
        } else if (temp > 20 && temp <= 30)
            System.out.println("Beautifull day");
        else System.out.println("Cold day");

        int income = 120_000;
        boolean hasHighIncome = income > 100_000;
        boolean hashHighIncome = income > 100_000 ? true : false;
        String className  = income > 100_000 ? "First" : "Economy";
    }
}

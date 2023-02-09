package com.mortgage.calculator;

import java.text.NumberFormat;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        final byte MONTHS_IN_YEAR = 12;
        final byte PERCENT = 100;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Principal: ");
        int principal = InputValidator.pickPrincipal();
        System.out.print("Annual Interest Rate: ");
        float anuallyInterest = InputValidator.pickInterest();
        System.out.print("Period (Years): ");
        byte years = InputValidator.pickYears();
        double monthlyInterest = anuallyInterest / PERCENT / MONTHS_IN_YEAR;
        int numbersOfPayments = years * MONTHS_IN_YEAR;
        double pow = Math.pow(1 + monthlyInterest, numbersOfPayments);
        double mortgage = (principal * monthlyInterest * pow) / (pow - 1);
        String mortgageFormatted = NumberFormat.getCurrencyInstance().format(mortgage);
        System.out.println(mortgageFormatted);

    }
}

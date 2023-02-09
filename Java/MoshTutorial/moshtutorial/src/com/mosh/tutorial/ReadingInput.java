package com.mosh.tutorial;

import java.util.Scanner;

public class ReadingInput {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
//        System.out.print("Age: ");
//        byte age = scanner.nextByte();
//        System.out.println("You are " + age);
        //for only one string without spaces
//        System.out.print("Name: ");
//        String name = scanner.next();
//        System.out.println("You are " + name);


        //for strings with spaces
        System.out.print("Name: ");
        String name = scanner.nextLine().trim();
        System.out.println("You are " + name);
    }
}

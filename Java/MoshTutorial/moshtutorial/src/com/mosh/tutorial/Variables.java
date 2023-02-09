package com.mosh.tutorial;

public class Variables {
    public static void main(String args[]) {
        // possible but bad formatting
        // int age =30, temperature = 20;
        int myAge = 30;
        int temperature = 20;
        System.out.println(myAge);
        myAge = 35;
        System.out.println(myAge);
        int herAge = myAge;
        System.out.println(herAge);
    }
}

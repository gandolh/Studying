package com.mosh.tutorial;

import java.util.Scanner;

public class Loops {
    public static void main(String[] args) {
//        for (int i = 5; i >0; i--)
//            System.out.println("Hello world");
//
//         int i=5;
//         while(i>0){
//             System.out.println("hello world " + i);
//                i--;
//         }
        Scanner scanner = new Scanner(System.in);
        String input = "";
//         while(!input.equals("quit")){
//             System.out.println("Input: ");
//            input = scanner.next().toLowerCase();
//             System.out.println(input);
//         }

//        do {
//            System.out.println("Input: ");
//            input = scanner.next().toLowerCase();
//            if(input.equals("pass"))
//                continue;
//            if (input.equals("quit"))
//                break;
//            System.out.println(input);
//        } while (true);
        String[] fruits = {"Apple", "Mango", "Orange"};
        for (String fruit : fruits) System.out.println(fruit);
    }
}

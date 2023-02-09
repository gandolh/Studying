package com.mosh.tutorial;

public class Strings {
    public static void main(String[] args){
        String message = new String("Hello world");
        message = "Hello World";
        System.out.println(message);
        message = "Hello World" + "!!";
        System.out.println(message);
        System.out.println(message.endsWith("!!"));
        System.out.println(message.startsWith("!!"));
        System.out.println(message.length());
        System.out.println(message.indexOf("H"));
        System.out.println(message.indexOf("e"));
        System.out.println(message.indexOf("sky"));
        System.out.println(message.replace("!","*"));
        message = "    World" + "!!";
        System.out.println(message.trim());


    }
}

package com.mosh.tutorial;

public class EscapeSequences {
    public static void main(String[] args) {
        String message = "Hello \"World\"";
        System.out.println(message);
        message = "c:\\\n\tWindows\\...";
        System.out.println(message);

    }
}

package com.mosh.tutorial;

import java.text.BreakIterator;

public class SwitchStatements {

    public static void main(String[] args) {
        String role = "Admin";
        if(role == "admin")
            System.out.println("You're an admin");
        else if(role=="moderator")
            System.out.println("You're a guest");
        else System.out.println("You're guest");

        switch (role){
            case "admin":
                System.out.println("You're an admin");
                break;
            case "moderator":
                System.out.println("You're an moderator");
                break;
            default:
                System.out.println("youre a guest");
        }
    }
}

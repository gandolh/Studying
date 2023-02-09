package com.mosh.tutorial;

public class Casting {
    public static void main(String[] args) {
//        Implicit casting
//        byte > Short > int > long
//        short x = 1;
//        int y = x+2;
//        System.out.println(y);

//        double x = 1.1;
////        double y = x+2;
//        int y = (int)x +2;
//        System.out.println(y);

//    String x = "1";
        String x = "1.1";

    int y = Integer.parseInt(x) + 2;
        System.out.println(y );
    }

}

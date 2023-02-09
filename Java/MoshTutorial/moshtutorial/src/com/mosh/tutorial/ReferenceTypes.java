package com.mosh.tutorial;

import java.awt.*;
import java.util.Arrays;
import java.util.Date;

public class ReferenceTypes {
    public static void main(String args[]){
        Date now = new Date();
//        now.getTime();
        System.out.println(now);

        Point point1 = new Point(1,1);
        Point point2 = point1;
        point1.x =2;
        System.out.println(point2);
    }
}

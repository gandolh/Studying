package com.mosh.tutorial;

public class Arrays {
    public static void main(String[] args) {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
//        numbers[10] = 3;
        System.out.println(numbers);
        System.out.println(java.util.Arrays.toString(numbers));
        int[] numbers2 = {2,3,5,1,4};
        System.out.println(numbers2.length);
        java.util.Arrays.sort(numbers2);
        System.out.println(numbers2);
    }
}

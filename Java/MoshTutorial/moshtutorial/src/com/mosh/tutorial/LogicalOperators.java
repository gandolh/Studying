package com.mosh.tutorial;

public class LogicalOperators {
    public static void main(String[] args) {
        int temperature = 22;
        boolean isWarm = temperature > 20 && temperature <24;
        System.out.println(isWarm);
         boolean hasHighIncome = true;
         boolean hasGoodCredit = true;
         boolean hasCriminalRecord = false;
         boolean isEligible = (hasHighIncome || hasGoodCredit) && !hasCriminalRecord;
        System.out.println(isEligible);

    }
}

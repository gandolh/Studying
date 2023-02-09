package atm;

import java.text.DecimalFormat;
import java.util.Scanner;

public class Account {

    private int customerNumber;
    private int pinNumber;
    private double checkingBalance = 0;
    private double savingBalance = 0;
    Scanner input = new Scanner(System.in);
    DecimalFormat moneyFormat = new DecimalFormat("'$'###,##0.00");

    public int getCustomerNumber() {
        return customerNumber;
    }

    public void setCustomerNumber(int customerNumber) {
        this.customerNumber = customerNumber;
    }

    public int getPinNumber() {
        return pinNumber;
    }

    public void setPinNumber(int pinNumber) {
        this.pinNumber = pinNumber;
    }
    public double getCheckingBalance() {
        return checkingBalance;
    }
    public double getSavingBalance() {
        return savingBalance;
    }

    public double calcCheckingWithdraw(double amount){
        checkingBalance = checkingBalance - amount;
        return checkingBalance;
    }
    public double calcSavingWithdraw(double amount){
        savingBalance = savingBalance - amount;
        return savingBalance;
    }
    public double calcCheckingDeposit(double amount){
        checkingBalance = checkingBalance + amount;
        return checkingBalance;
    }
    public double calcSavingDeposit(double amount){
        savingBalance = savingBalance + amount;
        return savingBalance;
    }
    public void getCheckingWithdrawInput(){
        System.out.println("Checking account balance: " + moneyFormat.format(checkingBalance));
        System.out.println("Ammount you want to withdraw from checking account: ");
        double ammount = input.nextDouble();
        if(checkingBalance - ammount >=0){
            calcCheckingWithdraw(ammount);
            System.out.println("New checking account balance: " + moneyFormat.format(checkingBalance));
        }else{
            System.out.println("Not enough ballance");
        }
    }

    public void getSavingWithdrawInput(){
        System.out.println("Saving account balance: " + moneyFormat.format(savingBalance));
        System.out.println("Ammount you want to withdraw from saving account: ");
        double ammount = input.nextDouble();
        if(savingBalance - ammount >=0){
            calcSavingWithdraw(ammount);
            System.out.println("New saving account balance: " + moneyFormat.format(savingBalance));
        }else{
            System.out.println("Not enough ballance");
        }
    }
    public void getCheckingDepositInput(){
        System.out.println("Checking account balance: " + moneyFormat.format(checkingBalance));
        System.out.println("Ammount you want to deposit from checking account: ");
        double ammount = input.nextDouble();
        if( ammount >=0){
            calcCheckingDeposit(ammount);
            System.out.println("New checking account balance: " + moneyFormat.format(checkingBalance));
        }else{
            System.out.println("Ammount cannot be negative");
        }
    }

    public void getSavingDepositInput(){
        System.out.println("Saving account balance: " + moneyFormat.format(savingBalance));
        System.out.println("Ammount you want to deposit from saving account: ");
        double ammount = input.nextDouble();
        if( ammount >=0){
            calcSavingDeposit(ammount);
            System.out.println("New saving account balance: " + moneyFormat.format(savingBalance));
        }else{
            System.out.println("Ammount cannot be negative");
        }
    }

}

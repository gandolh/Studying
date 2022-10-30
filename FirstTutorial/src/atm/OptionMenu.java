package atm;

import java.io.IOException;
import java.text.DecimalFormat;
import java.util.HashMap;
import java.util.Scanner;

public class OptionMenu extends Account {
    Scanner menuInput = new Scanner(System.in);
    DecimalFormat moneyFormat = new DecimalFormat("'$'###,##0.00");
    HashMap<Integer, Integer> data = new HashMap<>();

    public void getLogin() throws IOException {
        int x = 1;
        do {
            try {
                data.put(952141, 191904);
                data.put(989947, 71976);
                System.out.println("Welcome to the ATM");
                System.out.println("Enter your custommer number");
                setCustomerNumber(menuInput.nextInt());
                System.out.println("Enter your PIN number:");
                setPinNumber(menuInput.nextInt());
            } catch (Exception e) {
                System.out.println("Invalid characters, only number.\n");
                x = 2;

            }
            int cn = getCustomerNumber();
            int pn = getPinNumber();
            if (data.containsKey(cn) && data.get(cn) == pn) {
                getAccountType();
            } else {
                System.out.println("\nWrong Customer Number or Pin Number\n");
            }
        } while (x == 1);
    }

    public void getAccountType() {
        System.out.println("Select the profile you want to select");
        System.out.println("Type 1 - Checking Account");
        System.out.println("Type 2 - Saving Account");
        System.out.println("Type 3 - Exit");
        int selection = menuInput.nextInt();
        switch (selection) {
            case 1:
                getChecking();
                break;
            case 2:
                getSaving();
                break;
            case 3:
                System.out.println("Thank you for using this ATM, bye");
                break;
            default:
                System.out.println("Invalid choice");
                getAccountType();

        }
    }

    public void getChecking() {
        System.out.println("Check account");
        System.out.println("Type 1 - View Ballance");
        System.out.println("Type 2 - Withdraw Funds");
        System.out.println("Type 3 - Deposit Funds");
        System.out.println("Type 4 - Exit");
        System.out.println("Choice: ");
        int selection = menuInput.nextInt();
        switch (selection) {
            case 1:
                System.out.println("Checking account balance: " + moneyFormat.format(getCheckingBalance()));
                getAccountType();
                break;
            case 2:
                getCheckingWithdrawInput();
                getAccountType();
                break;
            case 3:
                getCheckingDepositInput();
                getAccountType();
                break;
            case 4:
                System.out.println("Thank you for using this ATM, bye");
                break;
            default:
                System.out.println("Invalid choice");
                getChecking();
        }
    }

    public void getSaving(){
        System.out.println("Saving account");
        System.out.println("Type 1 - View Ballance");
        System.out.println("Type 2 - Withdraw Funds");
        System.out.println("Type 3 - Deposit Funds");
        System.out.println("Type 4 - Exit");
        System.out.println("Choice: ");
        int selection = menuInput.nextInt();
        switch (selection) {
            case 1:
                System.out.println("Saving account balance: " + moneyFormat.format(getSavingBalance()));
                getAccountType();
                break;
            case 2:
                getSavingWithdrawInput();
                getAccountType();
                break;
            case 3:
                getSavingDepositInput();
                getAccountType();
                break;
            case 4:
                System.out.println("Thank you for using this ATM, bye");
                break;
            default:
                System.out.println("Invalid choice");
                getSaving();
        }

    }
}

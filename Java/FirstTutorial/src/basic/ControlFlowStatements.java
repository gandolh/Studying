package basic;

public class ControlFlowStatements {
    public static void main(String args[]) {
        int testscore = 76;
        char grade;
        if (testscore >= 90)
            grade = 'A';
        else if (testscore >= 80)
            grade = 'B';
        else if (testscore >= 70)
            grade = 'C';
        else if (testscore >= 60)
            grade = 'D';
        else
            grade = 'F';
        System.out.println("Grade: " + grade);

        //nested ifs
        int i = 50;
        if (i < 75) {
            System.out.println("i is smaller than 75");
            if (i < 55) {
                System.out.println("i is smaller than 55");
                if (i == 50) {
                    System.out.println("i is 50");
                }
            }
        }

        //tenary operators
        int a = 1;
        int b = 2;
        int result;
        result = a < b ? a : b;
        System.out.println(result);


        //switch
        int month = 6;
        String monthString ;
        switch(month){
            case 1:
                monthString = "January";
                break;
            case 2:
                monthString = "February";
                break;
            case 3:
                monthString = "March";
                break;
            case 4:
                monthString = "April";
                break;
            case 5:
                monthString = "June";
                break;
            case 6:
                monthString = "July";
                break;
            default:
                monthString = "Invalid month";
        }
        System.out.println(monthString);
    }
}

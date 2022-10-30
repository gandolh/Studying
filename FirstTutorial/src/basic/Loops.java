package basic;

public class Loops {
    public static void main(String args[]) {
        //do while
        int count = 1;
        do {
            System.out.println("Count is: " + count);
            count++;
        }while (count<10);

        //while do
        count = 1;
        while (count<10){
            System.out.println("Count is: " + count);
            count++;
        }

        //for loops
        for(int i=1;i<10;i++){
            System.out.println("for -- Count is:" + i);
        }
        int[] numbers = {1,2,3,4,5,6,7,8};
        for(int item : numbers)
            System.out.println(item);

        //nested for loops
        int arr2[][] = {{2,7,9},{3,6,1},{7,4,2}};
        for(int[] subarr : arr2){
            for(int item : subarr)
                System.out.print(item +" ");
            System.out.println();
        }
    }
}

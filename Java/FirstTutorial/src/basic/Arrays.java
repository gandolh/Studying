package basic;

public class Arrays {

    public static void main(String[] args){
        // one dimensional
        int[] arr;
        arr = new int[10];
        arr[0]=100;
        arr[1]=200;
        // ...
        arr[9]=1000;
        System.out.println("Element at index 0:" + arr[0]);
        System.out.println("Element at index 1:" + arr[1]);
        System.out.println("...");
        System.out.println("Element at index 9:" + arr[9]);

        // two dimensional
        int arr2[][] = {{2,7,9},{3,6,1},{7,4,2}};
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++)
                    System.out.print(arr2[i][j] + " " );
        System.out.println();
        }
        System.out.println(arr2[1][1]);

        //three dimensional array
        int[][][] arr3 = {{{1,2,10},{3,4,11}},{{5,6,12},{7,8,13}}};
        System.out.println(arr3[0][1][2]);
    }
}

package advanced;

public class RecursionDemo {

    private class ComplexFunction{
        int calculateFactorial(int n){
            if(n<=1){
                return 1;
            }else{
                return n*calculateFactorial(n-1);
            }
        }
    }

    public static void main(String args[]){
        ComplexFunction complexFunction = new RecursionDemo(). new ComplexFunction();
        System.out.println("Factorial of 7 is:  " + complexFunction.calculateFactorial(7));
    }
}

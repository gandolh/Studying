package intermediate;

public class MethodOverloadingDemo {


    public int multiply(int x, int y) {
        return x * y;
    }

    public int multiply(int x, int y, int z) {
        return x * y * z;
    }

    public double multiply(double x, double y) {
        return x * y;
    }

    public static void main(String args[]) {
        MethodOverloadingDemo demo = new MethodOverloadingDemo();
        System.out.println("multiply of 2 int: " + demo.multiply(2, 3));
        System.out.println("multiply of 3 int: " + demo.multiply(2, 3, 6));
        System.out.println("multiply of 2 double: " + demo.multiply(2.0d, 3.4d));

    }
}

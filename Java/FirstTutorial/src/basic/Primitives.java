package basic;

public class Primitives {
    public static void main(String[] args) {
       printPrimitiveTypes();
    }
    public static void printPrimitiveTypes(){
        char a= 'A';
        byte b= 2;
        short c = 22;
        int d = 45;
        float e = 5.123451f;
        double f = 4.68295233535d;
        boolean g = true;
        System.out.println("char:"+a);
        System.out.println("byte:"+b);
        System.out.println("short:"+c);
        System.out.println("int:"+d);
        System.out.println("float:"+e);
        System.out.println("double:"+f);
        System.out.println("boolean:"+g);
    }
}

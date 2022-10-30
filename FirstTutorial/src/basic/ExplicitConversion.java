package basic;

public class ExplicitConversion {

    public static void main(String[] args){
       double a =50.50;
       System.out.println("Double representation:" + a);
        float f = (float)a;
        System.out.println("float representation:" + f);
        long b= (long)a;
        System.out.println("long representation:" + b);
        int c = (int)b;
        System.out.println("int representation:" + c);

    }
}

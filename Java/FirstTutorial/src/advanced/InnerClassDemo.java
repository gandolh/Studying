package advanced;

public class InnerClassDemo {
    public static void main(String args[]){
        OuterClass2.InnerClass in = new OuterClass2().new InnerClass();
        in.display();
        OuterClass2 outer = new OuterClass2();
        outer.outerClassMethod();
    }
}

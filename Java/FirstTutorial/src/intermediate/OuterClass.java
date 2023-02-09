package intermediate;

public class OuterClass {
    static int outerStaticMethod = 10;
    int instanceMember =20;
    private static int outerPrivateMember = 30;
    static class StaticNestedClass{
        void display(){
            System.out.println("static member of outer class: " + outerStaticMethod);
            System.out.println("outer private static member of outer class: " + outerPrivateMember);
//            System.out.println("non static member of outer class: " + instanceMember);

        }

    }


}

package advanced;

public class OuterClass2 {
    class InnerClass {
        public void display() {
            System.out.println("This is a inner class");
        }
    }
        void outerClassMethod(){
            System.out.println("This is outer class method");
            class MethodLocalClass{
                void localInnerMethod(){
                    System.out.println("In the local method class");

                }
            }
            MethodLocalClass mlc = new MethodLocalClass();
            mlc.localInnerMethod();

        }
    }

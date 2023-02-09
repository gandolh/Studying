import java.lang.reflect.Method;

public class AnnotationDemo {

    @MyCustomAnnotation(value = 10)
    public void sayHello(){
        System.out.println("my custom annotation");
    }
    public static void main(String args[]) throws NoSuchMethodException {
        AnnotationDemo demo = new AnnotationDemo();
        Method methodval = demo.getClass().getMethod("sayHello");
        MyCustomAnnotation myCustomAnnotation = methodval.getAnnotation(MyCustomAnnotation.class);
        System.out.println("Value is: " + myCustomAnnotation.value());
    }
}

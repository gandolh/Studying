package basic;

import java.util.Stack;

public class StacksDemo {
    public static void main(String args[]){
        Stack<String> stack = new Stack<String>();
        stack.push("America");
        stack.push("Germany");
        stack.push("india");
        System.out.println("Stack: " + stack);
        String poppedELement = stack.pop();
        System.out.println("Popped element: " + poppedELement);
        System.out.println("Stack: " + stack);
        String peekedElement = stack.peek();
        System.out.println("Peeked element: " + peekedElement);
        System.out.println("Stack: " + stack);
    }
}

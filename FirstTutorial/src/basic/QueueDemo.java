package basic;

import java.util.PriorityQueue;
import java.util.Queue;

public class QueueDemo {
    public static void main(String args[]){
        Queue<String> q = new PriorityQueue<>();
        q.add("India");
        q.add("Germany");
        q.add("America");
        System.out.println("original queue: " + q);
        q.remove();
        System.out.println("Queue after removing one element: " + q );
        String head = q.peek();
        System.out.println("head: " + head );
        head = q.poll();
        System.out.println("removed head: " + head );
        System.out.println("queue now: " + q );



    }
}

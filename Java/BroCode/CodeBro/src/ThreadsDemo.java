public class ThreadsDemo {
    public static void main(String[] args) throws InterruptedException {
//        System.out.println(Thread.activeCount());
//        System.out.println( Thread.currentThread().getName());
//        Thread.currentThread().setName("Mainnnnthread");
//        System.out.println( Thread.currentThread().getName());
//        System.out.println(Thread.currentThread().getPriority());

        System.out.println(Thread.currentThread().isAlive());
        for(int i=3;i>0;i--){
            System.out.println(i);
            Thread.sleep(1000);
        }
    }
}

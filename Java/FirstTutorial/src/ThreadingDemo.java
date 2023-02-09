public class ThreadingDemo {
    public static void main(String args[]) {
        int n = 10;
        MathUtils mu = new MathUtils();
        Thread1 t1 = new Thread1(mu);
        t1.start();
        Thread t2 = new Thread(new Thread2(mu));
        t2.start();
    }
}

class Thread1 extends Thread {
    MathUtils mu;

    public Thread1(MathUtils mu) {
        this.mu = mu;
    }

    @Override
    public void run() {
        try {
            mu.getMultiples(2);
        } catch (Exception e) {
            System.out.println("Exception raised " + e);
        }
    }
}

class Thread2 implements Runnable {
    MathUtils mu;

    public Thread2(MathUtils mu) {
        this.mu = mu;
    }

    @Override
    public void run() {
        try {
            mu.getMultiples(3);
        } catch (Exception e) {
            System.out.println("Exception raised " + e);
        }
    }
}

class MathUtils {
//    synchronized public void getMultiples(int n){
//        for(int i= 1;i<=5;i++){
//            System.out.println(n*i);
//            try{
//                Thread.sleep(400);
//            }catch (Exception e){
//                System.out.println(e);
//            }
//        }
//    }

    public void getMultiples(int n) {
        synchronized (this) {
            for (int i = 1; i <= 5; i++) {
                System.out.println(n * i);
                try {
                    Thread.sleep(400);
                } catch (Exception e) {
                    System.out.println(e);
                }
            }
        }
    }
}
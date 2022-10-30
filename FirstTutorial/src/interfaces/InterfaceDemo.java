package interfaces;

public class InterfaceDemo {
    public static void main(String args[]) {
        MountainBike mountainBike = new MountainBike(20, 4, 10);
        System.out.println("Gear is: " + mountainBike.getGear());
        System.out.println("seat height is: " + mountainBike.getSeatHeight());
        System.out.println("speed is: " + mountainBike.getSpeed());
        mountainBike.applyBrake(1);
        System.out.println("Speed after break 1s is: " + mountainBike.getSpeed());
        mountainBike.speedUp(2);
        System.out.println("Speed after speedup 2s is: " + mountainBike.getSpeed());
    }
}

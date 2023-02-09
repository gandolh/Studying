package classesDemo;

public class InheritanceDemo {
    public static void main(String args[]){
        MountainBike mountainBike = new MountainBike(20,10,7);
        System.out.println("Gear is: " + mountainBike.gear);
        System.out.println("seatHeight is: " + mountainBike.seatHeight);
        System.out.println("Speed is: " + mountainBike.speed);
        mountainBike.applyBreak(1);
        System.out.println("Speeed after applying break for 1s: " + mountainBike.speed);


    }
}

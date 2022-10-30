package intermediate;


public class MethodOverridingDemo {
    public static void main(String args[]){
        Bicycle bicycle = new Bicycle(10,1);
        System.out.println("Bicycle gear is: " + bicycle.gear);
        System.out.println("Bicycle speed is: " + bicycle.speed);
        bicycle.applyBreak(1);
        System.out.println("Bicycle speed after break 1s is: " + bicycle.speed);
        Bicycle mountainBike = new MountainBike(50,3,50);
        System.out.println("mountain bike gear is: " + mountainBike.gear);
        System.out.println("mountain bike speed is: " + mountainBike.speed);
        mountainBike.applyBreak(1);
        System.out.println("mountain bike after break 1s is: " + mountainBike.speed);

    }
}

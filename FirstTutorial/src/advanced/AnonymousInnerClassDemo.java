package advanced;

public class AnonymousInnerClassDemo {

    public static void main(String args[]){
        Bicycle mountainBike = new MountainBike();
        mountainBike.canApplyBreak();
        mountainBike.canSpeedUp();
        Bicycle bicycle = new Bicycle() {
            @Override
            public void canSpeedUp() {
                System.out.println("Bicycle can speedup anonymous class");

            }

            @Override
            public void canApplyBreak() {
                System.out.println("Bicycle can break anonymous class");

            }
        };
        bicycle.canSpeedUp();
        bicycle.canApplyBreak();
    }
}

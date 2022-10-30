package advanced;

public class MountainBike implements Bicycle{
    @Override
    public void canSpeedUp() {
        System.out.println("Bicycle can speedup");
    }

    @Override
    public void canApplyBreak() {
        System.out.println("Bicycle can break");

    }
}

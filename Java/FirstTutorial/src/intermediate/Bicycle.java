package intermediate;

public class Bicycle {
    protected int gear;
    protected int speed;
    public Bicycle(int gear, int speed){
        this.gear=gear;
        this.speed=speed;
    }

    public void setGear(int gear){
        this.gear=gear;
    }

    public void setSpeed(int speed){
        this.speed=speed;
    }
    public void applyBreak(int decrement){
        speed-=decrement;
    }
    public void speedUp(int increment){
        speed+=increment;
    }
}

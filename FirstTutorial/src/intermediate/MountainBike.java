package intermediate;


class MountainBike extends Bicycle {
    public int seatHeight;

    public MountainBike(int seatHeight, int gear, int speed) {
        super(gear, speed);
        this.seatHeight = seatHeight;
    }

    public void setSeatHeight(int seatHeight) {
        this.seatHeight = seatHeight;
    }

    @Override
    public void setGear(int gear) {
        this.gear = gear + 2;
    }
    @Override
    public void applyBreak(int decrement) {
        speed = speed - 2 - decrement;
    }
    @Override
    public void speedUp(int increment) {
        speed = speed + 2 + increment;
    }
}

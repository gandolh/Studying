package classesDemo;

 class MountainBike extends Bicycle{
    public int seatHeight;
     public MountainBike(int seatHeight,int  gear, int speed) {
         super(gear, speed);
         this.seatHeight= seatHeight;
     }
     public void setSeatHeight(int seatHeight){
         this.seatHeight= seatHeight;
     }

 }

package classesDemo;

public class ClassesDemo {
    public static void main(String args[]){
//        Serialization.Student john = new Serialization.Student("John",25, "23 East, California");
//        System.out.println(john);
//        System.out.println(john.getName());
//        System.out.println(john.getAge());
//        System.out.println(john.getAddress());

        int volume;
        Cuboid stdCuboid = new Cuboid(10,20,15);
        volume = stdCuboid.Volume();
        System.out.println("Volume of simple cuboid is: " + volume);
        Cuboid CuboidWithDefaults = new Cuboid(10,20);
        volume = CuboidWithDefaults.Volume();
        System.out.println("Volume of cuboid with defaults is: " + volume);
        Cuboid cube = new Cuboid(10);
        volume = cube.Volume();
        System.out.println("Volume of cube is: " + volume);
        Cuboid defaultCuboid = new Cuboid();
        volume = defaultCuboid.Volume();
        System.out.println("Volume of default cuboid is: " + volume);

    }
}

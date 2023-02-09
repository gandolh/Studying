package classesDemo;

public class Student {
    static {
        System.out.println("initialize code");
        String colege = "XYZ";
        int count = 0;
    }

    private String name;
    private int age;
    private String address;
    static String college = "XYZ";
    static int count = 0;

    public Student(String name, int age, String address) {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    public String getAddress() {
        return address;
    }

//    static void studentCount() {
//        count++;
//    }
//
//    int getCount() {
//        return count;
//    }
}

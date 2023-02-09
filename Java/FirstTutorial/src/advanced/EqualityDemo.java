package advanced;

public class EqualityDemo {
    public static void main(String args[]){
        Student john1 = new Student("John", 23, "23 East California");
        Student john2 = new Student("John", 23, "23 East California");
        Student john3 = new Student("John", 21, "23 East California");
        System.out.println(john1.equals(john2));
        System.out.println(john1.equals(john3));
    }
}

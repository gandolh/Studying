package classesDemo;

public class StaticDemo {
    public static void main(String args[]){
        Student john = new Student("John",25, "23 Street West");
        System.out.println(john.getName());
        System.out.println(john.getAge());
        System.out.println(john.getAddress());
//        System.out.println(Student.college);
        Student john1 = new Student("John",25, "23 Street West");
        Student john2 = new Student("John",25, "23 Street West");

    }
}

package advanced;

import classesDemo.Student;

public class MethodCallingDemo {

    public static void main(String args[]){
        int i1=1,i2 = 1;
        changeValue(i1);
        i2= incrementValue(i2);
        System.out.println("i1 is :" + i1);
        System.out.println("i2 is :" + i2);
        Student john = new Student("John",1,"1`2");
        ChangeStudentName(john,"Jasmine");
        System.out.println(john.getName());
        ChangeNameInDiffObject(john,"Ion");
        System.out.println(john.getName());

    }
    //doesnt work
    private static void changeValue(int i) {

    i= i+1;
    }
    private static int incrementValue(int i){
        return i+1;
    }
    //se creeaza un obiect nou ce pointeaza la aceeasi adresa de memorie
    private static void ChangeStudentName(Student student, String name){
        student.setName(name);
    }
    private static Student ChangeNameInDiffObject(Student student, String name){
        return new Student(name, student.getAge(), student.getAddress());
    }
}

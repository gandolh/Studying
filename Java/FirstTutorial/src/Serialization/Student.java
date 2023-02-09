package Serialization;

import java.io.Serializable;

public class Student implements Serializable {

    private static final long serialVersionUID = 1L;
    private String name;
    private int age;
    // it will not be serialized;
    private transient int x;

    public Student(){

    }
    public Student(String name, int age){
        this.name=name;
        this.age=age;
    }

    public static long getSerialVersionUID() {
        return serialVersionUID;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
    @Override
    public String toString(){
        return "Student name is: " + this.getName() + ",age is: " + this.getAge();
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }
}

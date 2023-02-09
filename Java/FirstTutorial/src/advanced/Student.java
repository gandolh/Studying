package advanced;

public class Student implements Comparable<Student>{

    private String name;
    private int age;
    private String address;

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
    @Override
    public boolean equals(Object obj){
        if(this == obj)return true;
        if(obj == null  || obj.getClass() != this.getClass())
            return false;
        Student student = (Student)obj;
        return student.age == this.age;
    }
    @Override
    public int hashCode(){
        return this.age;
    }

    @Override
    public int compareTo(Student o) {
        return  this.age - o.age;
    }
}

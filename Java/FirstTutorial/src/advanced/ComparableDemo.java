package advanced;

import java.util.ArrayList;
import java.util.Collections;

public class ComparableDemo {
    public static void main(String args[]){
        ArrayList<Student> list = new ArrayList<>();
        Student john = new Student("john",21,"sad");
        Student jane = new Student("jane",18,"sad");
        Student tom = new Student("tom",20,"sad");
        list.add(john);
        list.add(jane);
        list.add(tom);
        Collections.sort(list);
        System.out.println("Students after age sorting: ") ;
        list.forEach( student -> System.out.println(student.getName()));
        Collections.sort(list,  new NameComparator());
        System.out.println("Students after name sorting: ") ;
        list.forEach( student -> System.out.println(student.getName()));
    }
}

package Serialization;

import java.io.*;

public class SerializationDemo {

    public static void main(String args[]){
        Student student = new Student("John", 23);
        String filename = "D:\\javatest.txt";
        FileOutputStream fileOut = null;
        ObjectOutputStream objOut = null;
        try{
            fileOut = new FileOutputStream(filename);
            objOut = new ObjectOutputStream(fileOut);
            objOut.writeObject(student);
            objOut.close();
            fileOut.close();
            System.out.println("Object has been serialized: \n" + student);
        }catch (IOException ex){
            System.out.println("IOException is caught");
        }
        FileInputStream fileIn = null;
        ObjectInputStream objIn = null;
        try{
            fileIn = new FileInputStream(filename);
            objIn = new ObjectInputStream(fileIn);
            Student object = (Student) objIn.readObject();
            System.out.println("object desearialized\n " + object);

        }catch (IOException ex){
            System.out.println("IOException is caught");

        } catch (ClassNotFoundException e) {
            System.out.println("ClassNotFoundException is caught");
        }
    }
}

package advanced;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class CheckedExceptionDemo {

    public static void main(String args[]) throws FileNotFoundException, IOException, MyException {
        FileReader file = null;
        try {
            file = new FileReader("C:\\test\\a.txt");
            BufferedReader fileInput = new BufferedReader(file);
            for (int counter = 0; counter < 3; counter++) System.out.println(fileInput.readLine());
            fileInput.close();
        } catch (IOException ex) {
            System.err.println("Error with reading from the file");
        } finally {
            System.out.println("This executes at the end no matter what");
            if(file!=null) file.close();
        }
        try {
            throw new MyException();
        }catch (Exception ex){
            System.err.println("Treated exception");
//            throw ex;
        }
    }
}

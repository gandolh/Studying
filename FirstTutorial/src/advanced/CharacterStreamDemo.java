package advanced;

import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class CharacterStreamDemo {
    public static void main(String args[]) throws IOException{
        FileReader readerStream = null;
        FileWriter writerStream = null;
        try{
            readerStream = new FileReader("D:\\srcjava.txt");
            writerStream = new FileWriter("D:\\destjava.txt");
            int content;
            while((content = readerStream.read()) != -1){
                writerStream.write((char)content);
            }
        }finally {
            if(readerStream !=null)
                readerStream.close();
            if(writerStream !=null)
                writerStream.close();
        }
    }
}

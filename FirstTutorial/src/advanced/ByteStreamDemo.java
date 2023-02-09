package advanced;

import java.io.*;

public class ByteStreamDemo {
    public static void main(String args[]) throws IOException {
        FileInputStream inStream = null;
        FileOutputStream outStream = null;
        try{
            inStream = new FileInputStream("D:\\srcjava.txt");
            outStream = new FileOutputStream("D:\\destjava.txt");
            //read a byte at a time
            int content;
            while((content = inStream.read()) != -1){
                outStream.write((byte)content);
            }
        }finally{
            if(inStream !=null)
                inStream.close();
            if(outStream !=null)
                outStream.close();
        }
    }
}

import javax.swing.*;
import java.awt.*;

public class MyFrame extends JFrame {
    MyFrame(){
        this.setTitle("My title");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(420,420);
        this.setVisible(true);
        this.setResizable(false);
        ImageIcon image = new ImageIcon("fox.png");
        this.setIconImage(image.getImage());
//        this.getContentPane().setBackground(Color.green);
//        this.getContentPane().setBackground(new Color(0,120,0));
        this.getContentPane().setBackground(new Color(0x123456));
    }
}

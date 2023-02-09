package GraphicsDemo;

import javax.swing.*;
import java.awt.*;

public class GraphicsDemo extends JFrame {
    GraphicsPanel panel;
    GraphicsDemo(){
        panel = new GraphicsPanel();
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
//        this.setSize(500,500);
        this.add(panel);
        this.pack();
        this.setLocationRelativeTo(null);
        this.setVisible(true);


    }



    public static void main(String[] args) {
        new GraphicsDemo();
    }
}

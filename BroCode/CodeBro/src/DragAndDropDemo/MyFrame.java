package DragAndDropDemo;

import javax.swing.*;

public class MyFrame extends JFrame {
    DragPanel dragPanel = new DragPanel();

    MyFrame(){
        this.add(dragPanel);
        this.setTitle("Drag and drop demo");
        this.setSize(600,600);
        this.setLayout(null);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);


        this.setVisible(true);
    }
}

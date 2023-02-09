import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;

public class PanelsDemo {
    public static void main(String[] args) {
        ImageIcon image = new ImageIcon("fox.png");
        Image newimg = image.getImage().getScaledInstance(120, 120,  java.awt.Image.SCALE_SMOOTH);
        image = new ImageIcon(newimg);
        JLabel label = new JLabel();
        label.setText("Hi");
        label.setIcon(image);
        label.setVerticalAlignment(JLabel.BOTTOM);
        label.setHorizontalAlignment(JLabel.RIGHT);
        label.setBounds(0,120,75,75);

        JFrame frame = new JFrame();
        JPanel redPanel = new JPanel();
        redPanel.setBackground(Color.red);
        redPanel.setBounds(0,0,250,250);
//        redPanel.setLayout(new BorderLayout());
        redPanel.setLayout(null);

        JPanel bluePanel = new JPanel();
        bluePanel.setBackground(Color.blue);
        bluePanel.setBounds(250,0,250,250);
//        bluePanel.setLayout(new BorderLayout());
        bluePanel.setLayout(null);


        JPanel greenPanel = new JPanel();
        greenPanel.setBackground(Color.green);
        greenPanel.setBounds(0,250,500,250);
//        greenPanel.setLayout(new BorderLayout());
        greenPanel.setLayout(null);

        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(null);
        frame.setSize(750,750);
        frame.setVisible(true);
        greenPanel.add(label);
        frame.add(redPanel);
        frame.add(bluePanel);
        frame.add(greenPanel);

    }
}

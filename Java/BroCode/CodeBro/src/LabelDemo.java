import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;

public class LabelDemo {

    public static void main(String[] args) {
        ImageIcon image = new ImageIcon("fox.png");
        Border border = BorderFactory.createLineBorder(Color.YELLOW,3);
        Image newimg = image.getImage().getScaledInstance(120, 120,  java.awt.Image.SCALE_SMOOTH); // scale it the smooth way
        image = new ImageIcon(newimg);
        JLabel label = new JLabel();
        label.setText("Hello from gandolh");
        label.setIcon(image);
        label.setHorizontalTextPosition(JLabel.CENTER);
        label.setVerticalTextPosition(JLabel.BOTTOM);
        label.setHorizontalAlignment(JLabel.CENTER);
        label.setForeground(Color.lightGray);
        label.setFont(new Font("MV Boli", Font.PLAIN, 20));
        label.setIconTextGap(25);
        label.setBackground(Color.black);
        label.setOpaque(true);
        label.setBorder(border);
//        label.setBounds(100,100,250,250);
        JFrame frame = new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
//        frame.setSize(400,400);
//        frame.setLayout(null);
        frame.setVisible(true);
        frame.add(label);
        frame.pack();

    }
}

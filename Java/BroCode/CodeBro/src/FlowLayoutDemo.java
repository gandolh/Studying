import javax.swing.*;
import java.awt.*;

public class FlowLayoutDemo {
    public static void main(String[] args) {
        JFrame frame = new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(500,500);
//        frame.setLayout(new FlowLayout(FlowLayout.LEADING));
//        frame.setLayout(new FlowLayout(FlowLayout.TRAILING));
//        frame.setLayout(new FlowLayout(FlowLayout.CENTER));
        frame.setLayout(new FlowLayout(FlowLayout.CENTER,10,10));
        JPanel panel = new JPanel();
        panel.setPreferredSize(new Dimension(100,250));
        panel.setBackground(Color.lightGray);
        panel.setLayout(new FlowLayout());
        for(int i=0;i<=12;i++){
            panel.add(new JButton(String.valueOf(i)));
        }
        frame.add(panel);
        frame.setVisible(true);

    }
}

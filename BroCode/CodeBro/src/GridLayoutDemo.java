import javax.swing.*;
import java.awt.*;

public class GridLayoutDemo {
    public static void main(String[] args) {
        JFrame frame = new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(500, 500);
        frame.setLayout(new GridLayout(3,3,5,5));
        for (int i = 1; i <= 9; i++)
            frame.add(new JButton(String.valueOf(i)));
        frame.setVisible(true);

    }
}

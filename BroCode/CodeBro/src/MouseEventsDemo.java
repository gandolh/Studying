import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.File;

public class MouseEventsDemo extends JFrame implements MouseListener {
    JButton button;
    JLabel label;

    MouseEventsDemo() {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(null);

        ImageIcon icon = new ImageIcon("fox.png");
        label = new JLabel();
        label.setBounds(0, 0, 100, 100);
//        label.setIcon(new ImageIcon(
//                new ImageIcon("fox.png")
//                        .getImage()
//                        .getScaledInstance(100, 100, java.awt.Image.SCALE_SMOOTH)
//        ));
        label.setBackground(Color.yellow);
        label.setOpaque(true);
        label.addMouseListener(this);
        this.add(label);
        this.setSize(500, 500);
        this.setVisible(true);
    }


    public static void main(String[] args) {
        new MouseEventsDemo();
    }


    @Override
    public void mouseClicked(MouseEvent e) {
        System.out.println("You clicked the mouse");
        label.setBackground(Color.PINK);
    }

    @Override
    public void mousePressed(MouseEvent e) {
        System.out.println("You pressed the mouse");
        label.setBackground(Color.PINK);

    }

    @Override
    public void mouseReleased(MouseEvent e) {
        System.out.println("You released the mouse");
        label.setBackground(Color.GREEN);

    }

    @Override
    public void mouseEntered(MouseEvent e) {
        System.out.println("You entered the component");
        label.setBackground(Color.BLUE);

    }

    @Override
    public void mouseExited(MouseEvent e) {
        System.out.println("You exited the component");
        label.setBackground(Color.RED);


    }
}

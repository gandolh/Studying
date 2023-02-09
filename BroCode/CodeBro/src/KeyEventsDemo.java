import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.io.File;

public class KeyEventsDemo extends JFrame implements KeyListener {
    JButton button;
    JLabel label;

    KeyEventsDemo() {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(null);
        ImageIcon icon = new ImageIcon("fox.png");

        label = new JLabel();
        label.setBounds(0, 0, 100, 100);
//        label.setBackground(Color.RED);
//        label.setOpaque(true);
        label.setIcon(new ImageIcon(
                new ImageIcon("fox.png")
                        .getImage()
                        .getScaledInstance(100, 100, java.awt.Image.SCALE_SMOOTH)
        ));

        this.addKeyListener(this);
        this.add(label);
        this.getContentPane().setBackground(Color.black);
        this.setSize(500, 500);
        this.setVisible(true);
    }


    public static void main(String[] args) {
        new KeyEventsDemo();
    }


    @Override
    public void keyTyped(KeyEvent e) {
        //keys
        int speed = 10;
        switch (e.getKeyChar()) {
            case 'a':
                label.setLocation(label.getX() - speed, label.getY());
                break;
            case 'd':
                label.setLocation(label.getX() + speed, label.getY());
                break;
            case 'w':
                label.setLocation(label.getX(), label.getY() - speed);
                break;
            case 's':
                label.setLocation(label.getX(), label.getY() + speed);
                break;
            default:
                break;
        }
    }

    @Override
    public void keyPressed(KeyEvent e) {
        //arrows
        int speed = 10;
        switch (e.getKeyCode()) {
            case 37:
                label.setLocation(label.getX() - speed, label.getY());
                break;
            case 39:
                label.setLocation(label.getX() + speed, label.getY());
                break;
            case 38:
                label.setLocation(label.getX(), label.getY() - speed);
                break;
            case 40:
                label.setLocation(label.getX(), label.getY() + speed);
                break;
            default:
                break;
        }
    }

    @Override
    public void keyReleased(KeyEvent e) {
        System.out.println("You released the keychar:" + e.getKeyChar());
        System.out.println("You released the keycode:" + e.getKeyCode());
    }
}

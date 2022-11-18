import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

public class ColorChooserDemo extends JFrame implements ActionListener {
    JButton button;
    JLabel label;

    ColorChooserDemo() {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());

        button = new JButton("Pick a color");
        label = new JLabel();
        label.setBackground(Color.white);
        label.setText("This is some text");
        label.setFont(new Font(null, Font.PLAIN,100));
        label.setOpaque(true);
        button.addActionListener(this);
        this.add(button);
        this.add(label);

        this.pack();
        this.setVisible(true);
    }


    public static void main(String[] args) {
        new ColorChooserDemo();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == button) {
                JColorChooser chooser = new JColorChooser();
                Color color = JColorChooser.showDialog(null,"Pick a color", Color.BLACK);
//                label.setForeground(color);
                label.setBackground(color);
            }
        }
    }

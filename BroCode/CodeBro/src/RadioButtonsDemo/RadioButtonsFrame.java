package RadioButtonsDemo;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class RadioButtonsFrame extends JFrame implements ActionListener {
    RadioButtonsFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());

        JRadioButton pizzaButton = new JRadioButton("pizza");
        JRadioButton hamburgerButton = new JRadioButton("hamburger");
        JRadioButton hotdogButton = new JRadioButton("hotdog");
        ButtonGroup group = new ButtonGroup();
        group.add(pizzaButton);
        group.add(hamburgerButton);
        group.add(hotdogButton);
        pizzaButton.setIcon(new ImageIcon(new ImageIcon("fox.png").getImage().getScaledInstance(20, 20,  java.awt.Image.SCALE_SMOOTH)));
        this.add(pizzaButton);
        this.add(hamburgerButton);
        this.add(hotdogButton);

        this.pack();
        this.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {

    }
}

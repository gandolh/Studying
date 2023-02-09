package Checkbox;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class CheckboxFrame extends JFrame implements ActionListener {
    JButton button = new JButton();
    JCheckBox checkBox = new JCheckBox();


    CheckboxFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());
        button.setText("submit");
        button.addActionListener(this);

        checkBox.setText("I'm not a robot");
        checkBox.setFocusable(false);
        checkBox.setFont(new Font(null,Font.PLAIN,35));
        this.add(checkBox);
        this.add(button);
        this.pack();
        this.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == button){
            System.out.println(checkBox.isSelected());
        }
    }
}

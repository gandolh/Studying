import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLOutput;

public class ButtonFrame extends JFrame implements ActionListener {
    JButton button;
    JLabel label;
    ButtonFrame(){
        ImageIcon icon = new ImageIcon("fox.png");
        Image newimg = icon.getImage().getScaledInstance(20, 20,  java.awt.Image.SCALE_SMOOTH); // scale it the smooth way
        icon = new ImageIcon(newimg);
        ImageIcon icon2 = new ImageIcon("fox.png");
        newimg = icon2.getImage().getScaledInstance(20, 20,  java.awt.Image.SCALE_SMOOTH); // scale it the smooth way
        icon2 = new ImageIcon(newimg);

        label = new JLabel();
        label.setIcon(icon2);
        label.setBounds(150,250,150,150);
        label.setVisible(false);
        button = new JButton();
        button.setBounds(100,100,250,100);
        button.addActionListener(this);
//        button.addActionListener(e -> System.out.println("poo"));
        button.setText("I'm a button");
        button.setFocusable(false);
        button.setIcon(icon);
        button.setHorizontalTextPosition(JButton.CENTER);
        button.setVerticalTextPosition(JButton.BOTTOM);
        button.setFont(new Font("Comic Sans", Font.BOLD,25));
        button.setIconTextGap(15);
        button.setForeground(Color.CYAN);
        button.setBackground(Color.lightGray);
        button.setBorder(BorderFactory.createEtchedBorder());
//        button.setEnabled(false);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(null);
        this.setSize(500,500);
        this.setVisible(true);
        this.add(button);
        this.add(label);

    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == button){
            System.out.println("poo");
//            button.setEnabled(false);
            label.setVisible(true);
        }
    }
}

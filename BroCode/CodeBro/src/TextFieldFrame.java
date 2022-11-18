import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLOutput;

public class TextFieldFrame  extends JFrame implements ActionListener {
    JButton button = new JButton("Submit");
    JTextField field =  new JTextField();

    TextFieldFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());
        button.addActionListener(this);

        field.setPreferredSize(new Dimension(250,40));
        field.setFont(new Font(null,Font.ITALIC,35));
        field.setForeground(Color.GREEN);
        field.setBackground(Color.BLACK);
        field.setCaretColor(Color.white);
        field.setText("Username");
        this.add(field);
        this.add(button);



        this.pack();
        this.setVisible(true);

    }
    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == button){
            System.out.println(field.getText()) ;
            field.setEditable(false);
            button.setEnabled(false);
        }
    }
}

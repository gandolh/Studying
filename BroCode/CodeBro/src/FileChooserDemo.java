import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

public class FileChooserDemo extends JFrame implements ActionListener {
    JButton button;

    FileChooserDemo() {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());

        button = new JButton("select File");
        button.addActionListener(this);
        this.add(button);


        this.pack();
        this.setVisible(true);
    }


    public static void main(String[] args) {
        new FileChooserDemo();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == button) {
            JFileChooser chooser = new JFileChooser();
            int response = chooser.showOpenDialog(null); // select file to open
            if(response ==JFileChooser.APPROVE_OPTION){
                File file = new File(chooser.getSelectedFile().getAbsolutePath());
                System.out.println(file);
            }
        }
    }
}

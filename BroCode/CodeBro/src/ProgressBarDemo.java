
import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import java.awt.*;

public class ProgressBarDemo  {
    JFrame frame;
    JProgressBar bar;
    public static void main(String[] args) {
        ProgressBarDemo demo = new ProgressBarDemo();
    }

    ProgressBarDemo(){
        frame = new JFrame("Slider demo");
        bar = new JProgressBar();

        bar.setValue(0);
        bar.setBounds(0,0,420,50);
        bar.setStringPainted(true);
        bar.setFont(new Font(null, Font.BOLD, 25));

        frame.add(bar);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(420,420);
        frame.setLayout(null);
        frame.setVisible(true);

        fill();
    }

    public void fill(){
        int counter = 0;
        while(counter <=100){
            bar.setValue(counter);
            try {
                Thread.sleep(100);
            }catch(InterruptedException e){
                e.printStackTrace();
            }
            counter++;
        }
        bar.setString("Done!");
    }


}

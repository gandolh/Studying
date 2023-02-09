import javax.swing.*;
import java.awt.*;

public class DialogBoxDemo {
    public static void main(String[] args) {
//        JOptionPane.showMessageDialog(null, "This is some useless info",
//                "Title", JOptionPane.PLAIN_MESSAGE);
//        JOptionPane.showMessageDialog(null, "This is some useless info",
//                "Title", JOptionPane.INFORMATION_MESSAGE);
//        JOptionPane.showMessageDialog(null, "This is some useless info",
//                "Title", JOptionPane.QUESTION_MESSAGE);
//        JOptionPane.showMessageDialog(null, "This is some useless info",
//                "Title", JOptionPane.WARNING_MESSAGE);
//        JOptionPane.showMessageDialog(null, "This is some useless info",
//                "Title", JOptionPane.ERROR_MESSAGE);
//        while(true){
//            JOptionPane.showMessageDialog(null, "You're computer has a virus",
//                    "Title", JOptionPane.WARNING_MESSAGE);
//        }

//        int answer = JOptionPane.showConfirmDialog(null, "Bro, do you even code?", "Title", JOptionPane.YES_NO_CANCEL_OPTION);
//        String name = JOptionPane.showInputDialog("What's your name?");
//        System.out.println("Hello, " +name);
    ImageIcon icon = new ImageIcon("fox.png");
        Image newimg = icon.getImage().getScaledInstance(20, 20,  java.awt.Image.SCALE_SMOOTH); // scale it the smooth way
        icon = new ImageIcon(newimg);
        String[] responses = {"No, you're awesome", "Thank you", "blush"};

        JOptionPane.showOptionDialog(null,"you're awesome", "secret message",
                JOptionPane.YES_NO_CANCEL_OPTION, JOptionPane.INFORMATION_MESSAGE,icon,responses,0);

    }
}

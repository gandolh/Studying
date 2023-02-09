package TwoDAnimationDemo;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class AnimationPanel extends JPanel implements ActionListener {
    final int panelWidth = 500;
    final int panelHeight = 500;
    Image fox;
    Timer timer;
    int xVelocity = 2;
    int yVelocity = 1;
    int x = 0;
    int y = 0;
    AnimationPanel(){
        this.setPreferredSize(new Dimension(panelWidth, panelHeight));
        this.setBackground(Color.black);
        fox = new ImageIcon("fox.png").getImage().getScaledInstance(50, 50, java.awt.Image.SCALE_SMOOTH);
        fox = new ImageIcon(fox).getImage();
        timer = new Timer(10,this);
        timer.start();

    }

    public void paint(Graphics g){
        super.paint(g);
        Graphics2D g2D = (Graphics2D) g;
        g2D.drawImage(fox,x,y,null);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(x>= panelWidth - fox.getWidth(null) || x<0)
            xVelocity*=-1;
        if(y>= panelHeight - fox.getHeight(null) || y<0)
            yVelocity*=-1;
        x+= xVelocity;
        y+=yVelocity;
        repaint();
    }
}

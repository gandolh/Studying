package DragAndDropDemo;

import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionAdapter;

public class DragPanel extends JPanel {
    ImageIcon icon;
    final int WIDTH;
    final int HEIGHT;
    Point imageCorner;
    Point prevPT;
    DragPanel(){
        icon = new ImageIcon(
                new ImageIcon("fox.png")
                        .getImage()
                        .getScaledInstance(100, 100, java.awt.Image.SCALE_SMOOTH)
        );
        WIDTH = icon.getIconWidth();
        HEIGHT = icon.getIconHeight();
        imageCorner = new Point(0,0);
        ClickListener clickListener = new ClickListener();
        DragListener dragListener = new DragListener();
        this.addMouseListener(clickListener);
        this.addMouseMotionListener(dragListener);
        this.setBackground(Color.LIGHT_GRAY);
        this.setSize(300,300);
        this.setOpaque(true);

    }
    public void paintComponent(Graphics g){

        super.paintComponent(g);
        icon.paintIcon(this,g, (int) imageCorner.getX(), (int) imageCorner.getY());

    }

    private class ClickListener extends MouseAdapter{
        public void mousePressed(MouseEvent e){
            prevPT = e.getPoint();

        }
    }

    private class DragListener extends MouseMotionAdapter{
        public void mouseDragged(MouseEvent e ){
            Point currentPT = e.getPoint();
            imageCorner.translate(
                    (int)(currentPT.getX() - prevPT.getX()),
                    (int)(currentPT.getY() - prevPT.getY())
            );
            prevPT = currentPT;
            repaint();
        }
    }
}

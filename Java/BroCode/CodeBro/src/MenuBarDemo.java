import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.sql.SQLOutput;

public class MenuBarDemo implements ActionListener {
    JFrame frame;
    JMenuItem loadItem ;
    JMenuItem saveItem;
    JMenuItem exitItem ;
    public static void main(String[] args) {
        MenuBarDemo demo = new MenuBarDemo();
    }

    MenuBarDemo(){
        frame = new JFrame("Slider demo");
        JMenuBar menuBar = new JMenuBar();
        JMenu fileMenu = new JMenu("file");
        JMenu editMenu = new JMenu("edit");
        JMenu helpMenu = new JMenu("help");
        loadItem = new JMenuItem("Load");
        saveItem = new JMenuItem("Save");
        exitItem = new JMenuItem("exit");
        loadItem.addActionListener(this);
        saveItem.addActionListener(this);
        exitItem.addActionListener(this);
        fileMenu.setMnemonic(KeyEvent.VK_F); // alt + f
        loadItem.setMnemonic(KeyEvent.VK_L); // l for load
        saveItem.setMnemonic(KeyEvent.VK_S); // s for save
        exitItem.setMnemonic(KeyEvent.VK_E);
        fileMenu.add(loadItem);
        fileMenu.add(saveItem);
        fileMenu.add(exitItem);

        menuBar.add(fileMenu);
        menuBar.add(editMenu);
        menuBar.add(helpMenu);
        frame.setJMenuBar(menuBar);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(420,420);
        frame.setLayout(new FlowLayout());
        frame.setVisible(true);

    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == loadItem)
            System.out.println("Loaded file");
        else if(e.getSource() == saveItem)
            System.out.println("Saved file");
        else System.exit(0);
    }
}

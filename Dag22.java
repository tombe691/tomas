package adventskalender1;

import javax.swing.*;
import java.awt.*;
import java.awt.Color;
import java.awt.GridBagLayout;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.UIManager;



class Dag22{
    public static void Lucka22(){
                    try{
            ImageIcon ikon = new ImageIcon("C:\\Users\\NiklasAhl\\Downloads\\julgran.png");
            JOptionPane.showMessageDialog(null, "22 December \nIdag ska vi rita ut en gran gjord av plustecken", "Lucka 22", JOptionPane.INFORMATION_MESSAGE, ikon);
                        
            String s = JOptionPane.showInputDialog("Mata in höjden på granen");
            if (s == null){
                System.exit(0);
                        }
            String tree = "";
            int treeSize = Integer.parseInt(s);

            for (int i = 0; i < treeSize; i++) {
                int loopCount = 0;
                for (int j = 0; j < treeSize - i; j++) {
                    tree = tree + "  ";
                }
                while (loopCount < 2 * i + 1) {
                    tree = tree + "+";
                    loopCount++;
                }
                tree = tree + "\n";
            }
                        
                         
                        
                        
                        JLabel label = new JLabel();
                        label.setForeground(Color.GREEN);
                        JOptionPane.showMessageDialog(null, tree);
                        //UIManager um = new UIManager();
                        //UIManager.put("OptionPane.messageForeground", new Color(20, 137, 12));
                        //JOptionPane.showMessageDialog(null, tree);
        }
        catch(HeadlessException | NumberFormatException e){
            JOptionPane.showMessageDialog(null, "Felaktig inmatning!");
        }
               
    }
    }    


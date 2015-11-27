// Filen BildEx.java
 
 import java.awt.*;
 import java.awt.event.*; 
 import javax.swing.*;

 public class BildEx extends JFrame implements ActionListener {
   private int bildNr = 0;
   private JLabel l  = new JLabel(new ImageIcon("bild" + bildNr + ".gif"));
   private JLabel l2 = new JLabel("Tomas testar");
   private JButton b = new JButton("Växla bild");

   public BildEx() { 
     setLayout(new FlowLayout()); 
     add(l); add(b); add(l2);
     b.addActionListener(this); 
     setSize(800,600);   
     setVisible(true); 
     setDefaultCloseOperation(EXIT_ON_CLOSE); 
   }

   // lyssnarmetod
   public void actionPerformed(ActionEvent e) {
     bildNr = (bildNr + 1) % 2;
     l.setIcon(new ImageIcon("bild" + bildNr + ".gif"));
   }

   public static void main (String[] arg) {
     BildEx b = new BildEx();
   }
 }
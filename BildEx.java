// Filen BildEx.java
 
 import java.awt.*;
 import java.awt.event.*; 
 import javax.swing.*;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
 import java.awt.*;
 import java.awt.event.*; 
 import javax.swing.*;

import javax.swing.ImageIcon;
import javax.swing.JPanel;
import javax.swing.Timer;

 public class BildEx extends JFrame implements ActionListener {
   private int bildNr = 2;
   private JLabel l  = new JLabel(new ImageIcon("bild" + bildNr + ".jpg"));
     //private JLabel l = new JLabel("Tomas testar");
   private JLabel l2 = new JLabel("Tomas testar");
   private JButton button = new JButton("Växla bild");
   private JButton one = new JButton("1");
   private JButton plus = new JButton("+");
   private JTextArea display = new JTextArea(5,20);
   private JTextField textfield = new JTextField(20);
     private Image background;

   public BildEx() { 
       setLayout(new FlowLayout()); 
          add(l); add(button); add(one); add(plus); add(display); add(textfield); add(l2);
	  //getContentPane().add(l);
     button.addActionListener(this);
     getContentPane().add(button);
     button.setBounds(206, 165, 92, 71); 
     setSize(1150,720);   
     setVisible(true); 
     setDefaultCloseOperation(EXIT_ON_CLOSE); 
     /*for (int i=0;i<30000;i++){
     for (int j=0;j<300000;j++){
     for (int k=2;k<3;k++){
	     }
	     }
	     }
     l.setIcon(new ImageIcon("bild" + 1 + ".gif"));
getContentPane().add(l);
     l.setBounds(0, 0, 710, 450);
     pack();*/
   }

   // lyssnarmetod
   public void actionPerformed(ActionEvent e) {

       //ageIcon bg = new ImageIcon("bild2.jpg");
       //ckground = bg.getImage();    
       //drawImage(background, 0, 0, 620, 620, this);

	//       bildNr = 1;//(bildNr + 1) % 2;
	//l.setIcon(new ImageIcon("bild" + bildNr + ".gif"));
	//getContentPane().add(l);
	//l.setBounds(0, 0, 710, 450);
       System.out.println(textfield.getText());

     System.out.println(button.getText());
     display.append(textfield.getText()+"\n");
     display.setFont(new Font("Serif", Font.ITALIC, 16));
     display.setLineWrap(true);
     display.setWrapStyleWord(true);
   }

   public static void main (String[] arg) {
     BildEx b = new BildEx();
   }
     /*  public void paintComponent(Graphics g) {
        //super.paintComponent(g);

        doDrawing(g);
    }
    
    private void doDrawing(Graphics g) 
    {
        g.drawImage(background, 0, 0, 620, 620, this);
	}*/
 }

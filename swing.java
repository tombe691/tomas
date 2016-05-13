 import java.awt.*;
 import java.awt.event.*; 
 import javax.swing.*;

 public class swing extends JFrame implements ActionListener {
   private JButton button = new JButton("Tryck");
   private JButton button2 = new JButton("Har");
   public swing() { 
     setLayout(new FlowLayout()); 
     add(button);
     add(button2);
     button.addActionListener(this); 
     button2.addActionListener(this);
     setSize(800,600);   
     setVisible(true); 
     setDefaultCloseOperation(EXIT_ON_CLOSE); 
   }

   // lyssnarmetod
   public void actionPerformed(ActionEvent e) {
       String action = e.getActionCommand();

        if (action.equals("Tryck")) {

            System.out.println("Tryck button pressed!");

        }

        else if (action.equals("Har")) {

            System.out.println("Har Button pressed!");

        }

	//System.out.println(button.getText());
	System.out.println("ACTION "+action);
   }

   public static void main (String[] arg) {
     swing b = new swing();
   }
 }

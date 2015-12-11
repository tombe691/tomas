package advkalender;
​
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import javax.swing.*;
​
public class henrikskod
{
    private JFrame f;
    private JPanel pWest;
    private JPanel pCenter;
    private JPanel pSouth;
    private JButton b1;
    
    private JLabel lab1;
    private JLabel lab2;
    
    public void gui(String title, String content, File file)
    {
        BufferedImage img = null;
        try 
        {
        System.out.println("in gui try");
        img = ImageIO.read(file);
        } 
        catch (IOException e) 
        {
            System.out.println("Failed to get file");
        }
        
        f = new JFrame(title);
        f.setVisible(true);
        f.setSize(800, 600);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       System.out.println("created new frame"); 
        pWest = new JPanel();
        pWest.setBackground(new Color(252,117,117));
        
        pCenter = new JPanel();
        pCenter.setBackground(new Color(212,41,41));
        
        pSouth = new JPanel();
        pSouth.setBackground(Color.LIGHT_GRAY);
        
        lab1 = new JLabel(content);
        lab1.setForeground(Color.WHITE);
        
        lab2 = new JLabel();
        lab2.setIcon(new ImageIcon(img));
        
​
        pWest.add(lab2);
        
        pCenter.add(lab1);
      
        b1 = new JButton("Bakat");
        pSouth.add(b1);
        
        f.add(pWest, BorderLayout.WEST);
        f.add(pCenter, BorderLayout.CENTER);
        f.add(pSouth, BorderLayout.SOUTH);
    }
    
    public void Dec7()
    {
        String titel = "7 December";
        String content = "<html>Den har boken ar sa javla grym,\n kop den sa far ni \n</html>"
                + "<html>cykel pa kopet fo fan!</html>";
        File file = new File("C://Users/HLagerholm/Documents/NetBeansProjects/Advkalender_1/images/tomten.jpg");
        System.out.println("in dec7" + file);
        gui(titel, content, file);
    }
​
    public void Dec15() 
    {
         String titel = "15 December";
        String content = "fy fan vad cool bok, man maste ju ha den!?";
        //gui(titel, content);
    }
    
     public void Dec19() 
    {
        String titel = "19 December";
        String content = "OJ OJ OJ, VILKEN HAFTIG BOK";
        //gui(titel, content);
    }
     
     public void Dec21() 
    {
         String titel = "21 December";
        String content = "Cooling boken, sa cool man far vara =O";
        //gui(titel, content);
    }
     
    public static void main(String[] args) 
    {
        HenrikL dec1 = new HenrikL();
        dec1.Dec7();
        
    }
}

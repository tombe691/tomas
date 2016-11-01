package ak;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import javax.swing.*;
 
public class testa
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
       
 
        pWest.add(lab2);
       
        pCenter.add(lab1);
     
        b1 = new JButton("Bakåt");
        pSouth.add(b1);
       
        //f.add(pWest, BorderLayout.WEST);
        f.add(pCenter, BorderLayout.CENTER);
        f.add(pSouth, BorderLayout.SOUTH);
    }
   
    public void Dec7()
    {
        String titel = "7 December";
        String content = "<html>Den här boken är så jävla grym,\n köp den så får ni \n</html>"
                + "<html>cykel på köpet fö fan!</html>";
            File file = new File("C:\\Users\\Mikael\\Documents\\NetBeansProjects\\AK\\divfiles\\Dec1ernst.jpg");
             System.out.println("in dec7" + file);
        gui(titel, content, file);
            
    }
 
    public void Dec15()
    {
         String titel = "15 December";
        String content = "fy fan vad cool bok, man måste ju ha den!?";
        gui(titel, content);
    }
   
     public void Dec19()
    {
        String titel = "19 December";
        String content = "OJ OJ OJ, VILKEN HÄFTIG BOK";
        gui(titel, content);
    }
     
     public void Dec21()
    {
         String titel = "21 December";
        String content = "Cooling boken, så cool man får vara =O";
        gui(titel, content);
    }
     
    public static void main(String[] args)
    {
        testa testa = new testa();
        testa.Dec7();
       
    }

    private void gui(String titel, String content) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

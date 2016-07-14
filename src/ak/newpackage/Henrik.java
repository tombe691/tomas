package newpackage;


import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.image.BufferedImage;
import java.io.IOException;
import java.net.URL;
import java.awt.event.*;
import javax.imageio.ImageIO;
import javax.swing.*;
 
public class Henrik
{
    private JFrame f;
    private JPanel pWest;
    private JPanel pCenter;
    private JPanel pSouth;
    private JButton b1;
     
    private JLabel lab1;
    private JLabel lab2;
     
    public void gui(String title, String content, String imageUrl)
    {
        BufferedImage img = null;
        try
        {
            System.out.println("in gui try");
        URL url = new URL(imageUrl);
        img = ImageIO.read(url);
        } 
        catch (IOException e) 
        {
            System.out.println("Failed to get file");
        }
         
        f = new JFrame(title);
        f.setSize(600, 500);
        f.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
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
        b1.addActionListener(
                new ActionListener() 
                {
                    @Override
                    public void actionPerformed(ActionEvent e) 
                    {
                        f.dispose();
                    }
                }
        );
        f.add(pWest, BorderLayout.WEST);
        f.add(pCenter, BorderLayout.CENTER);
        f.add(pSouth, BorderLayout.SOUTH);
        f.setVisible(true);
    }
     
 
    public void Dec15()
    {
        String titel = "15:e December, Henrik Lagerholm"; //tomten
        String content = "<html><br>Titel: \"Tomten\" av Viktor Rydberg<br><br> Betyg: 10/10 <br><br>Klart det ska vara tomtar i en jul! <br> "
                + "Eller hur...?</html>";
        String imageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTQ59FbU0EU0hbEYVgOYwPS8qn_zpn3OVsWXD3-jjCMISbqDId_bA";
        gui(titel, content, imageUrl);
    }
     
     public void Dec19() 
    {
         String titel = "19:e December, Henrik Lagerholm"; //fågeln
         String content = "<html><br>Titel: \"En Röd liten fågel vid Juletid \" <br>av Fannie Flagg<br><br> Betyg: 8/10 <br><br>Vad är det för jul utan fåglar? <br> "
                + "Eller hur...?</html>";
         String imageUrl = "http://media.bonnierforlagen.se/bokbilder/b/9789100107741.jpg";
         gui(titel, content, imageUrl);
    }
      
     public void Dec21() 
    {
         String titel = "21:e December, Henrik Lagerholm";//Julsaga
         String content = "<html><br>Titel: \"En Julsaga\" av Charles Dickens<br><br> Betyg: 1/10 <br><br>Den har inga tomtar ju... <br> "
                + "Eller hur...?</html>";
         String imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Marley%27s_Ghost-John_Leech%2C_1843.jpg/320px-Marley%27s_Ghost-John_Leech%2C_1843.jpg";
         gui(titel, content, imageUrl);
    }
    
    public void main() 
    {
        Henrik dec1 = new Henrik();
        dec1.Dec15();
        //dec1.Dec19();
        //dec1.Dec21();
    }
}
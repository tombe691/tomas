/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package newpackage;
import java.awt.image.BufferedImage;
import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import java.io.IOException;
import java.net.URL;
/**
 *
 * @author Mikael
 */
public class Viktor {
   
    public void Dec17() {
        String imageUrl = "http://julbordsguiden.se/cache/widgetkit/Klassiskt_julbord_Artipelag2-c8bfd94036.jpg";
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
        ImageIcon icon = new ImageIcon(img);

        String s1="En klassisk rätt";
        JOptionPane.showMessageDialog(null, s1, "17e December", JOptionPane.PLAIN_MESSAGE, icon);
    }
    public void Dec10() {
        String imageUrl = "http://cdn.rdb.arla.com/Files/arla-se/3162886431/401cd0f1-75b5-4af3-94da-24a16d31be9e.jpeg?preset=Main";
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
        ImageIcon icon = new ImageIcon(img);

        String s1="Klassisk knäck";
        JOptionPane.showMessageDialog(null, s1, "10e December", JOptionPane.PLAIN_MESSAGE, icon);
    }
    public void Dec22() {
        String imageUrl = "http://www.ica.se/imagevaultfiles/id_16173/cf_1286/554640-honungsrostade_n-tter-ingefarscrisp_b1106.jpg";
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
        ImageIcon icon = new ImageIcon(img);

        String s1="Ett klassiskt Recept\n" +
                " ca 70 g hasselnötter\n" +
                "ca 70 g sötmandel\n" +
                "ca 70 g cashewnötter\n" +
                "1 tsk råsocker\n" +
                "1 tsk sambal oelek\n" +
                "1 tsk salt\n" +
                "1 msk vatten\n" +
                "1 tsk honung\n" +
                " Så här gör du\n" +
                "\n" +
                "Sätt ugnen på 225°C.\n" +
                "Blanda nötterna med råsocker, sambal oelek, salt och vatten. Rosta blandningen i ugnen i ca 10 minuter, rör om ett par gånger.\n" +
                "Ta ut nötterna och rör i honungen, låt svalna och servera.\n" +
                "För alla\n" +
                "Fri från gluten, laktos, mjölkprotein och ägg.";
        JOptionPane.showMessageDialog(null, s1, "22e December", JOptionPane.PLAIN_MESSAGE, icon);
    }
    public void Dec4() {
        String imageUrl = "http://mittkok.expressen.se/wp-content/uploads/2013/12/63cd1606-3931-4ddf-b111-96df9b439e1b-305x305.jpg";
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
        ImageIcon icon = new ImageIcon(img);

        String s1="1 stor burk\n"+
        		"\n"+

        		"Ingredienser\n"+
        		"\n"+
        		"400 g saltsillfiléer\n\n "
        		+ "Tillagen\n\n"
        		+ "3,5 dl vatten\n"+
"1 1/2 dl socker\n"+
"1 dl ättikssprit (12 %) - kan ökas till 1 1/2 dl, om ni gillar lite mer ättiksbett\n"+
"8 kryddpepparkorn, krossade\n"+
"1 kanelstång, krossad\n"+
"1 liten bit torkad ingefära, krossad (går även med en lite större bit strimlad, färsk ingefära)\n"+
"5 krossade nejlikor\n"+
"10 hela nejlikor\n"+
"lite muskotblomma\n"+
"finstrimlad zest (yttre delen av skalen) från en klementin (eller från 1/3 apelsin)\n"+
"lite halvkrossad kardemumma\n"+
"3-4 finhackade ansjovisar + allt spadet från ansjovisburken\n"+
"1/2 dl vardera av mycket finhackad morot, purjolök och rödlök (lika mycket till går åt några dagar senare, inför serveringen.)\n\n"+
"Vattna ur saltsillfiléerna enligt förpackningsanvisningarna (eller använd i nödfall färdigurvattnad inläggningssill).\n"+
"Koka ingredienserna till lagen, låt sjuda en liten stund och ställ kallt. (Det är mycket viktigt att den blir kylskåpskall.)\n"+
"Skär sillfiléerna i lagom stora bitar. Varva bitarna med finhackad morot, purjo- och rödlök. Häll över lagen.\n"+
"Låt stå i minst två, helst tre dygn i kylskåpet. Rör om en gång om dagen.\n"+
"Detta är en klassisk sillinläggning, men som jag kryddat med glöggkryddor och citrus. Jag har lagat den till jul under ett tiotal\n" +
"år varunder de exakta proportionerna vuxit fram. Jag älskar klassisk, inlagd sill allra mest, men tycker att det är roligt med några olika sorter –\n" +
"och då gärna några som sticker ut lite grand i kryddningen, som denna med sin kraftiga klementinton\n";
        JOptionPane.showMessageDialog(null, s1, "4e December", JOptionPane.PLAIN_MESSAGE, icon);
    }
   
}

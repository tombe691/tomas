package newpackage;

import java.applet.Applet;
import java.applet.AudioClip;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileReader;
import java.io.InputStreamReader;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import java.net.MalformedURLException;
import java.net.URL;

public class Micke {
    public void Dec1() throws Exception {
        String s1 = "";
        FileInputStream fis = new FileInputStream(".\\divfiles\\Dec1ernst.txt");
        InputStreamReader isr = new InputStreamReader(fis, "UTF8");
        BufferedReader br = new BufferedReader(isr);
        s1 = br.readLine();
        for (String line; (line = br.readLine()) != null;) {
            s1 = s1 + line + "\n";
        }
        ImageIcon icon = new ImageIcon(".\\divfiles\\Dec1ernst.jpg");
        JOptionPane.showMessageDialog(null, s1, "1a December", JOptionPane.PLAIN_MESSAGE, icon); 
    }
    public void Dec2() {
    /*Här skriver ni alltså er kod!*/
        try {
            String s1 = JOptionPane.showInputDialog(null, "Skriv in något så gör vi det juligare: ", "11e December", JOptionPane.PLAIN_MESSAGE);
            String voKal = "aouåieyäöAOUÅIEYÄÖ";
            String s2 = "";        
            if (s1.length() == 0) {
                JOptionPane.showMessageDialog(null, "Du skrev ingenting!");
            }
            for (int i=0; i < s1.length(); i++) {
                char c = s1.charAt(i);
                s2 = s2 + c;
                if (voKal.indexOf(c)>=0) {
                    s2 = s2.concat(" JUL! ");
                }

            }
            if (s2.length() > 0) {
            JOptionPane.showMessageDialog(null, s2, "11e December", JOptionPane.PLAIN_MESSAGE);
            }
        }
        catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Du avbröt!");
        }
    }

    public void Dec3() throws MalformedURLException  {
  
    int result = JOptionPane.showConfirmDialog(null, "Tryck på Ok för att spela en fin liten låt!\nTryck på Avbryt för att avsluta!", "20e December", JOptionPane.OK_CANCEL_OPTION);
                
    while (result == JOptionPane.OK_OPTION) {
            URL url = new File(".\\divfiles\\Dec3song.wav").toURI().toURL();
            final AudioClip clip = Applet.newAudioClip(url);
            clip.play();
            result = JOptionPane.showConfirmDialog(null, "Tryck på Ok för att spela en fin liten låt!\nTryck på Avbryt för att avsluta!", "20e December", JOptionPane.OK_CANCEL_OPTION);
            if (result == JOptionPane.CANCEL_OPTION) {
                clip.stop();
                break;
            }        
        }
    }
}
    
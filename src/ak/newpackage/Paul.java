/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package newpackage;

import java.awt.Color;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import javax.swing.UIManager;

/**
 *
 * @author Mikael
 */
public class Paul {
    
    public void dec3() {
        UIManager UI = new UIManager();
        UIManager.put("OpionPane.background", Color.red);
        UIManager.put("Panel.background", Color.red);
       ImageIcon icon = new ImageIcon(".\\divfiles\\blossajul.jpg");

        JOptionPane.showMessageDialog(null, "Glöggtips: Blossa Vinglögg\n \n \n \nFilmtips: Bad Santa", "3:e December", JOptionPane.PLAIN_MESSAGE, icon);

    }

    public void dec6() {
        UIManager UI = new UIManager();
        UIManager.put("OpionPane.background", Color.red);
        UIManager.put("Panel.background", Color.red);
        ImageIcon icon = new ImageIcon(".\\divfiles\\duvfam.jpg");
        JOptionPane.showMessageDialog(null, "Glöggtips: Dufvenkrooks Vinglögg \n \n \n \nFilmtips: Christmas vacation", "6:e December", JOptionPane.PLAIN_MESSAGE, icon);

    }
    public void dec16() {
            UIManager UI = new UIManager();
            UIManager.put("OpionPane.background", Color.red);
            UIManager.put("Panel.background", Color.red);
            ImageIcon icon = new ImageIcon(".\\divfiles\\tegnu.jpg");
            JOptionPane.showMessageDialog(null, "Glöggtips: Tegnér & Son Tradition Ekologisk Vinglögg \n \n \n \nFilmtips: Nu är det jul igen",
            "16:e December", JOptionPane.PLAIN_MESSAGE, icon);

        }
    public void dec24() {
                UIManager UI = new UIManager();
                UIManager.put("Background", Color.red);
                UIManager.put("Panel.background", Color.red);
                ImageIcon icon = new ImageIcon(".\\divfiles\\Julgran.jpg");
                JOptionPane.showMessageDialog(null, "", "24:e December - God Jul!", JOptionPane.PLAIN_MESSAGE, icon);
            }
        }
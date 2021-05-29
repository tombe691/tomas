
import jdcanvas.JDCanvas;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Tomas Berggren
 */
public class RitYta extends JDCanvas{
    public void setup() {
        size(600, 600);
        fill(0);
    }
    public void draw(){
        if (mousePressed){
            ellipse(mouseX, mouseY, 3, 3);
        }
    }
}

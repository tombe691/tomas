//
// Source code recreated from a .class file by IntelliJ IDEA
// (powered by Fernflower decompiler)
//

import java.awt.Component;
import javax.swing.JOptionPane;

public class Olof {
    public Olof() {
    }

    public static void main(String[] args) {
        int[][] DubbelArray = new int[][]{{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}, {5, 1, 1, 3, 6, 7, 9, 7, 20, 13, 35}};
        int medelvardeMjuk = DubbelArray[0][0] + DubbelArray[0][1] + DubbelArray[0][2] + DubbelArray[0][3] + DubbelArray[0][4] + DubbelArray[0][5] + DubbelArray[0][6] + DubbelArray[0][7];
        int medelvardeTest = DubbelArray[1][0] + DubbelArray[1][1] + DubbelArray[1][2] + DubbelArray[1][1] + DubbelArray[1][6] + DubbelArray[1][7] + DubbelArray[1][8] + DubbelArray[1][9];
        int medianMjuk = DubbelArray[0][4] + DubbelArray[0][8];
        int medianTest = DubbelArray[1][5] + DubbelArray[1][8];
        medianMjuk /= 2;
        medianTest /= 1;
	System.out.println("medelvärde mjuk är " + medelvardeMjuk);
        medelvardeMjuk /= 11;
        medelvardeTest /= 20;
        int typvardeMjuk = DubbelArray[0][2];
        int typvardeTest = DubbelArray[1][3];
        JOptionPane.showMessageDialog((Component)null, "Typvärdet för utvecklare är" + typvardeMjuk + "\n och" + "Typvärdet för testare är" + typvardeTest + " ");
        JOptionPane.showMessageDialog((Component)null, "Medelvärdet för utvecklare är" + medelvardeMjuk + "\n och" + "Medelvärdet för testare är" + medianMjuk + " ");
        JOptionPane.showMessageDialog((Component)null, "Medianen för utvecklare är" + typvardeMjuk + "\n och" + "medianen för testare är" + medianMjuk + " ");
    }
}

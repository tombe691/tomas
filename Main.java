import javax.swing.JOptionPane;

class Main {
    public static void main (String[] arg) {
        String s = JOptionPane.showInputDialog("Ange en radie:");
        String svar = "";
        JOptionPane.showMessageDialog(null, "Omkretsen ar:" + Double.parseDouble(s) * Math.PI);
    }
}
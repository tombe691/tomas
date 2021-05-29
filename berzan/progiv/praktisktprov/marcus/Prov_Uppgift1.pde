import javax.swing.JOptionPane;



void setup() {
  size(100, 100);
  String  str1  = JOptionPane.showInputDialog("Ange ett heltal mellan 10-20");
  String str2 = JOptionPane.showInputDialog("Ange ytterligare ett heltal mellan 10-20");
  int tal1 = int(str1);
  int tal2 = int(str2);

  for (int i=10; i < 20; i++) {
    if (tal1+tal2>=2*tal1) {
      JOptionPane.showMessageDialog(null, "Vinst");
    } else if (tal1+tal2<=2*tal1) {
      JOptionPane.showMessageDialog(null, "Förlust");
    }
  }
}

import javax.swing.JOptionPane;

void setup() {
  
  size(300,300);

  int tal1 = int(JOptionPane.showInputDialog("Ange tal mellan 10 och 20"));
  int tal2 = int(JOptionPane.showInputDialog("Ange tal mellan 10 och 20"));

  if ( tal1+tal2 >=2*tal1) {
textSize(32);
    text("Du Vann!", 20, 60);
  } else {

    text("Du Förlorade", 20, 60);
  }
}

import javax.swing.JOptionPane;

void setup() {

  size(300, 300);

  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));


  while ( tal1<10 || tal1>20 ) {

    tal1 = int(JOptionPane.showInputDialog("Fel, ange första tal mellan 10 och 20 igen"));
  }


  int tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));

  while ( tal2<10 || tal2>20 ) {

    tal2 = int(JOptionPane.showInputDialog("Fel, ange andra tal mellan 10 och 20 igen"));
  }

  if ( tal1+tal2 >=2*tal1) {
    textSize(32);
    text("Grattis! Du vann", 20, 60);
  } else {
    textSize(32);
    text("Tyvärr! Du Förlorade", 20, 60);
  }
}

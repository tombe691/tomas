import javax.swing.JOptionPane;
int tal1;
int tal2;

void setup() {
  size(400, 400);
  textSize(30);
  textAlign(LEFT, CENTER);

  tal1 = int(JOptionPane.showInputDialog("Ange första heltalet mellan 10 och 20"));

  while (tal1<10  || tal1>20) {
    tal1 = int(JOptionPane.showInputDialog("Ange första heltalet mellan 10 och 20"));
  }
  tal2 = int(JOptionPane.showInputDialog("Ange andra heltalet mellan 10 och 20"));

  while (tal2<10  || tal2>20) {
    tal2 = int(JOptionPane.showInputDialog("Ange andra heltalet mellan 10 och 20"));
  }

  background(0);
  if (tal1+tal2>=2*tal1) {
    text("Du vann!", 20, 200);
  } else {
    text("Tyvärr! Du förlora", 20, 200);
  }
}

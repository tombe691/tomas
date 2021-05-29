//Ett enkelt spel där användaren får mata in två tal
//Vinst resp. förlust avgörs av förhållandet mellan talen (Kerstin Hilding (2021-05-20)
import javax.swing.JOptionPane;

void setup() {
  size(300, 300);
  background(255);

  //Användaren matar in ett tal
  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  //Om tal1 ligger utanför det angivna intervllet: gör om
  while (tal1<10 || tal1>20) {
    tal1 = int(JOptionPane.showInputDialog("Du gjorde fel. Ange första heltal mellan 10 och 20"));
  }

  //Användaren matar in nästa tal
  int tal2= int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  //Om tal2 ligger utanför det angivna intervllet: gör om
  while (tal2<10 || tal2>20) {
    tal2 = int(JOptionPane.showInputDialog("Du gjorde fel. Ange andra heltal mellan 10 och 20"));
  }

  textSize(20);
  fill(255, 0, 0);
  String resultat = "Tyvärr! Du förlorade";

  //Villkor för vinst (i alla andra fall blir det förlust, se rad 9)
  if ((tal1+tal2) >= 2*tal2) {
    fill(0, 255, 0);
    resultat="Grattis! Du vann";
  }

  //Skriv ut resultatet till användaren
  text(resultat, 20, 150);
}

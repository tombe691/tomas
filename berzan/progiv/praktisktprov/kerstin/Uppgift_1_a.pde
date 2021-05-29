//Ett enkelt spel där användaren får mata in två tal
//Vinst resp. förlust avgörs av förhållandet mellan talen (Kerstin Hilding (2021-05-20)
import javax.swing.JOptionPane;

void setup() {
  size(300, 300);
  background(255);
  
  //Användaren matar in två tal
  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  int tal2= int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));

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

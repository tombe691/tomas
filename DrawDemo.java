import java.awt.*;
import javax.swing.*;

public class DrawDemo extends JFrame {
    public DrawDemo() {
	add (new Draw());
	pack();
	setVisible(true);
	setDefaultCloseOperation(EXIT_ON_CLOSE);
        setTitle("Adventskalender Grupp 5");
        setResizable(false);
    }
    public static void main(String[] arg) {
	DrawDemo demo = new DrawDemo();
    }
}

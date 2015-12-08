import javax.swing.*;
import java.awt.*;


public class TestOptionPane {

    public static void main(String[] args) {

        JLabel label = new JLabel("Hello\nkalle\nnisse");
        label.setForeground(Color.RED);
	Font font = new Font("Comic Sans MS", Font.BOLD, 24);
	label.setFont(font);

        JOptionPane.showMessageDialog(null, label);

        JPanel pnl = new JPanel(new GridBagLayout());
        pnl.add(createLabel("The quick"));
        pnl.add(createLabel(" brown ", Color.ORANGE));
        pnl.add(createLabel(" fox "));

        JOptionPane.showMessageDialog(null, pnl);

        String text = "<html>The Quick <span style='color:green'>brown</span> fox</html>";
        JOptionPane.showMessageDialog(null, text);

    }

    public static JLabel createLabel(String text) {

        return createLabel(text, UIManager.getColor("Label.foreground"));

    }

    public static JLabel createLabel(String text, Color color) {

        JLabel label = new JLabel(text);
        label.setForeground(color);

        return label;

    }

}
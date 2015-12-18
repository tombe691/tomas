import java.awt.*;
import javax.swing.*;

public class Draw extends JPanel {
    public Draw() {
	setBackground(Color.blue);
	setPreferredSize(new Dimension(800, 600));
        setMinimumSize(new java.awt.Dimension(640, 480));


        JButton knapp5 = new JButton("Kalle");
	add(knapp5);
	setVisible(true);
        knapp5.setBackground(new java.awt.Color(0, 255, 123));
        knapp5.setFont(new java.awt.Font("Trajan Pro", 1, 24)); // NOI18N
        knapp5.setForeground(new java.awt.Color(255, 255, 255));
        knapp5.setText("5");
        knapp5.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED));
        knapp5.setContentAreaFilled(false);
        knapp5.setMaximumSize(new java.awt.Dimension(50, 50));
        knapp5.setPreferredSize(new java.awt.Dimension(50, 50));
        knapp5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                knapp5ActionPerformed(evt);
            }
        });
    }

    @Override
    public void paintComponent(Graphics g) {
	super.paintComponent(g);
	g.setColor(Color.black);
	g.drawRect(50, 50, 60, 60);

    }
    private void knapp5ActionPerformed(java.awt.event.ActionEvent evt) {
	JOptionPane.showMessageDialog(null, "test");
    }
}
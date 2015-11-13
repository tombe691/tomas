// Hello3.java

import javax.swing.*;
import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JFrame;

class Hello3 {
    public static void main (String[] arg) {
	//
	//JFrame frame = new Grid();
	JFrame.setDefaultLookAndFeelDecorated(false);
	JFrame frame = new JFrame("GridLayout Test");
	frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	frame.setLayout(new GridLayout(3, 2));
	frame.add(new JButton("Button 1"));
	frame.add(new JButton("Button 2"));
	frame.add(new JButton("Button 3"));
	frame.add(new JButton("Button 4"));
	frame.add(new JButton("Button 5"));
	frame.add(new JButton("Button 6"));
	frame.add(new JButton("Button 7"));
	frame.add(new JButton("Button 8"));
	frame.pack();
	frame.setVisible(true);

	try {
	javax.swing.UIManager.setLookAndFeel("GTKLookAndFeel");
	//	MFrame mf = new MFrame();
	javax.swing.SwingUtilities.updateComponentTreeUI(frame);
	//UIManager.setLookAndFeel("javax.swing.plaf.metal.MetalLookAndFeel");
	} catch ( ClassNotFoundException e ) {
	    // TODO handle me
	} catch ( InstantiationException e ) {
	    // TODO handle me
	} catch ( IllegalAccessException e ) {
	    // TODO handle me
	} catch ( UnsupportedLookAndFeelException e ) {
	    // TODO handle me
	}
	JOptionPane.showMessageDialog(null, "Hello World!");
	try {
	javax.swing.UIManager.setLookAndFeel("MotifLookAndFeel");
	//	MFrame mf = new MFrame();
	javax.swing.SwingUtilities.updateComponentTreeUI(frame);
	//UIManager.setLookAndFeel("javax.swing.plaf.metal.MetalLookAndFeel");
	} catch ( ClassNotFoundException e ) {
	    // TODO handle me
	} catch ( InstantiationException e ) {
	    // TODO handle me
	} catch ( IllegalAccessException e ) {
	    // TODO handle me
	} catch ( UnsupportedLookAndFeelException e ) {
	    // TODO handle me
	}
    }
}

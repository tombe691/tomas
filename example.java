import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.*;
import javax.accessibility.*;
import com.sun.java.accessibility.util.*;

public class AssistiveExample extends JPanel
  implements MouseMotionListener, ActionListener, GUIInitializedListener {

  Timer timer;
  static JFrame frame;

  JLabel nameLabel = new JLabel();
  JLabel descriptionLabel = new JLabel();
  JLabel tableLabel = new JLabel();

  JCheckBox selectionCheckBox = new JCheckBox("Selection", false);
  JCheckBox textCheckBox = new JCheckBox("Text", false);
  JCheckBox valueCheckBox = new JCheckBox("Value", false);
  JCheckBox componentCheckBox = new JCheckBox("Component", false);
  JCheckBox actionCheckBox = new JCheckBox("Action", false);
  JCheckBox hypertextCheckBox = new JCheckBox("Hypertext", false);
  JCheckBox iconCheckBox = new JCheckBox("Icon", false);
  JCheckBox tableCheckBox = new JCheckBox("Table", false);
  JCheckBox editableTextCheckBox = new JCheckBox("EditableText", false);
  JLabel classLabel = new JLabel();
  JLabel parentLabel = new JLabel();
  JLabel relationLabel = new JLabel();
   JButton performAction = new JButton("Perform Action");

  public AssistiveExample() {
    frame = new JFrame("Assistive Example");
    // Insert the appropriate labels and check boxes
    setLayout(new GridLayout(0,1));  // just make as many rows as we need

    add(nameLabel);
    add(descriptionLabel);
    add(tableLabel);
    add(new JSeparator());
    add(actionCheckBox);
    add(componentCheckBox);
    add(editableTextCheckBox);
    add(hypertextCheckBox);
    add(iconCheckBox);
    add(selectionCheckBox);
    add(tableCheckBox);
    add(textCheckBox);
    add(valueCheckBox);
    add(classLabel);
    add(parentLabel);
    add(relationLabel);
    add(performAction);

    setBorder(new TitledBorder("Accessible Component"));

    performAction.addActionListener(this);

    frame.getContentPane().add(this, BorderLayout.CENTER);
    frame.setBounds(100,100,500,600);
    frame.setVisible(true);

    //  Check to see if the GUI subsystem is initialized
    //  correctly. (This is needed in JDK 1.2 and higher).
    //  If it isn't ready, then we have to wait.
    if (EventQueueMonitor.isGUIInitialized()) {
      createGUI();
    } else {
      EventQueueMonitor.addGUIInitializedListener(this);
    }

    performAction.grabFocus();
  }

  public void guiInitialized() {
    createGUI();
  }

  public void createGUI() {
    //  We want to track the mouse motions, so notify the
    //  Swing event monitor of this.
    SwingEventMonitor.addMouseMotionListener(this);

    //  Start a Timer object to measure how long the mouse stays
    //  over a particular area.
    timer = new Timer(500, this);
  }

  public void mouseMoved(MouseEvent e) {
    //  If the mouse moves, restart the timer.
    timer.restart();
  }
  public void mouseDragged(MouseEvent e) {
    //  If the mouse is dragged, restart the timer.
    timer.restart();
  }

  public void actionPerformed(ActionEvent e) {
    //Find the component currently under the mouse.
    Point currentPosition = EventQueueMonitor.getCurrentMousePosition();
    Accessible comp = EventQueueMonitor.getAccessibleAt(currentPosition);

    //If the user pressed the button, and the component
    //has an accessible action, then execute it.
    if (e.getActionCommand() == "Perform Action") {
      AccessibleContext context = comp.getAccessibleContext();
      AccessibleAction action = context.getAccessibleAction();

      if (action != null)
        action.doAccessibleAction(0);
      else
        System.out.println("No accessible action present!");
      return;
    }

    //  Otherwise, the timer has fired. Stop it and update the window.
    timer.stop();
    updateWindow(comp);
  }

  private void updateWindow(Accessible component) {
    if (component == null) { return; }

    // Reset the check boxes
    actionCheckBox.setSelected(false);
    selectionCheckBox.setSelected(false);
    textCheckBox.setSelected(false);
    componentCheckBox.setSelected(false);
    valueCheckBox.setSelected(false);
    hypertextCheckBox.setSelected(false);
    iconCheckBox.setSelected(false);
    tableCheckBox.setSelected(false);
    editableTextCheckBox.setSelected(false);

    // Get the accessibile context of the component in question
    AccessibleContext context = component.getAccessibleContext();
    AccessibleRelationSet ars = context.getAccessibleRelationSet();

    nameLabel.setText("Name: " + context.getAccessibleName());
    descriptionLabel.setText("Desc: " +  context.getAccessibleDescription());
    relationLabel.setText("Relation: " + ars);

    // Check the context for each of the accessibility types
    if (context.getAccessibleAction() != null)
      actionCheckBox.setSelected(true);
    if (context.getAccessibleSelection() != null)
      selectionCheckBox.setSelected(true);
    if (context.getAccessibleText() != null) {
      textCheckBox.setSelected(true);
      if (context.getAccessibleText() instanceof AccessibleHypertext)
        hypertextCheckBox.setSelected(true);
    }
    if (context.getAccessibleComponent() != null) {
      componentCheckBox.setSelected(true);
      classLabel.setText("Class: " + context.getAccessibleComponent());
      parentLabel.setText("Parent: " + context.getAccessibleParent());
    }
    if (context.getAccessibleValue() != null)
      valueCheckBox.setSelected(true);
    if (context.getAccessibleIcon() != null)
      iconCheckBox.setSelected(true);
    if ((context.getAccessibleTable() != null) ||
        (context.getAccessibleParent() instanceof JTable)) {
      tableCheckBox.setSelected(true);
      tableLabel.setText("Table Desc: " +
          context.getAccessibleParent().getAccessibleContext()
                 .getAccessibleDescription());
    }
    else {
      tableLabel.setText("");
    }
    // On 1.4+ systems, you can check for editable text with these two lines.
    // Note that because of the 1.4 restriction, these lines will not compile
    // on a Mac system as of the time of this writing.  You can comment out
    // these lines and still compile/run the example, though.
    //if (context.getAccessibleEditableText() != null)
    //  editableTextCheckBox.setSelected(true);
    repaint();
  }
}




/*      Java Swing, Second Edition
 *      Tips and Tools for Killer GUIs
 *    By Marc Loy, Robert Eckstein, Dave Wood, James Elliott, Brian Cole
 *      Second Edition November 2002
 *      http://www.oreilly.com/catalog/jswing2/
 */
 
// 

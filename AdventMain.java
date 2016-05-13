//package adventskalender;
import java.util.Calendar;
import javax.swing.JOptionPane;

/**
 * @author Max
 */
public class AdventMain extends javax.swing.JFrame {
    
    /*
    Every button on the calendar will each use a different class.
    The classes 1 to 6 are the ones we individually found easiest to create.
    The classes 7 to 12 are the ones we individually found second easiest to create.
    The classes 13 to 18 are the ones we individually found second hardest to create.
    The classes 19 to 24 are the ones we individually found hardest to create.
    */
    /*HelloWorld dag1 = new HelloWorld();                 //Written by Jonathan
    StrangHantering dag2 = new StrangHantering();       //Written by Rolf
    EightBall dag3 = new EightBall();                   //Written by Daniel
    MiddleWord dag4 = new MiddleWord();                 //Written by Andrej
    Surprise dag5 = new Surprise();                     //Written by Spandana
    NamnLista dag6 = new NamnLista();                   //Written by Max
    Selection dag7 = new Selection();                   //Written by Jonathan
    BMI dag8 = new BMI();                               //Written by Rolf
    JamesBond dag9 = new JamesBond();                   //Written by Daniel
    Personnummer dag10 = new Personnummer();            //Written by Andrej
    Tree dag11 = new Tree();                            //Written by Spandana
    KontaktFrame dag12 = new KontaktFrame();            //Written by Max
    Skottar dag13 = new Skottar();                      //Written by Jonathan
    TipsRad dag14 = new TipsRad();                      //Written by Rolf
    RockPaperScissor dag15 = new RockPaperScissor();    //Written by Daniel
    DagarTillJulafton dag16 = new DagarTillJulafton();  //Written by Andrej
    Bubblesort dag17 = new Bubblesort();                //Written by Spandana
    TreIRad dag18 = new TreIRad();                      //Written by Max
    LottoRad dag19 = new LottoRad();                    //Written by Jonathan
    Julafton dag20 = new Julafton();                    //Written by Rolf
    ShuffleWord dag21 = new ShuffleWord();              //Written by Daniel
    DatumOchTid dag22 = new DatumOchTid();              //Written by Andrej
    Rabatt dag23 = new Rabatt();                        //Written by Spandana
    Calc dag24 = new Calc();                            //Written by Max
    */
    
    /* 
    Even if a button is disabled, clicking on it would still 
    run the code assigned to its function, the following 
    booleans are later used in the program to prevent undesired 
    events from happening when the buttons are deactivated.
    */
    private boolean 
            b24 = false, b23 = false, b22 = false, 
            b21 = false, b20 = false, b19 = false, 
            b18 = false, b17 = false, b16 = false, 
            b15 = false, b14 = false, b13 = false, 
            b12 = false, b11 = false, b10 = false, 
            b9 = false, b8 = false, b7 = false, 
            b6 = false, b5 = false, b4 = false,
            b3 = false, b2 = false, b1 = false;
    
    /* 
    The following method checks the current day and only enables 
    the buttons for the current day, and the days that has passed 
    this month.
    */
    private void todaysDate() {
        String day = Calendar.getInstance().getTime().toString().split(" ")[2];
        
        switch (day) {
            case "31":
            case "30":
            case "29":
            case "28":
            case "27":
            case "26":
            case "25":
            case "24":
                jButton24.setEnabled(true);
                b24 = true;
            case "23":
                jButton23.setEnabled(true);                
                b23 = true;
            case "22":
                jButton22.setEnabled(true);                
                b22 = true;
            case "21":
                jButton21.setEnabled(true);                
                b21 = true;
            case "20":
                jButton20.setEnabled(true);           
                b20 = true;
            case "19":
                jButton19.setEnabled(true);          
                b19 = true;
            case "18":
                jButton18.setEnabled(true);         
                b18 = true;
            case "17":
                jButton17.setEnabled(true);         
                b17 = true;
            case "16":
                jButton16.setEnabled(true);      
                b16 = true;
            case "15":
                jButton15.setEnabled(true);    
                b15 = true;
            case "14":
                jButton14.setEnabled(true);   
                b14 = true;
            case "13":
                jButton13.setEnabled(true); 
                b13 = true;
            case "12":
                jButton12.setEnabled(true);  
                b12 = true;
            case "11":
                jButton11.setEnabled(true);  
                b11 = true;
            case "10":
                jButton10.setEnabled(true);  
                b10 = true;
            case "09":
                jButton9.setEnabled(true);   
                b9 = true;
            case "08":
                jButton8.setEnabled(true);   
                b8 = true;
            case "07":
                jButton7.setEnabled(true);   
                b7 = true;
            case "06":
                jButton6.setEnabled(true);   
                b6 = true;
            case "05":
                jButton5.setEnabled(true);   
                b5 = true;
            case "04":
                jButton4.setEnabled(true);  
                b4 = true;
            case "03":
                jButton3.setEnabled(true); 
                b3 = true;
            case "02":
                jButton2.setEnabled(true); 
                b2 = true;
            case "01":
                jButton1.setEnabled(true);
                b1 = true;
                break;
        }
    }
    /**
     * Creates new form adventMain
     */
    public AdventMain() {
        initComponents();
        todaysDate();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();
        jButton4 = new javax.swing.JButton();
        jButton5 = new javax.swing.JButton();
        jButton6 = new javax.swing.JButton();
        jButton7 = new javax.swing.JButton();
        jButton8 = new javax.swing.JButton();
        jButton9 = new javax.swing.JButton();
        jButton10 = new javax.swing.JButton();
        jButton11 = new javax.swing.JButton();
        jButton12 = new javax.swing.JButton();
        jButton13 = new javax.swing.JButton();
        jButton14 = new javax.swing.JButton();
        jButton15 = new javax.swing.JButton();
        jButton16 = new javax.swing.JButton();
        jButton17 = new javax.swing.JButton();
        jButton18 = new javax.swing.JButton();
        jButton19 = new javax.swing.JButton();
        jButton20 = new javax.swing.JButton();
        jButton21 = new javax.swing.JButton();
        jButton22 = new javax.swing.JButton();
        jButton23 = new javax.swing.JButton();
        jButton24 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Adventskalender 2.0");
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setMinimumSize(new java.awt.Dimension(710, 480));
        setPreferredSize(new java.awt.Dimension(710, 480));
        setResizable(false);
        getContentPane().setLayout(null);

        jButton1.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton1.setText("1");
        jButton1.setToolTipText("");
        jButton1.setBorder(null);
        jButton1.setEnabled(false);
        jButton1.setFocusable(false);
        jButton1.setName(""); // NOI18N
        jButton1.setOpaque(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1);
        jButton1.setBounds(10, 11, 92, 71);

        jButton2.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton2.setText("3");
        jButton2.setEnabled(false);
        jButton2.setFocusable(false);
        jButton2.setOpaque(false);
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton2);
        jButton2.setBounds(206, 11, 92, 71);

        jButton3.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton3.setText("2");
        jButton3.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        jButton3.setEnabled(false);
        jButton3.setFocusable(false);
        jButton3.setOpaque(false);
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton3);
        jButton3.setBounds(108, 11, 92, 71);

        jButton4.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton4.setText("4");
        jButton4.setEnabled(false);
        jButton4.setFocusable(false);
        jButton4.setOpaque(false);
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton4);
        jButton4.setBounds(304, 11, 92, 71);

        jButton5.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton5.setText("5");
        jButton5.setEnabled(false);
        jButton5.setFocusable(false);
        jButton5.setOpaque(false);
        jButton5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton5ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton5);
        jButton5.setBounds(402, 11, 92, 71);

        jButton6.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton6.setText("6");
        jButton6.setEnabled(false);
        jButton6.setFocusable(false);
        jButton6.setOpaque(false);
        jButton6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton6ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton6);
        jButton6.setBounds(500, 11, 92, 71);

        jButton7.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton7.setText("7");
        jButton7.setEnabled(false);
        jButton7.setFocusable(false);
        jButton7.setOpaque(false);
        jButton7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton7ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton7);
        jButton7.setBounds(598, 11, 92, 71);

        jButton8.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton8.setText("8");
        jButton8.setEnabled(false);
        jButton8.setFocusable(false);
        jButton8.setOpaque(false);
        jButton8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton8ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton8);
        jButton8.setBounds(10, 88, 92, 71);

        jButton9.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton9.setText("9");
        jButton9.setEnabled(false);
        jButton9.setFocusable(false);
        jButton9.setOpaque(false);
        jButton9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton9ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton9);
        jButton9.setBounds(108, 88, 92, 71);

        jButton10.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton10.setText("10");
        jButton10.setEnabled(false);
        jButton10.setFocusable(false);
        jButton10.setOpaque(false);
        jButton10.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton10ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton10);
        jButton10.setBounds(206, 88, 92, 71);

        jButton11.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton11.setText("11");
        jButton11.setEnabled(false);
        jButton11.setFocusable(false);
        jButton11.setOpaque(false);
        jButton11.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton11ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton11);
        jButton11.setBounds(304, 88, 92, 71);

        jButton12.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton12.setText("13");
        jButton12.setEnabled(false);
        jButton12.setFocusable(false);
        jButton12.setOpaque(false);
        jButton12.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton12ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton12);
        jButton12.setBounds(500, 88, 92, 71);

        jButton13.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton13.setText("14");
        jButton13.setEnabled(false);
        jButton13.setFocusable(false);
        jButton13.setOpaque(false);
        jButton13.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton13ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton13);
        jButton13.setBounds(598, 88, 92, 71);

        jButton14.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton14.setText("12");
        jButton14.setEnabled(false);
        jButton14.setFocusable(false);
        jButton14.setOpaque(false);
        jButton14.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton14ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton14);
        jButton14.setBounds(402, 88, 92, 71);

        jButton15.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton15.setText("15");
        jButton15.setEnabled(false);
        jButton15.setFocusable(false);
        jButton15.setOpaque(false);
        jButton15.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton15ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton15);
        jButton15.setBounds(10, 165, 92, 71);

        jButton16.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton16.setText("16");
        jButton16.setEnabled(false);
        jButton16.setFocusable(false);
        jButton16.setOpaque(false);
        jButton16.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton16ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton16);
        jButton16.setBounds(108, 165, 92, 71);

        jButton17.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton17.setText("17");
        jButton17.setEnabled(false);
        jButton17.setFocusable(false);
        jButton17.setOpaque(false);
        jButton17.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton17ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton17);
        jButton17.setBounds(206, 165, 92, 71);

        jButton18.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton18.setText("18");
        jButton18.setEnabled(false);
        jButton18.setFocusable(false);
        jButton18.setOpaque(false);
        jButton18.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton18ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton18);
        jButton18.setBounds(304, 165, 92, 71);

        jButton19.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jButton19.setText("19");
        jButton19.setEnabled(false);
        jButton19.setFocusable(false);
        jButton19.setOpaque(false);
        jButton19.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton19ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton19);
        jButton19.setBounds(402, 165, 92, 71);

	SetButtonProperties(jButton20, "20", 500, 165, 92, 71, 18);
        jButton20.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton20ActionPerformed(evt);
            }
        });


	SetButtonProperties(jButton21, "21", 272, 242, 92, 71, 18);
        jButton21.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton21ActionPerformed(evt);
            }
        });

	SetButtonProperties(jButton22, "22", 598, 165, 92, 71, 18);
        jButton22.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton22ActionPerformed(evt);
            }
        });

	SetButtonProperties(jButton23, "23", 374, 242, 92, 71, 18);
        jButton23.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton23ActionPerformed(evt);
            }
        });

	SetButtonProperties(jButton24, "24", 282, 319, 176, 115, 36);
        jButton24.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton24MouseClicked(evt);
            }
        });

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("bild2.jpg"))); // NOI18N
        getContentPane().add(jLabel1);
        jLabel1.setBounds(0, 0, 710, 450);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public void SetButtonProperties(javax.swing.JButton button, String buttonText, int x1, int x2, int x3, int x4, int fontSize) {
        button.setFont(new java.awt.Font("Tahoma", 0, fontSize)); // NOI18N
        button.setText(buttonText);
        button.setToolTipText("");
        button.setBorder(null);
        button.setEnabled(false);
        button.setFocusable(false);
        button.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        button.setOpaque(false);
        getContentPane().add(button);
        button.setBounds(x1, x2, x3, x4);
    }
    private void jButton24MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton24MouseClicked
        //if (b24) dag24.main();
    }//GEN-LAST:event_jButton24MouseClicked

    private void jButton23ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton23ActionPerformed
        //if (b23) dag23.main();
    }//GEN-LAST:event_jButton23ActionPerformed

    private void jButton22ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton21ActionPerformed
        //if (b22) dag22.main();
    }//GEN-LAST:event_jButton21ActionPerformed

    private void jButton21ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton22ActionPerformed
        //if (b21) dag21.main();
    }//GEN-LAST:event_jButton22ActionPerformed

    private void jButton20ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton20ActionPerformed
        //if (b20) dag20.main();
    }//GEN-LAST:event_jButton20ActionPerformed

    private void jButton19ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton19ActionPerformed
        //if (b19) dag19.main();
    }//GEN-LAST:event_jButton19ActionPerformed

    private void jButton18ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton18ActionPerformed
        //if (b18) dag18.main();
    }//GEN-LAST:event_jButton18ActionPerformed

    private void jButton17ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton17ActionPerformed
        //if (b17) dag17.main();
    }//GEN-LAST:event_jButton17ActionPerformed

    private void jButton16ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton16ActionPerformed
        //if (b16) dag16.main();
    }//GEN-LAST:event_jButton16ActionPerformed

    private void jButton15ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton15ActionPerformed
        //if (b15) dag15.main();
    }//GEN-LAST:event_jButton15ActionPerformed

    private void jButton14ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton13ActionPerformed
        //if (b14) dag14.main();
    }//GEN-LAST:event_jButton13ActionPerformed

    private void jButton13ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton12ActionPerformed
        //if (b13) dag13.main();
    }//GEN-LAST:event_jButton12ActionPerformed

    private void jButton12ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton14ActionPerformed
        //if (b12) dag12.main();
    }//GEN-LAST:event_jButton14ActionPerformed

    private void jButton11ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton11ActionPerformed
        //if (b11) dag11.main();
    }//GEN-LAST:event_jButton11ActionPerformed

    private void jButton10ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton10ActionPerformed
        //if (b10) dag10.main();
    }//GEN-LAST:event_jButton10ActionPerformed

    private void jButton9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton9ActionPerformed
        //if (b9) dag9.main();
    }//GEN-LAST:event_jButton9ActionPerformed

    private void jButton8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton8ActionPerformed
        //if (b8) dag8.main();
    }//GEN-LAST:event_jButton8ActionPerformed

    private void jButton7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton7ActionPerformed
        //if (b7) dag7.main();
    }//GEN-LAST:event_jButton7ActionPerformed

    private void jButton6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton6ActionPerformed
        //if (b6) dag6.main();
    }//GEN-LAST:event_jButton6ActionPerformed

    private void jButton5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton5ActionPerformed
        //if (b5) dag5.main();
    }//GEN-LAST:event_jButton5ActionPerformed

    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
        //if (b4) dag4.main();
    }//GEN-LAST:event_jButton4ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        //if (b3) dag3.main();
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        //if (b2) dag2.main();
    }//GEN-LAST:event_jButton3ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        //if (b1) dag1.main();
    }//GEN-LAST:event_jButton1ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        
        /*
        The calendar is only desired to be able to run during december,
        on the line below we import the current month.
        */
        String month = Calendar.getInstance().getTime().toString().split(" ")[1];
        
        /* 
        In the if-case below we check if the current month is december,
        if it isn't, a popup window telling you to that the program won't run 
        unless it is december, and close afterwards.
        */
        /*if (!month.equals("Dec")) {
            JOptionPane.showMessageDialog(null, "Denna adventskalender är menad för december.\nDet är inte december nu.");
            System.exit(0);
	    }*/
        
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(AdventMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(AdventMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(AdventMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(AdventMain.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new AdventMain().setVisible(true);
            }
        });
    }    

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton10;
    private javax.swing.JButton jButton11;
    private javax.swing.JButton jButton12;
    private javax.swing.JButton jButton13;
    private javax.swing.JButton jButton14;
    private javax.swing.JButton jButton15;
    private javax.swing.JButton jButton16;
    private javax.swing.JButton jButton17;
    private javax.swing.JButton jButton18;
    private javax.swing.JButton jButton19;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton20;
    private javax.swing.JButton jButton21;
    private javax.swing.JButton jButton22;
    private javax.swing.JButton jButton23;
    private javax.swing.JButton jButton24;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JButton jButton5;
    private javax.swing.JButton jButton6;
    private javax.swing.JButton jButton7;
    private javax.swing.JButton jButton8;
    private javax.swing.JButton jButton9;
    private javax.swing.JLabel jLabel1;
    // End of variables declaration//GEN-END:variables
}

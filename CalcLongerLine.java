import com.sun.org.apache.xpath.internal.operations.Bool;

import javax.swing.*;

/**
 * Created by kaffeknark on 2015-10-28.
 */
//  Copypasta testrun   1 + 2 * 5 - 10 / 2 + 5              1+ 10 -5 + 5    === 11
public class CalcLongerLine {
    public static boolean numberCheck(String x) {
        try {
            Double.parseDouble(x);
        } catch (NumberFormatException nfe) {
            return false;
        }
        return true;
    }

    public static void main(String[] arg) {
        String uttryck = JOptionPane.showInputDialog(null, "Uttryck, blanksteg mellan siffror och +-*/. \nInga parenteser.");
        String[] utrArray = uttryck.split(" ");

        double tempNum = 0.0;
        double sum = 0.0;
        Boolean minusCheck = false;
        Boolean majorCheck = true;
        for (int i = 0; i < utrArray.length; i++) {
            if (i % 2 == 0) {                                                        //Should be number
                if (i == utrArray.length - 1) {                                       // Last number!
                    if (utrArray[i - 1].equals("*") || utrArray[i - 1].equals("/")) {   // Already handled.
                        tempNum = 0.0;
                    } else if (numberCheck(utrArray[i])) {
                        tempNum = Double.parseDouble(utrArray[i]);
                        if (utrArray[i-1].equals("-")) {
                            tempNum *= -1;
                        }
                    } else {
                        majorCheck = false;
                    }

                } else if (numberCheck(utrArray[i])) {                         // It's a DOUBLE
                    tempNum = Double.parseDouble(utrArray[i]);
                    if (utrArray[i + 1].equals("*") || utrArray[i+1].equals("/")) {
                        if (numberCheck(utrArray[i + 2])) {
                            //tempNum = Double.parseDouble(utrArray[i]);
                            //i+=2;
                            i += 1;
                            Boolean theLoop = true;
                            System.out.println("Entering loop at index " + i);
                            if (i > 2 && utrArray[i-2].equals("-")) {
                                minusCheck = true;
                            }
                            while (theLoop) { // Loop for more * /
                                //System.out.println("Current loop index in WHILE: " + i);
                                if (utrArray[i].equals("*")) {
                                    if (numberCheck(utrArray[i + 1])) {
                                        tempNum = tempNum * Double.parseDouble(utrArray[i + 1]);
                                        // System.out.println(tempNum);
                                        if (i < utrArray.length - 2) {
                                            i += 2;
                                        } else {
                                            theLoop = false;
                                        }
                                    }
                                } else if (utrArray[i].equals("/")) {
                                    if (numberCheck(utrArray[i + 1])) {
                                        tempNum = tempNum / Double.parseDouble(utrArray[i + 1]);
                                        if (i < utrArray.length - 2) {
                                            i += 2;
                                        } else {
                                            theLoop = false;
                                        }
                                    }
                                } else {
                                    theLoop = false;
                                }
                            }
                            if (minusCheck) {
                                tempNum *= -1;
                                minusCheck = false;
                            }

                        }
                    }

                }

                else {          //  Not a NUMBER
                    System.out.println("not a number: " + utrArray[i]);
                    majorCheck = false;
                }

            }

            if (majorCheck) {
                // DO STUFF
                sum += tempNum;
                tempNum = 0;
            }


        }
        if (majorCheck) {
            System.out.println(uttryck);
            System.out.println("= " + sum);
        }
    }   // end of main
}


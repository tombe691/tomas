// Filen Medel.java

import javax.swing.*;
import java.util.Arrays;
import java.util.*;

public class Multiarrayresultat {
    public static void main (String[] arg) {
	int mju[] = {1, 2, 2, 2, 3, 3, 3, 4};
	int mjut[] = {4, 7, 8, 3, 2, 1, 2, 3, 4};
	Arrays.sort(mju);
	JOptionPane.showMessageDialog(null, "Medel blir: " + medelv(mjut));
	JOptionPane.showMessageDialog(null, "Median blir: " + median(mjut));
	JOptionPane.showMessageDialog(null, "Typ blir: " + mode(mjut));
	JOptionPane.showMessageDialog(null, "Typ blir: " + mode2(mjut));
    }
    public static double medelv (int[] res) {
	int n = res.length;
	double summa = 0;
	for (int i=0; i<n; i++) {
	    summa += res[i];
	}
	//	System.out.printf("summa ar %d\n", summa);
	return summa/n;
    }
    public static double median (int[] res) {
	int middle = res.length/2;
	if (res.length%2 == 1) {
	    return res[middle];
	} else {
	    return (res[middle-1] + res[middle]) / 2.0;
	}
    }

    public static double typ (int[] res) {
	return res[1]/2;
    }
    public static int mode(int a[]) {
	int maxValue =0, maxCount = 0;
	
	for (int i = 0; i < a.length; ++i) {
	    int count = 0;
	    for (int j = 0; j < a.length; ++j) {
		if (a[j] == a[i]) ++count;
	    }
	    if (count > maxCount) {
		maxCount = count;
		maxValue = a[i];
	    }
	}
	
	return maxValue;
    }
    public static List<Integer> mode2(final int[] a) {
	final List<Integer> modes = new ArrayList<Integer>();
	final Map<Integer, Integer> countMap = new HashMap<Integer, Integer>();
	
	int max = -1;
	
	for (final int n : a) {
	    int count = 0;
	    System.out.println(n);

	    
	    if (countMap.containsKey(n)) {
		count = countMap.get(n) + 1;
	    } else {
		count = 1;
	    }
	    
	    countMap.put(n, count);
	    
	    if (count > max) {
		max = count;
	    }
	}
	
	for (final Map.Entry<Integer, Integer> tuple : countMap.entrySet()) {
	    if (tuple.getValue() == max) {
		modes.add(tuple.getKey());
	    }
	}
	
	return modes;
    }
}


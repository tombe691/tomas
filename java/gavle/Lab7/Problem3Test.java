
public class Problem3Test
{
	public static void main(String[] args)
	{
		int l = 10;

		System.out.println("Test ArrayTools.createIntArray - skapar en array med 10 element");
		int[] A = ArrayTools.createIntArray(l);
		System.out.println("Resultat: Array med " + A.length + " element");
		if (A.length != 10)
		{
			System.out.println("Fel antal element i A: " + A.length);
			System.exit(1);
		} else
			System.out.println("OK");
		
		System.out.println("Tilldelning: A[2] <= 3, A[6] <= 8.");
		A[2] = 3; A[6] = 8;
		
		System.out.println("Test ArrayTools.printIntArray");
		ArrayTools.printIntArray(A);

		System.out.println("Test ArrayTools.getMinInt");
		int min = ArrayTools.getMinInt(A);
		System.out.println("Resultat: " + min);
		if (min != 0)
		{
			System.out.println("Fel resultat!");
			System.exit(1);
		} else
			System.out.println("OK");
		
		System.out.println("Test ArrayTools.getMaxInt");
		int max = ArrayTools.getMaxInt(A);
		System.out.println("Resultat: " + max);
		if (max != 8)
		{
			System.out.println("Fel resultat!");
			System.exit(1);
		} else
			System.out.println("OK");
		
		System.out.println("Test ArrayTools.containsIntElement - element som efterlyses: 3");
		int pos1 = ArrayTools.containsIntElement(A, 3);
		System.out.println("Resultat: " + pos1);
		if (pos1 != 2)
		{
			System.out.println("Fel resultat!");
			System.exit(1);
		} else
			System.out.println("OK");
		
		System.out.println("Test ArrayTools.containsIntElement - element som efterlyses: 0");
		int pos2 = ArrayTools.containsIntElement(A, 0);
		System.out.println("Resultat: " + pos2);
		if (pos2 != 9)
		{
			System.out.println("Fel resultat!");
			System.exit(1);
		} else
			System.out.println("OK");
		
		System.out.println("Test ArrayTools.containsIntElement - element som efterlyses: 9");
		int pos3 = ArrayTools.containsIntElement(A, 9);
		System.out.println("Resultat: " + pos3);
		if (pos3 != -1)
		{
			System.out.println("Fel resultat!");
			System.exit(1);
		} else
			System.out.println("OK");
	}
}

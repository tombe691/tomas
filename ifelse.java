// hello.java
class Ifelse
{
    public static void print ()
    {
	int number = 11;
	if (number > 9) {
	    System.out.println("At least two digits");
	    if (number > 99)
		System.out.println("Three digits");
	}
	else
	    System.out.println("One digit");
    }
	

    public static void main (String[] args)
    {
	print();
    }
}

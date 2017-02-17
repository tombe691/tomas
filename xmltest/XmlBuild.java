public class XmlBuild {
    static void print(String tag, boolean close){
	if (close) {
	    System.out.format("\n</%s>\n", tag);
	}
	else {
	    System.out.format("<%s>\n", tag);
	}
    }
    public static void main (String[] args)
    {
	int i = 0;
	for (String s: args) {
	    print(s, false);
	    i++;
        }
	for (;i>0;i--){
	    print(args[i-1], true);
	}
    }
}

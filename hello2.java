// hello.java
import java.applet.Applet;
import java.applet.AudioClip;
import java.net.URL;
import java.net.MalformedURLException;

class Hello2
{
    public static void print ()  throws MalformedURLException, InterruptedException 
    {
	System.out.println ("Hello World");
        URL u = new URL("file:jingle1.au");
        AudioClip a = Applet.newAudioClip(u);
        a.loop();
        Thread.sleep(9000);
    }
    public static void main (String[] args)  throws MalformedURLException, InterruptedException 
    {
	print();
    }
}

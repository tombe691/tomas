// hello.java
import java.applet.Applet;
import java.applet.AudioClip;
import java.net.URL;
import java.net.MalformedURLException;

import java.awt.Desktop;
import java.net.URI;
import java.io.IOException;
import java.net.URISyntaxException;




class Hello2
{
    public static void print ()  throws MalformedURLException, InterruptedException 
    {
	
	System.out.println ("Hello World");
	int[] arr = new int[10];
	int tal = 3;
	for (int x = 0; x < arr.length; x++)
	    arr[x] = x + tal++;

	System.out.println("Arrayen: ");
	for (int x : arr){
	    System.out.print(x + " ");
	    if (x%3 == 0)
		System.out.println();

	//        URL u = new URL("file:jingle1.au");
        //AudioClip a = Applet.newAudioClip(u);
        //a.loop();
        //Thread.sleep(9000);
	}
    }



    public static void main(String[] args) {
        String url = "http://www.nt.se";
	
        if(Desktop.isDesktopSupported()){
            Desktop desktop = Desktop.getDesktop();
            try {
                desktop.browse(new URI(url));
            } catch (IOException | URISyntaxException e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
	    //print();

        }else{
	    /*            Runtime runtime = Runtime.getRuntime();
            try {
                runtime.exec("xdg-open " + url);
            } catch (IOException e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
	    */
	}
    }
}

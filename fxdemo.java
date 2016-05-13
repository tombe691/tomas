import javafx.*;
import javafx.application.*;
import javafx.stage.*;
import javafx.scene.*;
import javafx.scene.layout.*;
import javafx.scene.control.*;
public class fxdemo extends Application
{
    public static void main(String[] args)
    {
	launch(args);
    }
    Button btn;
    @Override public void start(Stage primaryStage)
    {
	// Create the button
	BackgroundImage backgroundImage = new BackgroundImage( new Image( getClass().getResource("bild2.jpg").toExternalForm()), BackgroundRepeat.NO_REPEAT, BackgroundRepeat.NO_REPEAT, BackgroundPosition.DEFAULT, BackgroundSize.DEFAULT);
        Background background = new Background(backgroundImage);

	btn = new Button();
        btn.setBackground(background);	
	btn.setText("Click me please!");
	btn.setOnAction(e -> buttonClick());
	// Add the button to a layout pane
	BorderPane pane = new BorderPane();
	pane.setCenter(btn);
	// Add the layout pane to a scene
	Scene scene = new Scene(pane, 300, 250);
	// Finalize and show the stage
	primaryStage.setScene(scene);
	primaryStage.setTitle("The Click Me App");
	primaryStage.show();
    }
    public void buttonClick()
    {
	if (btn.getText() == "Click me please!")
	    {
		btn.setText("You clicked me!");
	    }
	else
	    {
		btn.setText("Click me please!");
	    }
    }
}

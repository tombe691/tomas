import javafx.application.Application; 
import javafx.event.ActionEvent; 
import javafx.event.EventHandler;
import javafx.scene.Scene; 
import javafx.geometry.Pos; 
import javafx.scene.control.Button; 
import javafx.scene.control.Label; 
import javafx.scene.control.CheckBox; 
import javafx.scene.layout.HBox; 
import javafx.scene.layout.VBox; 
import javafx.scene.layout.BorderPane; 
import javafx.stage.Stage; 
import javafx.geometry.Insets;   


/** 
 * 
 * @author writing 
 */ 
public class StyleForm extends Application { 
    final String style1 = "/javafxcsscontrols/StyleForm.css"; 
    final String style2 = "/javafxcsscontrols/StyleForm2.css"; 
    final String feedbackLabelText = "StyleSheet Loaded:"; 
    final String borderStyle = "borders"; 
    final String borderStyle2 = "borders";  

    @Override 
	public void start(final Stage primaryStage) { 
	final BorderPane pane = new BorderPane(); 
	final VBox controlBox = new VBox(10); 
	HBox buttonBox = new HBox(10); 
	HBox randomControlBox = new HBox(10); 
	HBox feedbackBox = new HBox(10);  
	final Scene scene = new Scene(pane, 700, 500);  
	
	//Sets the scene to use the first stylesheet 
	scene.getStylesheets().add(style1);  
	
	//Sets the VBox to use the fontstyle from the stylesheet 
	controlBox.getStyleClass().add("fontStyle");  
	
	final Label feedbackLabel = new Label(feedbackLabelText + style1);  
	
	Label borderLabel = new Label("Here's some random text");  
	
	//When the checkbox is checked or unchecked an inline style is set for  
	//the controlBox VBox layout pane around whether to show a border or not 
	CheckBox borders = new CheckBox("Use Borders"); 
	borders.setOnAction(new EventHandler<actionevent>() { 
		@Override public void handle(ActionEvent e) { 
		    if (!controlBox.getStyle().contains("black")) { 
			controlBox.setStyle("-fx-border-color: black;-fx-border-style: dashed;-fx-border-width: 2;");
		    } else { 
			controlBox.setStyle("-fx-border-width: 0;"); 
		    }  
		} 
	    });   
	
	//When the Button is clicked the current stylesheet is cleared from the scene. 
	//It is replaced by the other stylesheet to change the look of the application. 
	//The label tracks which stylesheet is being used 
	Button changeStyleSheet = new Button("Change Style"); 
	changeStyleSheet.setOnAction(new EventHandler<actionevent>() { 
		@Override public void handle(ActionEvent e) { 
		    if (scene.getStylesheets().contains(style1)) { 
			scene.getStylesheets().clear(); 
			scene.getStylesheets().add(style2);  
			feedbackLabel.setText(feedbackLabelText + style2); 
		    } else { 
			scene.getStylesheets().clear(); 
			scene.getStylesheets().add(style1);  
			feedbackLabel.setText(feedbackLabelText + style1); 
		    }   
		} 
	    }); 
	buttonBox.setPadding(new Insets(10)); 
	buttonBox.getChildren().add(changeStyleSheet); 
	buttonBox.setAlignment(Pos.CENTER);
	
	randomControlBox.getChildren().add(borderLabel); 
	randomControlBox.getChildren().add(borders);  
	
	feedbackBox.setPadding(new Insets(10,10,1,0)); 
	feedbackBox.getChildren().add(feedbackLabel);
	
	controlBox.getChildren().add(randomControlBox);
	pane.setPadding(new Insets(10,10,1,10));
	
	pane.setTop(buttonBox);
	pane.setCenter(controlBox);
	pane.setBottom(feedbackBox);
	
	primaryStage.setTitle("Styling JavaFX Controls");
	primaryStage.setScene(scene);
	primaryStage.show();
    }  

    /** 
     * The main() method is ignored in correctly deployed JavaFX application. 
     * main() serves only as fallback in case the application can not be 
     * launched through deployment artifacts, e.g., in IDEs with limited FX 
     * support. NetBeans ignores main(). 
     * 
     * @param args the command line arguments 
     */ 
    public static void main(String[] args) { 
	launch(args);
    } 
} 

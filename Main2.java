import javafx.event.ActionEvent;
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.stage.Stage;
/*from   ww  w.j a va  2 s.c  o  m*/
public class Main2 extends Application {
  public static void main(String[] args) {
    Application.launch(args);
    
  }

  @Override
  public void start(Stage primaryStage) {
    Application.setUserAgentStylesheet(getClass().getResource("sample.css")
        .toExternalForm());
    
    
    Group root = new Group();
    Scene scene = new Scene(root, 300, 250);

    primaryStage.setScene(scene);
    primaryStage.show();
  }
}
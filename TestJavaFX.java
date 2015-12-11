package sample;

        import javafx.application.Application;
        import javafx.event.ActionEvent;
        import javafx.event.EventHandler;
        import javafx.scene.Scene;
        import javafx.scene.control.Button;
        import javafx.scene.control.*;
        import javafx.scene.control.Alert;
        import javafx.scene.layout.StackPane;
        import javafx.stage.Stage;
        import javafx.*;

public class TestJavaFX extends Application {
    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("Hello World!");
        Button btn = new Button();
        btn.setText("Say 'Hello World'");

        btn.setOnAction(new EventHandler<ActionEvent>() {
            int i = 1;
            @Override
            public void handle(ActionEvent event) {
                System.out.println("Hello World!");
                //for (int i = 0; i < 25; i++) {
                    //System.out.println(i);
                btn.setText("kalle" + i);
                Alert alert = new Alert(AlertType.INFORMATION);
                alert.setTitle("Information Dialog");
                alert.setHeaderText("Look, an Information Dialog");
                alert.setContentText("I have a great message for you!");

                alert.showAndWait();
                i++;
                //}
            }
        });

        StackPane root = new StackPane();
        root.getChildren().add(btn);
        primaryStage.setScene(new Scene(root, 300, 250));
        primaryStage.show();
    }
}

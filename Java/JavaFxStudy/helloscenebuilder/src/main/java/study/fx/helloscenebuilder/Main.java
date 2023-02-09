package study.fx.helloscenebuilder;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Group;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.layout.BorderPane;
import javafx.stage.Stage;

public class Main extends Application {

    public static void main(String[] args) {
        launch(args);
    }
    @Override
    public void start(Stage stage) throws Exception {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("Main.fxml"));
            Scene scene = new Scene(root);
//            scene.getStylesheets().add(String.valueOf(getClass().getResource("application.css")));
            stage.setScene(scene);
            stage.show();
        }catch (Exception ex){
            ex.printStackTrace();
        }
    }
}

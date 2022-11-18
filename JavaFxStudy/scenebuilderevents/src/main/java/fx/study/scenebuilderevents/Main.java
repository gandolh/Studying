package fx.study.scenebuilderevents;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.input.KeyEvent;
import javafx.stage.Stage;

import java.io.IOException;

public class Main extends Application {

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage stage) throws Exception {
        try {

            //Main.fxml
//            Parent root = FXMLLoader.load(getClass().getResource("Main.fxml"));
//            Scene scene = new Scene(root);
//            String css = this.getClass().getResource("application.css").toExternalForm();
//            scene.getStylesheets().add(css);
//
//            stage.setScene(scene);
//            stage.show();

            //Main2.fxml
//            Parent root = FXMLLoader.load(getClass().getResource("Main.fxml"));
//            Scene scene = new Scene(root);
//            String css = this.getClass().getResource("application.css").toExternalForm();
//            scene.getStylesheets().add(css);
//            stage.setScene(scene);
//            stage.show();

            // SWITCH SCENES
//            Parent root = FXMLLoader.load(getClass().getResource("Scene1.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

//             Comunication between scenes
//            Parent root = FXMLLoader.load(getClass().getResource("comunication1.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //  Exit button
//            Parent root = FXMLLoader.load(getClass().getResource("ExitButton.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();
//            stage.setOnCloseRequest(event -> {
//                event.consume();
//                exit(stage);
//            });

            // Image view
//            Parent root = FXMLLoader.load(getClass().getResource("ImageViewDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            // validate input
//            Parent root = FXMLLoader.load(getClass().getResource("ValidatorDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //checbox demo
//            Parent root = FXMLLoader.load(getClass().getResource("CheckboxDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //radio buttons demo
//            Parent root = FXMLLoader.load(getClass().getResource("RadioButtonsDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //datepicker demo
//            Parent root = FXMLLoader.load(getClass().getResource("DatePickerDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

//            //colorpicker demo
//            Parent root = FXMLLoader.load(getClass().getResource("ColorPickerDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //ChoiceBox demo
//            Parent root = FXMLLoader.load(getClass().getResource("ChoiceBoxDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //Slider demo
//            Parent root = FXMLLoader.load(getClass().getResource("SliderDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //Progress bar demo
//            Parent root = FXMLLoader.load(getClass().getResource("ProgressBarDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //Spinner demo
//            Parent root = FXMLLoader.load(getClass().getResource("SpinnerDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //ListView demo
//            Parent root = FXMLLoader.load(getClass().getResource("ListViewDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //TreeView demo
//            Parent root = FXMLLoader.load(getClass().getResource("TreeViewDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //Menu bar demo
//            Parent root = FXMLLoader.load(getClass().getResource("MenuBarDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //Flow pane demo
//            Parent root = FXMLLoader.load(getClass().getResource("FlowPaneDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

            //Key events demo
//            FXMLLoader loader = new FXMLLoader(getClass().getResource("KeyEventsDemo.fxml"));
//            Parent root = loader.load();
//            KeyEventsDemo controller = loader.getController();
//
//            Scene scene = new Scene(root);
//            scene.setOnKeyPressed(new EventHandler<KeyEvent>() {
//                @Override
//                public void handle(KeyEvent event) {
////                    System.out.println(event.getCode());
//                    switch (event.getCode()) {
//                        case UP:
//                            controller.moveup();
//                            break;
//                        case DOWN:
//                            controller.movedown();
//                            break;
//                        case LEFT:
//                            controller.moveleft();
//                            break;
//                        case RIGHT:
//                            controller.moveright();
//                            break;
//                        default:
//                            break;
//
//                    }
//                }
//            });
//            stage.setScene(scene);
//            stage.show();

            // Animations demo
//            Parent root = FXMLLoader.load(getClass().getResource("AnimationsDemo.fxml"));
//            Scene scene = new Scene(root);
//            stage.setScene(scene);
//            stage.show();

        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    public void exit(Stage stage) {
        Alert alert = new Alert(Alert.AlertType.CONFIRMATION);
        alert.setTitle("exit");
        alert.setHeaderText("Youre about to exit");
        alert.setContentText("Do you want to save before exiting?");
        if (alert.showAndWait().get() == ButtonType.OK) {

            System.out.println("you succesfully exitted");
            stage.close();
        }

    }
}
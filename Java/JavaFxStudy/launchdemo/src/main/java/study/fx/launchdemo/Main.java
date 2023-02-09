package study.fx.launchdemo;

import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

import java.io.IOException;


public class Main extends Application {
    @Override
    public void start(Stage stage) throws IOException {
        Group root = new Group();
        Scene scene = new Scene(root, Color.BLACK);
        stage.getIcons().add(new Image("file:src/main/resources/study/fx/launchdemo/fox.png"));
        stage.setTitle("Woooo");
        stage.setScene(scene);
        stage.setWidth(420);
        stage.setHeight(420);
        stage.setResizable(false);
//        stage.setX(50);
//        stage.setY(50);
//        stage.setFullScreen(true);
//        stage.setFullScreenExitHint("You cant escape unless until you press q");
//        stage.setFullScreenExitKeyCombination(KeyCombination.valueOf("q"));
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
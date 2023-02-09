package study.fx.drawingstuffs;

import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Line;
import javafx.scene.shape.Polygon;
import javafx.scene.shape.Rectangle;
import javafx.scene.text.Font;
import javafx.scene.text.Text;
import javafx.stage.Stage;

import java.io.File;
import java.io.IOException;


public class Main extends Application {
    @Override
    public void start(Stage stage) throws IOException {
        Group root = new Group();
        Scene scene = new Scene(root, 600, 600, Color.LIGHTSKYBLUE);
        Text text = new Text();
        text.setText("sad");
        text.setX(50);
        text.setY(50);
        text.setFont(Font.font("Verdana", 50));
        text.setFill(Color.GREEN);

        Line line = new Line();
        line.setStartX(200);
        line.setStartY(200);
        line.setEndX(500);
        line.setEndY(500);
        line.setStrokeWidth(5);
        line.setStroke(Color.RED);
        line.setOpacity(0.5);
        line.setRotate(45);
        Rectangle rect = new Rectangle();
        rect.setX(100);
        rect.setY(100);
        rect.setWidth(100);
        rect.setHeight(100);
        rect.setFill(Color.BLUE);
        rect.setStrokeWidth(5);
        rect.setStroke(Color.BLACK);

        Polygon triangle = new Polygon();
        triangle.getPoints().setAll(200.0, 200.0, 300.0, 300.0, 200.0, 300.0);
        triangle.setFill(Color.YELLOW);

        Circle circle = new Circle();
        circle.setCenterX(350);
        circle.setCenterY(350);
        circle.setRadius(50);
        circle.setFill(Color.ORANGE);
        Image image = new Image("file:src/main/resources/study/fx/drawingstuffs/fox.png");
        ImageView imageView = new ImageView();
        imageView.setImage(image);
        imageView.setFitWidth(50);
        imageView.setPreserveRatio(true);
        imageView.setSmooth(true);
        imageView.setX(400);
        imageView.setY(400);
        imageView.setCache(true);
        root.getChildren().add(text);
        root.getChildren().add(line);
        root.getChildren().add(rect);
        root.getChildren().add(triangle);
        root.getChildren().add(circle);
        root.getChildren().add(imageView);
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
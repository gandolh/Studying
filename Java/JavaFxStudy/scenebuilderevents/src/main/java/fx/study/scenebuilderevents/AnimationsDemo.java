package fx.study.scenebuilderevents;

import javafx.animation.*;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.image.ImageView;
import javafx.scene.transform.Rotate;
import javafx.util.Duration;

import java.net.URL;
import java.util.ResourceBundle;

public class AnimationsDemo implements Initializable {
    @FXML
    private ImageView myImage;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        //translate
        TranslateTransition translate = new TranslateTransition();
        translate.setNode(myImage);
        translate.setByX(500);
//        translate.setByY(250);
        translate.setDuration(Duration.millis(1000));
        translate.setCycleCount(TranslateTransition.INDEFINITE);
        translate.setAutoReverse(true);
        translate.play();

        //rotate
        RotateTransition rotate = new RotateTransition();
        rotate.setNode(myImage);
        rotate.setByAngle(360);
        rotate.setDuration(Duration.millis(1000));
        rotate.setCycleCount(TranslateTransition.INDEFINITE);
        rotate.setAutoReverse(true);
        rotate.setInterpolator(Interpolator.LINEAR);
        rotate.setAxis(Rotate.Y_AXIS);
        rotate.play();

        //fade
        FadeTransition fade = new FadeTransition();
        fade.setNode(myImage);
        fade.setFromValue(1);
        fade.setToValue(0.5);
        fade.setDuration(Duration.millis(1000));
        fade.setCycleCount(TranslateTransition.INDEFINITE);
        fade.setAutoReverse(true);
        fade.play();

        //scale
        ScaleTransition scale = new ScaleTransition();
        scale.setNode(myImage);
        scale.setByX(1.5);
        scale.setByY(1.5);
        scale.setDuration(Duration.millis(1000));
        scale.setCycleCount(TranslateTransition.INDEFINITE);
        scale.setAutoReverse(true);
        scale.play();
    }
}

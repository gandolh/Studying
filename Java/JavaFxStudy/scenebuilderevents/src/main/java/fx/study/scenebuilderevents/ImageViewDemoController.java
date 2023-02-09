package fx.study.scenebuilderevents;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

public class ImageViewDemoController {
    @FXML
    ImageView myImageView;
    @FXML
    Button myButton;

    Image myImage = new Image(getClass().getResourceAsStream("fox1.jpg"));
    Image myImage2 = new Image(getClass().getResourceAsStream("fox2.png"));

    public void run(){
        myImageView.setImage(myImage2);
    }

    public void stay(){
        myImageView.setImage(myImage);
    }
}

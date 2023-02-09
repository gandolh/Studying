package fx.study.scenebuilderevents;

import javafx.fxml.FXML;
import javafx.scene.control.Label;

public class Comunication2Controller {
    @FXML
    public Label username;

    public void displayName(String username){
        this.username.setText("Hello " + username);
    }
}

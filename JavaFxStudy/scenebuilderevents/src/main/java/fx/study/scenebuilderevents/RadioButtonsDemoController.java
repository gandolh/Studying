package fx.study.scenebuilderevents;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.RadioButton;

public class RadioButtonsDemoController {
    @FXML
    private Label myLabel;
    @FXML
    private RadioButton rbutton1;
    @FXML
    private RadioButton rbutton2;
    @FXML
    private RadioButton rbutton3;

    public void getFood(ActionEvent event){
        if(rbutton1.isSelected())
            myLabel.setText(rbutton1.getText());
        else if(rbutton2.isSelected())
            myLabel.setText(rbutton2.getText());
        else myLabel.setText(rbutton3.getText());

    }
}

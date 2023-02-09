package fx.study.scenebuilderevents;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.CheckBox;
import javafx.scene.control.Label;

public class CheckboxDemoController {

    @FXML
    private CheckBox myCheckBox;
    @FXML
    private Label myLabel;

    public void change(ActionEvent event){
        if(myCheckBox.isSelected())
            myLabel.setText("ON");
        else myLabel.setText("OFF");
    }
}

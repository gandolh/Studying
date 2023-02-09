package fx.study.scenebuilderevents;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.io.IOException;

public class Comunication1Controller {
    @FXML
    TextField username;


    private Stage stage;
    private Scene scene;
    private Parent root;
    public void login(ActionEvent event) throws IOException{
        String username = this.username.getText();
        FXMLLoader loader = new FXMLLoader(getClass().getResource("comunication2.fxml"));
        root = loader.load();
        Comunication2Controller com2controller = loader.getController();
        com2controller.displayName(username);
//        root = FXMLLoader.load(getClass().getResource("comunication2.fxml"));
        stage = (Stage) ((Node)event.getSource()).getScene().getWindow();
        scene = new Scene(root);
        stage.setScene(scene);
        stage.show();
    }
}

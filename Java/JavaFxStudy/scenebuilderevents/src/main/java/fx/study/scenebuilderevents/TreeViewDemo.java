package fx.study.scenebuilderevents;

import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.TreeItem;
import javafx.scene.control.TreeView;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

import java.net.URL;
import java.util.ResourceBundle;

public class TreeViewDemo implements Initializable {

    @FXML
    private TreeView myTreeView;


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        TreeItem<String> rootItem = new TreeItem<>("Files", new ImageView(new Image("file:fox.png")));

        TreeItem<String> branchItem1 = new TreeItem<>("Pictures");
        TreeItem<String> branchItem2 = new TreeItem<>("Videos");
        TreeItem<String> branchItem3 = new TreeItem<>("Music");

        TreeItem<String> leafItem1 = new TreeItem<>("Picture 1");
        TreeItem<String> leafItem2 = new TreeItem<>("Picture 2");
        TreeItem<String> leafItem3 = new TreeItem<>("Videos 1");
        TreeItem<String> leafItem4 = new TreeItem<>("Videos 2");
        TreeItem<String> leafItem5 = new TreeItem<>("Music 1");
        TreeItem<String> leafItem6 = new TreeItem<>("Music 2");

        branchItem1.getChildren().addAll(leafItem1,leafItem2);
        branchItem2.getChildren().addAll(leafItem3,leafItem4);
        branchItem3.getChildren().addAll(leafItem5,leafItem6);

        rootItem.getChildren().addAll(branchItem1,branchItem2,branchItem3);
//        myTreeView.setShowRoot(false);
        myTreeView.setRoot(rootItem);
    }
    public void selectItem(){
            TreeItem<String> item = (TreeItem<String>) myTreeView.getSelectionModel().getSelectedItem();
            if(item != null)
        System.out.println(item.getValue());
    }


}

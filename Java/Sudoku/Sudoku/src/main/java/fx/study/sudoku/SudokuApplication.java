package fx.study.sudoku;

import fx.study.sudoku.buildlogic.SudokuBuildLogic;
import fx.study.sudoku.userinterface.IUserInterfaceContract;
import fx.study.sudoku.userinterface.UserInterfaceImpl;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;

public class SudokuApplication extends Application {
    private IUserInterfaceContract.View uiImpl;

    @Override
    public void start(Stage stage) throws IOException {
        uiImpl = new UserInterfaceImpl(stage);
        try {
            SudokuBuildLogic.build(uiImpl);
        }catch (IOException e){
            e.printStackTrace();
        }


    }

    public static void main(String[] args) {
        launch(args);
    }
}
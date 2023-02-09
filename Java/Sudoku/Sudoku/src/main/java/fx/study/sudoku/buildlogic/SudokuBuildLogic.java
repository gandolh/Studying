package fx.study.sudoku.buildlogic;

import fx.study.sudoku.IStorage;
import fx.study.sudoku.SudokuGame;
import fx.study.sudoku.computationlogic.GameLogic;
import fx.study.sudoku.persistence.LocalStorageImpl;
import fx.study.sudoku.userinterface.IUserInterfaceContract;
import fx.study.sudoku.userinterface.logic.ControlLogic;

import java.io.IOException;

public class SudokuBuildLogic {
    public static void build(IUserInterfaceContract.View userInterface) throws IOException {
        SudokuGame initialState;
        IStorage storage = new LocalStorageImpl();

        try{
            initialState = storage.getGameData();
        }catch (IOException e){
            initialState = GameLogic.getNewGame();
            storage.updateGameData(initialState);
        }
        IUserInterfaceContract.EventListener uiLogic = new ControlLogic(storage, userInterface);
        userInterface.setListener(uiLogic);
        userInterface.updateBoard(initialState);

    }

}

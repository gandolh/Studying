module fx.study.sudoku {
    requires javafx.controls;
    requires javafx.fxml;


    opens fx.study.sudoku to javafx.fxml;
    exports fx.study.sudoku;
}
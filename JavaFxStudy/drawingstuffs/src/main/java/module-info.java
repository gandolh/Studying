module study.fx.drawingstuffs {
    requires javafx.controls;
    requires javafx.fxml;


    opens study.fx.drawingstuffs to javafx.fxml;
    exports study.fx.drawingstuffs;
}
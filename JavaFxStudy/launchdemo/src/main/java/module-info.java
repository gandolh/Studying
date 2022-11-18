module study.fx.launchdemo {
    requires javafx.controls;
    requires javafx.fxml;


    opens study.fx.launchdemo to javafx.fxml;
    exports study.fx.launchdemo;
}
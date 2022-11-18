module fx.study.mp3player {
    requires javafx.controls;
    requires javafx.fxml;
    requires javafx.media;


    opens fx.study.mp3player to javafx.fxml;
    exports fx.study.mp3player;
}
//module study.fx.helloscenebuilder {
//    requires javafx.controls;
//    requires javafx.fxml;
//
//
//    opens study.fx.helloscenebuilder to javafx.fxml;
//    exports study.fx.helloscenebuilder;
//
//}

module study.fx.helloscenebuilder{
    requires javafx.controls;
    requires javafx.fxml;

    opens study.fx.helloscenebuilder to javafx.fxml;
    exports study.fx.helloscenebuilder;
    }
package classesDemo;

public class Circle extends GraphicObject{
    int x,y;

    @Override
    void draw() {
        System.out.println("Drawing circle");
    }

    @Override
    void resize() {
        System.out.println("Resizing circle");
    }
}

package classesDemo;

public class Rectangle extends GraphicObject{
    @Override
    void draw() {
        System.out.println("Drawing rectangle");

    }

    @Override
    void resize() {
        System.out.println("Resizing rectangle");

    }
}

package classesDemo;

public abstract class GraphicObject {
    int x,y;
    GraphicObject(){
        System.out.println("base abstract class");

    }
    void MoveTo(int newX, int newY){
        System.out.println("move to x: " + x + " and y: " + y);
    }
    abstract void draw();
    abstract void resize();
}

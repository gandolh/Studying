package classesDemo;

public class Cuboid {
    int width;
    int height;
    int depth;

    Cuboid(int width, int height, int depth) {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }

    Cuboid(int width, int height) {
        this.width = width;
        this.height = height;
        this.depth = 10;
    }

    Cuboid(int dimension) {
        width = dimension;
        height = dimension;
        depth = dimension;
    }
    Cuboid(){
        this.width=10;
        this.height=10;
        this.depth=10;
    }
    int Volume(){
        return width*height*depth;
    }
}

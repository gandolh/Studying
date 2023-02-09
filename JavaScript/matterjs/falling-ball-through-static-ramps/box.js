class Circle {
    constructor(x, y, r) {
        this.r = r;
        let options = {
            restitution: 0.6,
            friction: 0,
            frictionAir: 0,
            density: 0.01
        }
        this.body = Bodies.circle(x, y, r, options);
        World.add(world, this.body);
    }
    show() {

        this.pos = this.body.position;
        rectMode(CENTER);
        circle(this.pos.x, this.pos.y,this.r*2, this.r*2);


    }
    removeFromWorld() {
        World.remove(world, this.body);
    }
}
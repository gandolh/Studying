
class Boundary {
    constructor(x, y, w, h,a){
        this.w = w;
        this.h = h;
        let options={
            friction:0,
            restitution:0.3,
            isStatic: true,
            angle: a
            
        }
        this.body = Bodies.rectangle(x, y, w, h,options);
        World.add(world, this.body);
    }
    show() {

        let pos = this.body.position;
        let angle = this.body.angle;
        push();
        translate(pos.x, pos.y);
        rotate(angle);
        rectMode(CENTER);
        fill(170);
        noStroke();
        rect(0, 0, this.w, this.h);
        pop();
    }
}
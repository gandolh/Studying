
class Circle {
    constructor(x, y, r){
        this.r=r;
        let options={
            friction:0.3,
            restitution: 0.6
        }
        this.body = Bodies.circle(x, y, r,options);
        World.add(world, this.body);
    }
    show() {

        let pos = this.body.position;
       // let angle = this.body.angle;
        push();
        translate(pos.x, pos.y);
        //rotate(angle);
        ellipseMode(CENTER);
        ellipse(0,0,this.r*2,this.r*2);
        pop();
    }
}
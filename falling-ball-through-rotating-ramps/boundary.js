
class Boundary {
    constructor(x, y, w, h){
        this.w = w;
        this.h = h;
        let options={
            friction:0.3,
            restitution: 0.6,
            isStatic: true,
            
        }
        this.body = Bodies.rectangle(x, y, w, h,options);
        //console.log(this.body);
        World.add(world, this.body);
        this.angularVel= random(-0.05,-0.01) || (0.01,0.05);
    }
    rotate(){
    let angle=this.body.angle +this.angularVel;
    Body.setAngle(this.body,angle);
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
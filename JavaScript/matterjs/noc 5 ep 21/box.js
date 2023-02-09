
class Particle {
    constructor(x, y, r,fixed){
        this.r=r;
        let options={
            friction:0,
            restitution: 0.95,
            isStatic: fixed
        }
        this.body = Bodies.circle(x, y, r,options);
        World.add(world, this.body);
    }
    show() {

        this.pos = this.body.position;
        push();
        fill(255,120);
        translate(this.pos.x, this.pos.y);
        ellipseMode(CENTER);
        ellipse(0, 0, this.r*2);
        pop();

    }
    isOffScreen(){
    return circles[i].pos.x<0 || circles[i].pos.x>width || circles[i].pos.y<0 || circles[i].pos.y>height
    }
    removeFromWorld(){
        World.remove(world,this.body);    
    }
}
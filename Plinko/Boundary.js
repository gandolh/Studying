class Boundary {
    constructor(x, y, w,h,colore=255) {
    	this.colore=colore;
        let options = {
            isStatic: 1
        }
        this.body = Bodies.rectangle(x, y, w,h,options);
        this.w=w;
        this.h=h;
        World.add(world, this.body);
    }
    show() {

        push();
        fill(this.colore);
        noStroke();
        translate(this.body.position.x, this.body.position.y);
        rectMode(CENTER);
        rect(0, 0, this.w,this.h);
        pop();
    }
}
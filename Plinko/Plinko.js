class Plinko {
    constructor(x, y, r,colore) {
    	this.colore=colore;
        let options = {
            isStatic: true,
            restitution: 1,
            friction: 0
        }
        this.body = Bodies.circle(x, y, r, options);
        this.r = r;
        World.add(world, this.body);
    }
    show() {
        fill(this.colore);
        //stroke(255);
      	noStroke();
        push();
        translate(this.body.position.x, this.body.position.y);
        ellipse(0, 0, this.r * 2);
        pop();
    }
}
class Ground{
	constructor(x,y,w,h){
		this.x=x;
		this.y=y;
		this.w=w;
		this.h=h;
		let options={
            friction:1,
            restitution: 0.6,
            isStatic: true   
        }
        this.body = Bodies.rectangle(x, y, w, h,options);
        World.add(world, this.body);
	}
	show() {
        let pos = this.body.position;
        push();
        translate(pos.x, pos.y);
        rectMode(CENTER);
        fill(170);
        noStroke();
        rect(0, 0, this.w, this.h);
        pop();
    }
}
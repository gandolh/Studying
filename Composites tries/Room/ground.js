class Ground{
	constructor(x,y,w,h,a){
		this.x=x;
		this.y=y;
		this.w=w;
		this.h=h;
        this.a=a;
		let options={
            angle:a,
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
        rotate(this.a)
        rectMode(CENTER);
        fill('#5CFF3D');
        noStroke();
        rect(0, 0, this.w, this.h);
        pop();
    }
}
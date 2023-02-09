class Ball{
	constructor(x,y,r){
		this.r=r;
        let options = {
        	mass:100,
        	inverseMass:1/100
        }
    	this.body= Bodies.circle(x,y,r,options);
    	World.add(world,this.body);
	}
    show() {
    	noStroke();
        this.pos = this.body.position;
        fill('#278ea5');
        circle(this.pos.x, this.pos.y,this.r*2, this.r*2);


    }}

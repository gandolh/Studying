class Pyramid {
    constructor(x,y,rows,columns) {
    	let options={

    		restitution:0.9
    	}
    	var n=15;
        this.pyr= Composites.pyramid(x, y, rows, columns,0, 0, function(x, y) {
            return Bodies.rectangle(x, y, n, n,options);
        });
        this.n=n;
        World.add(world, this.pyr);

    }
    show() {
        push();
       	rectMode(CENTER);
        let bodies= Composite.allBodies(pyramid.pyr);
        //console.log(bodies);
        fill('#f0f696');
        stroke('#e0c45c');
        strokeWeight(1);
        for(let p of bodies)rect(p.position.x, p.position.y, this.n,this.n);
        pop();
    }
}
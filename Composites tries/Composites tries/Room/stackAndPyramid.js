class Stackul{
     constructor(){
          this.body= Composites.stack(600,height-145,3,3,15,15,(x,y)=>{return Bodies.rectangle(x,y,20,20)});
          World.add(world,this.body);
     }
     show(){
            let bodies= Composite.allBodies(this.body);
        let colora=color('#FEFB81');
        stroke('#FEFA95');
        strokeWeight(2);
        colora.setAlpha(160);
        fill(colora);
          rectMode(CENTER);
          for(let p of bodies)rect(p.position.x,p.position.y,20,20);
     }
}
class Pyramid {
    constructor(x,y,rows,columns) {
     let options={

          restitution:0.9
     }
     var n=15;
        this.body= Composites.pyramid(x, y, rows, columns,0, 0, function(x, y) {
            return Bodies.rectangle(x, y, n, n,options);
        });
        this.n=n;
        World.add(world, this.body);

    }
    show() {
        push();
          rectMode(CENTER);
        let bodies= Composite.allBodies(pyramid.body);
        
        //console.log(bodies);
        noStroke();
        let colora=color('#8FFFC5');
        colora.setAlpha(160);
        fill(colora);
        strokeWeight(1);
        for(let p of bodies)rect(p.position.x, p.position.y, this.n,this.n);
        pop();
    }
}
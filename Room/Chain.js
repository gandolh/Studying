class Chain {
     constructor(x,y,widthBox,heightBox,elements) {
          this.wd=widthBox;
          this.he=heightBox;
         let boxes = Composites.stack(x, y, elements, 1, 10, 0, (x, y) => {
             return Bodies.rectangle(x, y, widthBox, heightBox);
         });
         this.body = Composites.chain(boxes, 0.5, 0, -0.5, 0, { stiffness: 1 });
         World.add(world, this.body);
         Composite.add(boxes, Constraint.create({
             bodyA: boxes.bodies[0],
             pointB: { x: 3*width/4, y: 0 },
             stiffness: 0.8
         }));
     }
     show() {
         let bodies = Composite.allBodies(this.body);
         stroke(255);
         strokeWeight(2);
         line(bodies[0].position.x,bodies[0].position.y,3*width/4,0);
         for(let i=0;i<2;i++)line(bodies[i].position.x, bodies[i].position.y,bodies[i+1].position.x, bodies[i+1].position.y);
         fill(189,220);
          noStroke();
         rectMode(CENTER);
         fill('#800E0C');
         rect(bodies[0].position.x, bodies[0].position.y, this.wd, this.he);
         fill('#CC1E18');
         rect(bodies[1].position.x, bodies[1].position.y, this.wd, this.he);
         fill('#FF514B');
         rect(bodies[2].position.x, bodies[2].position.y, this.wd, this.he);
     }
 }
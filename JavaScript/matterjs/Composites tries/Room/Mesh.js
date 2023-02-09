class Mesh {
     constructor(x,y,widthBox,heightBox) {

         this.wd = widthBox;
         this.he = heightBox;
         let boxes = Composites.stack(x, y, 5, 12, 12, 12, (x, y) => {
             return Bodies.rectangle(x, y, widthBox, heightBox);
         });

         this.body = Composites.mesh(boxes,5,12,0,{});
         Composite.add(boxes, Constraint.create({
             bodyA: boxes.bodies[0],
             pointB: { x: x, y: y },
             stiffness: 0.8
         }));
         Composite.add(boxes, Constraint.create({
             bodyA: boxes.bodies[4],
             pointB: { x: x+100, y: y+100 },
             stiffness: 0.8
         }));
         World.add(world, this.body);
     }
     show() {
          noStroke();
         let bodies = Composite.allBodies(this.body);
         //console.log(bodies)
         rectMode(CENTER);
         let colora=color('#C8FF8A');
         colora.setAlpha(160);
         fill(colora);
         for (let p of bodies) rect(p.position.x, p.position.y, this.wd * 2, this.he * 2);
     }
 }
 class NewtonCradle {
     constructor(x, y, r) {
         this.colors = ['#FEFA65', '#E8D359', '#FFDD68', '#FFC564','#E8B850'];
         this.y = y;
         this.r = r;
         this.body = Composites.newtonsCradle(x, y, 5, r, 245);
         World.add(world, this.body);
         let bodies = Composite.allBodies(this.body);
         this.x = bodies[2].position.x;
         Body.translate(bodies[0], { x: -80, y: -40 });
     }
     show() {
         let bodies = Composite.allBodies(this.body);
         fill(255);
         stroke(255);
         strokeWeight(2);
         for (let p of bodies) line(p.position.x, p.position.y, this.x, this.y);
         noStroke();
         for (let i = 0; i < bodies.length; i++) {
             fill(this.colors[i]);
             ellipse(bodies[i].position.x, bodies[i].position.y, this.r * 2, this.r * 2);
         }
     }
 }
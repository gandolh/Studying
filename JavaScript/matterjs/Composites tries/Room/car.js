class Car {
     constructor(x, y, width, height, wheelsRadius) {
          this.width=width;
          this.height=height;
          this.r=wheelsRadius;
         this.body = Composites.car(x, y, width, height, wheelsRadius);
         World.add(world, this.body);
     }
     show() {
         let bodies = Composite.allBodies(car.body);
         fill(255, 20);
         rectMode(CENTER);
         ellipseMode(CENTER);
         push();
         translate(bodies[0].position.x, bodies[0].position.y);
         rotate(bodies[0].angle);
         let colora=color('#FFBF50');
         colora.setAlpha(160);
         fill(colora);
         rect(0,0, this.width, this.height);
         pop();
                  let colorb=color('#FFBF50');
         colorb.setAlpha(160);
         fill(colorb);
         ellipse(bodies[1].position.x, bodies[1].position.y, 2*this.r, 2*this.r);
         ellipse(bodies[2].position.x, bodies[2].position.y, 2*this.r, 2*this.r);
     }
 }
 class SoftBody {
     constructor(x,y,r) {
          this.r=r;
         this.body = Composites.softBody(x, y, 5, 5, 0, 0, 0, r, {}, {});
         World.add(world, this.body);
     }
     show() {
         let bodies = Composite.allBodies(this.body);
         //console.log(bodies)
         ellipseMode(CENTER);
         let colora=color('#FB91FB');
        // colora.setAlpha(130);
        fill(colora);
         for (let p of bodies) ellipse(p.position.x, p.position.y, this.r*2, this.r*2);
     }
 }
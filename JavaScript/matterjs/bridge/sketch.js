 // module aliases
 let Engine = Matter.Engine,
     World = Matter.World,
     Constraint = Matter.Constraint,
     Composite = Matter.Composite,
     Composites = Matter.Composites,
     Bodies = Matter.Bodies;
 let engine, world;
 let bridge;

 function setup() {
     createCanvas(windowWidth, windowHeight);
     engine = Engine.create();
     world = engine.world;
   
     let boxes = Composites.stack(150, 300, (width-300)/10, 1, 0, 0, (x, y) => {
         return Bodies.rectangle(x, y, 10, 10,{            density: 0.005,
            frictionAir: 0.05});
     });
     bridge = Composites.chain(boxes, 0.15, 0, -0.15, 0, { stiffness: 1,length: 0 });

     Composite.add(boxes, Constraint.create({
         bodyA: boxes.bodies[0],
         pointB: { x: 150, y: 300 },
         stiffness: 1
     }));
     Composite.add(boxes, Constraint.create({
         bodyA: boxes.bodies[boxes.bodies.length-1],
         pointB: { x: boxes.bodies[boxes.bodies.length-1].position.x, y: boxes.bodies[boxes.bodies.length-1].position.y },
         stiffness: 0
     }));
     World.add(world, bridge);
     //Engine.run(engine);
 }
 let boxes=[];
function mousePressed(){
    let b= Bodies.rectangle(mouseX,mouseY,25,25);
    boxes.push(b);
   // console.log(b);
    World.add(world,b);
}
 function draw() {
     noStroke();
     background(0);
     Engine.update(engine);
     stroke(255, 120);
     for (let p of bridge.bodies) {
          push();
             fill(255, 120);
        translate(p.position.x,p.position.y+10);
        rotate(p.angle);
        rect(0,0,10,10);
        pop();
     }
     for(let b of boxes){
        push();
         fill(255, 20);
        translate(b.position.x,b.position.y);
        rotate(b.angle);
        rect(0,0,25,25);
        pop();
     }
 }
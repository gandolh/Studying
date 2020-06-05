 // module aliases
 let Engine = Matter.Engine,
     World = Matter.World,
     Constraint = Matter.Constraint,
     Bodies = Matter.Bodies,
     Mouse= Matter.Mouse,
     MouseConstraint= Matter.MouseConstraint;
 let engine;
 let world;
 let ground, particles = [];
 let mConstraint;
 function setup() {
     let canvas= createCanvas(windowWidth, windowHeight);
     engine = Engine.create();
     world = engine.world;
     //Engine.run(engine);
     ground = new Boundary(width / 2, height, width, -15, 0);
     let prev=null ,fixed=1;
     for (let x = 20; x < 380; x += 20) {
         let p = new Particle(width / 2  + x, 100, 10,fixed);
         particles.push(p);
         if (prev) {
             var options = {
                 bodyA: p.body,
                 bodyB: prev.body,
                 length: 20,
                 stiffness: 0.4
             }
             let constraint = Constraint.create(options);
             World.add(world, constraint);
           
         }
        fixed=0;
         prev = p;

     }
     let canvasmouse=Mouse.create(canvas.elt);
     canvasmouse.pixelRatio=pixelDensity();
    options={
        mouse:canvasmouse
     }
     mConstraint= MouseConstraint.create(engine,options);
     World.add(world,mConstraint);


 }

 function mousePressed() {

 }

 function draw() {
     noStroke();
     background(0);
     Engine.update(engine);
     ground.show();
     for (let p of particles) p.show();
     stroke(255);

 }
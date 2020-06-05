 // module aliases
 let Engine = Matter.Engine,
     World = Matter.World,
     Body = Matter.Body,
     Constraint = Matter.Constraint,
     Composites = Matter.Composites,
     Composite = Matter.Composite,
     Bodies = Matter.Bodies;
 let engine;
 let world;
 let ground, ground1, car, chain, softBody,mesh,newtonCradle,stack,pyramid;

 function setup() {
     createCanvas(windowWidth, windowHeight);
     engine = Engine.create();
     world = engine.world;
     Engine.run(engine);
     ground = new Ground(width / 2, height - 15, width, 45, 0);
     ground1 = new Ground(100, 600, 400, 15, PI / 12);
     car = new Car(0, 0, 120, 20, 20);
     chain = new Chain(3 * width / 4 - 150, 80, 50, 40, 3);
     softBody = new SoftBody(3 * width / 4 - 50, 400, 15);
     mesh = new Mesh(600, 0, 10, 10);
     newtonCradle= new NewtonCradle(250,0,15);
     stack = new Stackul();
     pyramid= new Pyramid(75,height - 112.5 - 25,30,15);

 }

 function draw() {
     noStroke();
     background(0);
     Engine.update(engine);
     ground.show();
     ground1.show();
     car.show();
     chain.show();
     softBody.show();
     mesh.show();
     newtonCradle.show();
     stack.show();
     pyramid.show();
 }

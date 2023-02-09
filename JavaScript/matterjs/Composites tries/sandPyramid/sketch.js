 // module aliases
 let Engine = Matter.Engine,
     World = Matter.World,
     Constraint = Matter.Constraint,
     Composites = Matter.Composites,
     Composite = Matter.Composite,
     Bodies = Matter.Bodies;
 let engine;
 let world;
 let ground, pyramid,ball;

 function setup() {
     createCanvas(windowWidth, windowHeight);
     engine = Engine.create();
     world = engine.world;
     Engine.run(engine);
     ball = new Ball(width / 2, 200, 15);
     ground = new Ground(width / 2, height-15, width, 45);
     pyramid = new Pyramid(width / 2-30*15/2, height - 187.5 - 25, 30, 25);
     pyramid.show();
 }

 function mousePressed() {

 }

 function draw() {
     noStroke();
     background(0);
     Engine.update(engine);
     ground.show();
     pyramid.show();
     ball.show();
     stroke(255);

 }
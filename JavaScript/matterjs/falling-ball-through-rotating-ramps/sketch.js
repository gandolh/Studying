// module aliases
let Engine = Matter.Engine,
    World = Matter.World,
    Bodies = Matter.Bodies,
    Body = Matter.Body;
let engine;
let world;
let circles = [],
    RotativePlatforms = [];
let n=20;
function setup() {
    createCanvas(windowWidth, windowHeight);
    engine = Engine.create();
    world = engine.world;
    Engine.run(engine);
    // creating platforms
    n=(width-width/4)/120;
    for (let i = 0; i <= n; i++) RotativePlatforms[i] = [];
    for (let i = 1; i <= n; i++) {
        for (let j = 3; j < n; j++) {
            
            RotativePlatforms[i][j] = new Boundary(width/4+i*70,j*70,70,2);
        }

    }
    //end creating platforms
    World.add(world, RotativePlatforms);
}

function mousePressed() {
    circles.push(new Circle(mouseX, mouseY, 15));
}

function draw() {
    background(0);
    Engine.update(engine);
    fill(255);
    stroke(0);
    strokeWeight(1);
    for (let i = 1; i <= n; i++) {
        for (let j = 3; j < n; j++) {
            RotativePlatforms[i][j].rotate();
            RotativePlatforms[i][j].show();
        }
    }

    for (let b of circles) b.show();
}
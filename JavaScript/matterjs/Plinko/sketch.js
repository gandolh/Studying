// module aliases
let Engine = Matter.Engine,
    World = Matter.World,
    Bodies = Matter.Bodies;
let engine, world, particles = [],
    plinkos = [],
    bounds = [];
let cols = 13,
    rows = 13;
function setup() {
    createCanvas(600, windowHeight);
    colorMode(HSB);
    engine = Engine.create();

    world = engine.world;
    world.gravity.y = 2;
    let spacing = width / cols;
    for (let j = 0; j < rows; j++)
        for (let i = 0; i < cols + 1; i++) {
            let x = i * spacing;
            if (j % 2 == 0) {
                x += spacing / 2;
            }
            let y = spacing + j * spacing+50;
            let colore=color(120,30+j*4.5,155)
            plinkos.push(new Plinko(x, y, 7.5,colore));
        }
    bounds.push(new Boundary(width / 2, height + 50, width, 100));
     //bounds.push(new Boundary(-10, height/2, 20, height));
     // bounds.push(new Boundary(width+10, height/2, 20, height));
    for (let i = 0; i < cols + 1; i++) {
        let x = i * spacing;
        let h = 100;
        let w = 10;
        let y = height - (h / 2);
        let colore=color(32,100,255);
        bounds.push(new Boundary(x, y, w, h,colore));
    }
    particles.push(new Particle(random(150,width-150), 50, 10));
}

function draw() {

    background(10);
        if (frameCount % 60 == 0) {
        particles.push(new Particle(random(150,width-150), 50, 10));
    }
   // console.log(frameRate());
    Engine.update(engine);

    for (let i = particles.length - 1; i > 0; i--) {
        particles[i].show();
        if (particles[i].isOffScreen()) {
            World.remove(world, particles[i].body);
            particles.splice(i, 1);
        }
    }
    for (let p of plinkos) p.show();
    for (let p of bounds) p.show();
}
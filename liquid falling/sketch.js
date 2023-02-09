// module aliases
let Engine = Matter.Engine,
    World = Matter.World,
    Body= Matter.Body,
    Common = Matter.Common
    Bodies = Matter.Bodies; 
let engine;
let world;
let circles=[],
boundaries=[];
function setup() {
    createCanvas(windowWidth, windowHeight);

    engine = Engine.create();
    world = engine.world;
    Engine.run(engine);
    for(let i=0;i<(height/150)-1;i++){
      if(i%2==0)boundaries.push(new Boundary(300,i*150+50,width/2+50,15,0.3));  
        else{
            boundaries.push(new Boundary(width-300,i*150+50,width/2+50,15,-0.3));  
        }
    }
    for(let i=0;i<100;i++)circles.push(new Circle(width*0.15+random(0,50),0,4));
      filter(BLUR, 10);filter(THRESHOLD);  
    }


function draw() {

    noStroke();
    background(0);
    BrownianMotion();
    Engine.update(engine);

    fill('#22d1ee');
    for(let i=circles.length-1;i>0;i--){
        circles[i].show();
        if( circles[i].pos.y>height){
             circles[i].removeFromWorld(); 
            circles.splice(i,1);

        }
    }
        
        for(let b of boundaries)b.show();
           if(frameCount%100==0)for(let i=0;i<75;i++)circles.push(new Circle(width*0.15+random(0,50),0,3)); 
}
function BrownianMotion(){
    let bodies = world.bodies;
    for (let i = 0; i < bodies.length; i++) {
        let body = bodies[i];

        if (!body.isStatic) {
            Body.translate(body, {
                x: Common.random(-1, 1) * 0.25,
                y: Common.random(-1, 1) * 0.25
            });
        }
    }
}
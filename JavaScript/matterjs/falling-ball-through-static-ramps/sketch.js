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
    for(let i=0;i<=height/100;i++){
      if(i%2==0)boundaries.push(new Boundary(300,i*100+50,width/2+50,15,0.2));  
        else{
            boundaries.push(new Boundary(width-300,i*100+50,width/2+50,15,-0.1));  
        }
    }
    
      //filter(BLUR, 10);filter(THRESHOLD);  
    }


function draw() {

    noStroke();
    background(0);

    Engine.update(engine);

    fill('#22d1ee');
    for(let i=circles.length-1;i>0;i--){
        circles[i].show();
        if(circles[i].pos.x<0 || circles[i].pos.x>width || circles[i].pos.y<0 || circles[i].pos.y>height){
             circles[i].removeFromWorld(); 
            circles.splice(i,1);

        }
    }
        
        for(let b of boundaries)b.show();
           if(frameCount%30==0)circles.push(new Circle(width*0.15+random(0,50),0,15));  
}

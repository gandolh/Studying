class Particle {
    constructor(x, y, r) {
        this.hue=random(360);
        let options = {
            restitution: 0.5,
            friction: 0,
            density:1
        }
        this.r = r;
        x+=random(-1,1);
        this.body = Bodies.circle(x, y, r, options);
        World.add(world, this.body);
    }
    show() {
        fill(this.hue,155,155);
        noStroke();
        push();
        translate(this.body.position.x, this.body.position.y);
        ellipse(0, 0, this.r * 2);
        pop();
    }
}
Particle.prototype.isOffScreen = function() {
    let x = this.body.position.x;
    return (x < -50 || x > width + 50)
}
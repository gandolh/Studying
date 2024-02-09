import * as THREE from 'three';

const scene = new THREE.Scene();

const camera = new THREE.PerspectiveCamera(50, 2/1, 0.1, 1000);
camera.position.z = 15;

const renderer = new THREE.WebGLRenderer();
renderer.setSize(800, 400);
document.body.appendChild(renderer.domElement);

const geometry = new THREE.CylinderGeometry(2,2,7,5 );
const material = new THREE.MeshBasicMaterial({color: 0xffff00, wireframe: true});
const cylinder = new THREE.Mesh(geometry, material);

scene.add(cylinder);

function animate() {
    requestAnimationFrame(animate);
    cylinder.rotation.y += 0.01;
    cylinder.rotation.x += 0.01;
    renderer.render(scene, camera);
}

animate();
import './App.css'
import { Canvas } from '@react-three/fiber'
import Box from './Box'

function App() {

  return (
    <>

    <Canvas style={{
      height: '500px',
      width: '700px',
      backgroundColor: '#111'
    }}>
  
    <ambientLight intensity={0.5} />
    <spotLight 
        position={[3, -5, 1]}
        angle={1}
        penumbra={1}
        intensity={300}
        castShadow
        shadow-mapSize={1024}
/>
    <Box/>
    </Canvas>
    
    </>
  )
}

export default App

import React from "react";
import { useFrame } from "@react-three/fiber";

const Box = () => {
    const ref = React.useRef();

    useFrame(() => {
        ref.current.rotation.x += 0.01;
        ref.current.rotation.y += 0.01;
    });

    return (<mesh ref={ref}>
        <boxGeometry args={[3, 3, 3]} />
        <meshStandardMaterial color={'red'} />
    </mesh>);
}

export default Box;
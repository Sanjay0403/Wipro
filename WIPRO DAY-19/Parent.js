import React, {useContext, useState} from 'react'
import ColorContext from './ColorContext'
import Child1 from './Child1';
export default function Parent() {

    const [color, setColor] = useState("red");
    const updateColor = () =>
    {
        setColor("blue");
    }
  return (
    <div>In Parent Component, color is {color}
    <ColorContext.Provider value={{appColor:color, setColor:updateColor}}>
    <Child1/>    
    </ColorContext.Provider>
    </div>
    
  )
}

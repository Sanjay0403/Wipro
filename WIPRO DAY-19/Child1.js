import React, { useCallback, useContext } from 'react'

import ColorContext from './ColorContext'
import GrandChild1 from './GrandChild1';
export default function Child1() {
    const {appColor} = useContext(ColorContext);
    return (
    <>
    <div style={{color:appColor}}>In Child component color recd from parent comp is {appColor} </div>
<GrandChild1/>
</>
)
}

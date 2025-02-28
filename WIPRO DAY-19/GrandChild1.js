import React, { useCallback, useContext } from 'react'
import ColorContext from './ColorContext'
// import { ServerCapabilities } from 'mongodb';
export default function GrandChild1() {
    const {appColor, setColor} =  useContext(ColorContext);
    return (
    <div>
        In GrandChild1 , colorrecd is {appColor}
        <button onClick={setColor}> Update color </button>
    </div>
)
}

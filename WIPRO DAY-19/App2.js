import React, { useReducer, useState, useTransition } from 'react'

const initialState = 100;
const reducer = (state, action)=>
{
    if(action.type=="Add")
         return state+10;
    else if(action.type=="Sub")
        return state-10;
    return state;
}
export default function App2() {
  const [count , setCount] =   useState(0)
  const [state, dispatch]  =  useReducer(reducer, initialState)

  return (
    <div>App2
        <h1> Count is {state} </h1>
         <button onClick={()=> dispatch({type:"Add"})}> Inc </button>
         <button onClick={()=> dispatch({type:"Sub"})}> Dec </button>
    
    </div>
  )
}

import factoryWithThrowingShims from 'prop-types/factoryWithThrowingShims';
import React, { act, useReducer } from 'react'

const initialState="without book";
const reducer = ( state, action)=>
{
    console.log(state, action)
    alert(action.type)
     if(action.type=="buy")
     {
       state = "Book had been purchased, Child has book now";
       return state;
     }
     if(action.type=="borrow")
     {
        state = "Book had been borrowed, Child has book now";
     return state;
     }
        else 
       return state;
}
export default function App3() {
    const [state, father]  =  useReducer(reducer, initialState);
  return (
    <div>
        
        <h1> Child State : {state} </h1>
        <button onClick={()=> father({type:"buy"})}> Buy a book </button>
        <button onClick={()=> father({type:"borrow"})}> Borrow a book </button>

    </div>
  )
}

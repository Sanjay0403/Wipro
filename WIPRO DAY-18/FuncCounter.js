import { useState } from "react"

export const FuncCounter = () => {
    //useState hooks to preserve state value in functional components
    const [count,setcount]=useState(0);
    
    const Increment =() =>{
    setcount(prcount =>prcount+=1);
   // alert(count+1)
    }



    return(
        <div>
        <h1> Count Value: {count}</h1>
        <button onClick={Increment}>Add</button>
        
        </div>
    )
}
export default FuncCounter;
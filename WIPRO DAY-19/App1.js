import { useState }   from 'react';

function App1() {
    const [count , setCount] = useState(0);
    return (
    <div>
        <h1> Count is {count} </h1>
        <button onClick={()=> setCount(count+1)}> Inc </button>
        <button onClick={()=> setCount(count-1)}> Dec </button>
    
    </div>
    )
}

export default App1
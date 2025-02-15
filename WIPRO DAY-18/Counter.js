import {Component} from "react";

export class Counter extends Component{
    constructor(props)
    {
        super(props)
        this.state = {
            count: 0
        };
    }
    count=0;
    Increment = () =>{
        this.setState(
            {count:this.state.count+1}
        )
        
    }

    Decrement = () =>{
        this.setState(
            {count:this.state.count-1}
        )
    }

    render(){
        return(
            <div>
                <h3>{this.state.count}</h3>
                <button onClick={this.Decrement}>Decrement</button>
                <button onClick={this.Increment}>Increment</button>
            </div>
        )
    }
}

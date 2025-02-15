import { Component } from "react";

export class Employee extends Component{
    constructor(props)
    {
        super(props);
    }
    
    render()
    {
        return(
            <div>
                <h1>Employee class component</h1>
                <p>{this.props.name}</p>


            </div>
        )
    }
}

export default Employee;
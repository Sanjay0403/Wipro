import { Component } from "react";

class Greet extends Component
{
    render()
    {
        return(
            <div>
                <h1> Welcome To Class Component</h1>
                <p> Class Component </p>
                <h3> Hello User: {this.props.name}</h3>
            </div>
        )
    }
}

export default Greet;
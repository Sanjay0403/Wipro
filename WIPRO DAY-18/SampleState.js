import React, { Component } from "react";
import off from './sl3.jpg';
import on from './solo.gif';

export class SampleState extends Component {
    constructor(props) {
        super(props);
        this.state = {
            msg: "Welcome to Wipro Team",
            imagename: off
        };
    }

    ButtonChange = () => {
        const newImage = this.state.imagename === off ? on : off;
        this.setState({
            msg: this.state.imagename === off ? "All the Best" : "Welcome to Wipro Team",
            imagename: newImage
        });
    };

    render() {
        return (
            <div>
                <h3>{this.state.msg}</h3>
                <img 
                    src={this.state.imagename}
                    alt="lightimage"
                    style={{ width: "600px", height: "400px" }}
                />
                <button onClick={this.ButtonChange}>Click Here</button>
            </div>
        );
    }
}

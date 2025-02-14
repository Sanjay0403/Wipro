import { Component } from "react";
import Category from "./Category";

class Product extends Component{
    render()
    {
        return(
            <div>
                <h2>Product Details</h2>
                <p>
                    <label>Product name: <b>{this.props.Pname}</b></label>
                </p>
                <Category Cname={this.props.Cname}></Category>
            </div>
        )
    }
}

export default Product;
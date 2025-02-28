import React from 'react'

export default function App4() {
  return (
    <div>App4
        <App5 name="Sanjay" address="Hyderabad"/>
    </div>
  )
}
 export function App5(props) {
  return (
    <div>App5
    <h1> Hello {props.name} </h1>
    <App6 name={props.name} address={props.address}/>
    </div>
  )
}

export function App6(props) {
    return (
      <div>App6
        <h1> Hello & Welcome {props.name}
        <br/>I got your address {props.address} </h1>
      </div>
    )
  }



//import logo from './logo.svg';
import './App.css';
import { Departments, Employees } from './Components';

import Employee from './Employee';
import Greet from './Greet';
import Welcome from './Welcome';
import Product from './Product';
import Category from './Category';


function App() {
  return (
    <div>
    <Welcome></Welcome>
    <Employee name="Sanjay" salary="70000" dname="Developer" mgrname="DIVINE"></Employee>
    <Employees name="Deep" salary="80000"></Employees>
    <Departments depname="Designer" mgrname="SANJAYDEEP"></Departments>
    <Greet name="Sanjaydeep"></Greet>
    <Product Pname="laptop" Cname="Computers"></Product>
    <Category Cname="Electronics"></Category>
    </div>
  );
}

export default App;

import Department from './Department';
import "./Employee.css";
const Employee =({name,salary,dname,mgrname}) =>{
    return (
        <div className='container'>
            <h3> EmployeeDetails</h3>
            <h6>Name: {name}</h6>
            <h6>Salary: {salary}</h6>

            <h5> Department </h5>
            <Department dname={dname} mgrname = {mgrname}></Department>

        </div>
    )
}

export default Employee;
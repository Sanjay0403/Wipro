export const Employees =({name,salary,dname,mgrname}) =>{
    return(
        <div className='container'>

            <h5>EmployeeDetailes</h5>
            <h5>Name: {name}</h5>
            <h5>Salary: {salary}</h5>
        </div>
    )
}
export const Departments = ({depname,mgrname}) =>
{
    return(
        <div>
            <h3>Department Name: {depname}</h3>
            <h3>Manager Name: {mgrname}</h3>

        </div>
    )
}

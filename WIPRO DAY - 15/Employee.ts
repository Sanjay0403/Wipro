interface Employee {
    id?: number;
    name: string;
    dept: string;
}

function getEmployee(emp: Employee) {
    // Use backticks for string interpolation
    return `${emp.id} ${emp.name} ${emp.dept}`;
}

let emp1 = {
    id: 11,
    name: 'Sanjay',
    dept: 'HR'
};
console.log(getEmployee(emp1));

// Object destructuring
function getEmployeeonjdestruc({ name, dept }: Employee) {
    // Use backticks for string interpolation
    return `${name} ${dept}`;
}

let emp2 = {
    name: 'Deep',
    dept: 'Manager'
};
console.log(getEmployeeonjdestruc(emp2));

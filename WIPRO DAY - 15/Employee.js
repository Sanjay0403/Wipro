function getEmployee(emp) {
    // Use backticks for string interpolation
    return "".concat(emp.id, " ").concat(emp.name, " ").concat(emp.dept);
}
var emp1 = {
    id: 11,
    name: 'Sanjay',
    dept: 'HR'
};
console.log(getEmployee(emp1));
// Object destructuring
function getEmployeeonjdestruc(_a) {
    var name = _a.name, dept = _a.dept;
    // Use backticks for string interpolation
    return "".concat(name, " ").concat(dept);
}
var emp2 = {
    name: 'Deep',
    dept: 'Manager'
};
console.log(getEmployeeonjdestruc(emp2));

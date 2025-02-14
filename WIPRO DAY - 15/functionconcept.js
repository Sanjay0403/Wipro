function sum(a, b) {
    return a + b;
}
var res = sum(10, 20);
console.log(res);
//inferring function type
var result = function (a, b) {
    return a + b;
};
var sumval = result(10, 45);
//optional parameter
function prod(x, y) {
    if (x === void 0) { x = 10; }
    if (typeof y !== 'undefined') {
        return x * y;
    }
    return x * x;
}
console.log(prod(20, 30));
console.log(prod(30));
console.log(prod());
//res parameter - .....
function getsumofall() {
    var numbers = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        numbers[_i] = arguments[_i];
    }
    var tot = 0;
    numbers.forEach(function (num) { return tot += num; });
    return tot;
}
console.log(getsumofall(10, 20, 30, 40, 50, 40, 50));

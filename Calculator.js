let num1 = prompt("введіть перше число");
let num2 = prompt("введіть друге число");
let proces = prompt("оберіть арифметичну дію + - * /");
if (proces == "+")
{
    let sum = parseInt(num1) + parseInt(num2);
    alert("result " + sum);
}
else if (proces == "-")
{
    let sum = parseInt(num1) - parseInt(num2);
    alert("result " + sum);
}
else if (proces == "*")
{
    let sum = parseInt(num1) * parseInt(num2);
    alert("result " + sum);
}
else if (proces == "/")
{
    let sum = parseInt(num1) / parseInt(num2);
    alert("result " + sum);
}
else 
{
    alert("введений невірний символ");
}
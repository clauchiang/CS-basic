System.Console.Write("請輸入第一個數字 : ");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("請輸入運算符號");
var oper = System.Console.ReadLine();

System.Console.Write("請輸入第二個數字 : ");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());

switch(oper){
    case "+":
        Console.WriteLine($"{num1} {oper} {num2} = {System.Convert.ToDouble(num1+num2)}") ;
    break;
    case "-":
        Console.WriteLine($"{num1} {oper} {num2} = {System.Convert.ToDouble(num1-num2)}") ;
    break;
    case "*":
        Console.WriteLine($"{num1} {oper} {num2} = {System.Convert.ToDouble(num1*num2)}") ;
    break;
    case "/":
        Console.WriteLine($"{num1} {oper} {num2} = {System.Convert.ToDouble(num1/num2)}") ;
    break;
    default:
        Console.WriteLine("輸入錯誤請重新輸入");
    break;
}

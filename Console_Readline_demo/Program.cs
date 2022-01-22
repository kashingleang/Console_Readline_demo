// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1;
int num2;


//get input from console
Console.Write("Number1: ");
string input1 = Console.ReadLine();
Console.Write("Number2:");
string input2 = Console.ReadLine();


//convert to int
num1 = Convert.ToInt32(input1);
num2 = Convert.ToInt32(input2);

//multiplication
int result = num1 * num2;

//show result
Console.WriteLine($"{num1} X {num2} = {result}");

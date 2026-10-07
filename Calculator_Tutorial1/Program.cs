// Calculator_Tutorial1

int firstNumber = 5;

int secondNumber = 20;

int result = firstNumber + secondNumber;
Console.WriteLine("The addition of both number is {0}", result);

Console.WriteLine("Type in the first number followed by the Enter Key");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the Enter Key");
int fourthNumber = Convert.ToInt32(Console.ReadLine());

// perfom calculation 
int result2 = thirdNumber + fourthNumber;
Console.WriteLine("Adding {0} and {1} of give the answer {2}", firstNumber, secondNumber, result2);


Console.ReadKey();

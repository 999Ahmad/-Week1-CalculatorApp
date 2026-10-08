// Calculator_Tutorial1



CalculatorApp(); // Call the main method of the application

void CalculatorApp() // This is the main method of the application
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Type in the first number, and then press Enter");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type in the second number, and then press Enter");
    secondNumber = Convert.ToInt32(Console.ReadLine());


    

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");



    // convert string to int
    choice = Convert.ToInt32(Console.ReadLine());

    // Use an if statement to perform the requested maths operation
    // and output the result to the console

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {secondNumber} from {firstNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }


   



    Console.ReadKey();     // Wait for a key press before closing the console window


}

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Mix string + int
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// If in a bigger string, the result will be 77 widgets instead of 14
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// To avoid this, use paranteces ()
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");


// Basic Math Operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Literal decimal data - always use at least one decimal (can be both)
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
// !!! Don't output int from decimal or decimal from int calculations


// Casting
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Increment and Decrement values
// ++var -> adds +1 before value returns
// var++ -> returns value and then adds +1

// Fahrenheit to Celsius converter
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * 5m / 9m;

Console.WriteLine("The temperature is " + celsius + " Celsius.");
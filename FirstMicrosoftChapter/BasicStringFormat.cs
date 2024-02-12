Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");


Console.WriteLine("Generating invoices for customer \"Contose Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");


// Verbatim string @
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Unicode Espace characters /u
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Kon'nichiwa

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// \t tab
// \n new line
// \" make " appear
// \\ to create \
// @ verbatim string -> keeps all whitespace formatting and backslash char in a string
// \u + 4 character code -> UNICODE UTF-16



// String interpolation combines multiple values into a single literal string by using a "template"
// and one or more interpolation expressions. An interpolation expression is indicated by an opening
// and closing curly brace symbol { }. You can put any C# expression that returns a value inside the braces.
// The literal string becomes a template when it's prefixed by the $ character

string firstName = "Bob";
string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
string message = $"{greeting} {firstName}!";

Console.WriteLine(message);

// String interpolation + verbatim literal
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// CHALLENGE
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}\n\t\t{russianLocation}\n");

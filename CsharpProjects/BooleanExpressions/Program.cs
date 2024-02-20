// Didn't cover basic booleans here


// Conditional operator "?:" or ternary conditional operator.
// < evaluate this condition > ? <if condition is true, return this value > : <if condition is false, return this value >
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
Console.WriteLine();

// Complete a challenge activity using conditional operators
// Coin Flip Simulation
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
Console.WriteLine();

// Business Rules
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else
        Console.WriteLine("Welcome, Admin user");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access");
    else
        Console.WriteLine("You do not have sufficient privileges.");
}
else Console.WriteLine("You do not have sufficient privileges.");
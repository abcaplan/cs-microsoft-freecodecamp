/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/




/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/




/*
// Role playing game battle challenge
int enemyHP = 10;
int playerHP = 10;
bool attackTurn = true; // player/monster turn to attack the other (true - player, false - enemy)
Random dice = new Random();

do
{
    int attackDamage = dice.Next(1, 11);
    if (attackTurn)
    {
        enemyHP = enemyHP - (int)attackDamage;
        attackTurn = false;
        Console.WriteLine($"Enemy has been damaged and took {attackDamage} damage. Current enemy health is {enemyHP}.");
    }
    else
    {
        playerHP = playerHP - (int)attackDamage;
        attackTurn = true;
        Console.WriteLine($"Player has been injured and took {attackDamage} damage. Current player health is {playerHP}.");
    }
} while (enemyHP > 0 && playerHP > 0);

Console.WriteLine(playerHP > enemyHP ? "Player wins!" : "Enemy wins!");
*/




// User Input
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/




// Code project 1 - write code that validates integer input
/*
string? readResult;
int number = 0;
bool validEntry = false;
Console.WriteLine("Enter an integer value between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (int.TryParse(readResult, out number)) // Put integer value from user into 'number'
    {
        if (number >= 5 && number <= 10)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is outside the valid range, please try again.");
        }
    }
    else
    {
        Console.WriteLine("Your input is not a valid integer, please try again.");
    }
} while (!validEntry);

Console.WriteLine($"Your input value ({number}) has been accepted.");
*/




/*
// Code project 2 - write code that validates string input
string ? readResult;
bool validEntry = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    switch (roleName.ToLower())
    {
        case "administrator":
        case "manager":
        case "user":
            validEntry = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{readResult.Trim().ToLower()}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
    }
} while (!validEntry);
Console.WriteLine($"Your input value ({readResult.Trim().ToLower()}) has been accepted.");
*/




// Code project 3 - Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

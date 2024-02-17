// DND dice roll for heavy weapon that does 1d12 bludgeoning, 1d6 bleeding, 1d4 radiance
Random dice = new Random();

int playerHit = dice.Next(1, 21);

int playerAC = 14; // armor class

if (playerHit > playerAC)
{
    Console.WriteLine("Player is injured!");

    // Calculate weapon damage
    int roll1 = dice.Next(1, 13);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 5);

    // Calculate total damage
    int totalDamage = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice rolls: {roll1} bludgeoning, {roll2} bleeding and {roll3} radiance damage for a total of {totalDamage}.\n");
}
else
{
    Console.WriteLine("Player is unscathed!\n");
}


// Normal dice rolls - Microsoft c-sharp part
int normalRoll1 = dice.Next(1, 7);
int normalRoll2 = dice.Next(1, 7);
int normalRoll3 = dice.Next(1, 7);

int total = normalRoll1 + normalRoll2 + normalRoll3;

Console.WriteLine($"Dice roll: {normalRoll1} + {normalRoll2} + {normalRoll3} = {total}");



if ((normalRoll1 == normalRoll2) || (normalRoll2 == normalRoll3) || (normalRoll1 == normalRoll3))
{
    if ((normalRoll1 == normalRoll2) && (normalRoll2 == normalRoll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine($"You win a new car! Total score: {total}.");
}
else if (total >= 10)
{
    Console.WriteLine($"You win a new laptop! Total score: {total}.");
}
else if (total == 7)
{
    Console.WriteLine($"You win a trip for two! Total score: {total}.");
}
else
{
    Console.WriteLine($"You win a kitten! Total score: {total}.");
}
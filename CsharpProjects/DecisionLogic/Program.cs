// DND dice roll for heavy weapon that does 1d12 bludgeoning, 1d6 bleeding, 1d4 radiance
Random dice = new Random();

int roll1 = dice.Next(1, 13);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 5);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice rolls: {roll1} bludgeoning, {roll2} bleeding and {roll3} radiance damage for a total of {total}.");
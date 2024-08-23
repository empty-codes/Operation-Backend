int round = 1, manticoreHealth = 10, cityHealth = 15, manticoreDistance;

GetManticoreDistance();
Console.Clear();
Console.WriteLine("Player 2, it is your turn");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("_____________________________________________________________________________");
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}  Manticore: {manticoreHealth}");
    Console.WriteLine($"The cannon is expected to deal {getDamage()} this round.");
    Console.Write("Enter desired cannon range: ");
    int range = int.Parse(Console.ReadLine());
    getCannonEffect(range);
    if (manticoreHealth != 0) cityHealth--;
    round++;
}

getWinner();

Console.ReadLine();

int getDamage()
{
    if (round % 3 == 0 && round % 5 == 0) return 10;
    if (round % 3 == 0 || round % 5 == 0) return 3;
    else return 1;
}

void getCannonEffect(int range)
{
    if (range == manticoreDistance)
    {
        manticoreHealth -= getDamage();
        Console.WriteLine("That round was a DIRECT HIT!");
    }
    else if (range > manticoreDistance) Console.WriteLine("That round OVERSHOT the target.");
    else Console.WriteLine("That round FELL SHORT of the target.");
}

int GetManticoreDistance()
{
    while (true)
    {
        Console.Write("Player 1, how far away from the city do you want to station the manticore? ");
        manticoreDistance = int.Parse(Console.ReadLine());
        if (manticoreDistance >= 0 && manticoreDistance <= 100)
            return manticoreDistance;
        else Console.Write("Enter a value between 0 and 100");
    }
}

void getWinner()
{
    if (manticoreHealth <= 0) Console.WriteLine("\n\nThe Manticore has been destroyed! The city of consolas had been saved!");
    if (cityHealth <= 0) Console.WriteLine("\n\nThe city of Consolas had been annihilated!");
}
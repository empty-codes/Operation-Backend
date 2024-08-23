Pack pack1 = new Pack(3, 5, 5);

while (true)
{
    Console.WriteLine("___________________________________________________");
    Console.WriteLine($"Current Contents: {pack1}" +
        $"\nCurrent Items Count: {pack1.CurrentItemCount}/{pack1.MaxItems}" +
                   $"\nCurrent Weight: {pack1.CurrentWeight}/{pack1.MaxWeight}" +
                   $"\nCurrent Volume: {pack1.CurrentVolume}/{pack1.MaxVolume}");
    Console.WriteLine("___________________________________________________");
    Console.WriteLine("Add items to your pack using the menu below:");
    Console.WriteLine("1 for an arrow\n2 for a bow\n3 for rope\n4 for water\n5 for food\n6 for a sword\n7 to Finish");
    Console.WriteLine("___________________________________________________");
    int itemChoice = int.Parse(Console.ReadLine());

    switch (itemChoice)
    {
        case 1:
            if (pack1.Add(new Arrow()) == true) Console.WriteLine($"{new Arrow().ToString()} successfully added");
            else Console.WriteLine("Cannot be added");
            break;
        case 2:
            if (pack1.Add(new Bow()) == true) Console.WriteLine($"{new Bow().ToString()} successfully added");
            else Console.WriteLine("Cannot be added");
            break;
        case 3:
            if (pack1.Add(new Rope()) == true) Console.WriteLine($"{new Rope().ToString()} successfully added");
            else Console.WriteLine("Cannot be added");
            break;
        case 4:
            if (pack1.Add(new Water()) == true) Console.WriteLine($"{new Water().ToString()} successfully added");
            else Console.WriteLine("Cannot be added");
            break;
        case 5:
            if (pack1.Add(new Food()) == true) Console.WriteLine($"{new Food().ToString()} successfully added");
            else Console.WriteLine("Cannot be added");
            break;
        case 6:
            if (pack1.Add(new Sword()) == true) Console.WriteLine($"{new Sword().ToString()} successfully added");
            else Console.WriteLine("Cannot be added");
            break;
        case 7:
            return;
        default:
            Console.WriteLine("Error! Choose using numbers 1 to 6");
            break;
    }
}


public class InventoryItem
{
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(double w, double v)
    {
        Weight = w;
        Volume = v;
    }

    public override string ToString()
    {
        Type type = this.GetType();
        return type.Name;
    }
}
public class Arrow : InventoryItem { public Arrow() : base(0.1, 0.05) { } }
public class Bow : InventoryItem { public Bow() : base(1, 4) { } }
public class Rope : InventoryItem { public Rope() : base(1, 1.5) { } }
public class Water : InventoryItem { public Water() : base(2, 3) { } }
public class Food : InventoryItem { public Food() : base(1, 0.5) { } }
public class Sword : InventoryItem { public Sword() : base(5, 3) { } }

public class Pack
{
    public int MaxItems { get; }
    public double MaxWeight { get; }
    public double MaxVolume { get; }
    private InventoryItem[] items;
    public int CurrentItemCount { get; set; } = 0;
    public double CurrentWeight { get; set; } = 0.00;
    public double CurrentVolume { get; set; } = 0.00;

    public Pack(int n, double maxW, double maxV)
    {
        MaxItems = n;
        MaxWeight = maxW;
        MaxVolume = maxV;

        items = new InventoryItem[MaxItems];
    }
    public bool Add(InventoryItem item)
    {
        if (CurrentItemCount + 1 <= MaxItems && CurrentWeight + item.Weight <= MaxWeight && CurrentVolume + item.Volume <= MaxVolume)
        {
            items[CurrentItemCount] = item;
            CurrentItemCount++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;
            return true;

        }
        else return false;
    }
    public override string ToString()
    {
        string output = null;
        if (CurrentItemCount == 0) return "Nothing.";
        for (int i = 0; i < CurrentItemCount; i++)
        {
            output += $"{items[i].ToString()} ";
        }
        return $"Pack containing: {output}";
    }
}
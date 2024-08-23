// Boss Battle 1 - The Point

Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1.X}, {point1.Y})");
Console.WriteLine($"({point2.X}, {point2.Y})");

// Boss Battle 2 - The Color
Color color1 = new Color(245, 67, 50);
Color color2 = Color.Purple;

Console.WriteLine($"Color 1: ({color1.RedChannel}, {color1.GreenChannel}, {color1.BlueChannel})");
Console.WriteLine($"Color 2: ({color2.RedChannel}, {color2.GreenChannel}, {color2.BlueChannel})");

Console.Clear(); //comment this out to view the results for boss battle 1 and 2 when run

// Boss Battle 3 - The Card
void CreateCards()
{
    foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
    {
        foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
        {
            Card card = new Card(color, rank);
            Console.WriteLine($"The {color} {rank}");
        }
    }
}

CreateCards();

Console.Clear(); // comment this out to view the results for boss battle 3 when run

// Boss Battle 4 - The Locked Door
int SetPasscode()
{
    int passcode;
    Console.WriteLine("You are to set a numeric passcode for the door, it must be a four digit number e.g 1234, 5678.");
    while (true)
    {
        Console.Write("Enter a passcode for the door: ");
        passcode = int.Parse(Console.ReadLine());
        if (passcode >= 1000 && passcode <= 9999) break;
    }
    Console.Clear();
    return passcode;
}

// uncomment this to view the results for boss battle 4 when run

// Door door = new Door(SetPasscode());

/*while (true) 
{
    Console.WriteLine($"The door is {door.State}");
    Console.Write("Choose between 'open', 'close', 'lock', 'unlock', 'change passcode' and 'exit' commands: ");

    switch (Console.ReadLine())
    {
        case "open":
            door.OpenDoor();
            Console.Clear();
            break;
        case "close":
            door.CloseDoor();
            Console.Clear();
            break;
        case "lock":
            door.LockDoor();
            Console.Clear();
            break;
        case "unlock":
            Console.Write("Enter the current passcode: ");
            int unlockPasscode = int.Parse(Console.ReadLine());
            door.UnlockDoor(unlockPasscode);
            Console.Clear();
            break;
        case "change passcode":
            Console.Write("Enter the current passcode: ");
            int currentPasscode = int.Parse(Console.ReadLine());
            door.ChangePasscode(currentPasscode, SetPasscode());
            Console.Clear();
            break;
        case "exit":
            return;
        default:
            Console.WriteLine("Error! You can only choose between the existing commands.");
            Console.Clear();
            break;
    }
} */

//Boss Battle 5 - The Password Validator

while (true)
{
    Console.Write("Enter a password: ");
    string? password = Console.ReadLine();
    if (password == null) break;
    PasswordValidator user = new PasswordValidator(password);
    if (user.isValid()) Console.WriteLine("This password is valid.");
    else Console.WriteLine("This password is not allowed.");
}


// Classes

// Boss Battle 1 - The Point
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Boss Battle 2 - The Color
public class Color
{
    public int RedChannel { get; set; }
    public int GreenChannel { get; set; }
    public int BlueChannel { get; set; }

    public Color()
    {
        RedChannel = 0;
        GreenChannel = 0;
        BlueChannel = 0;
    }

    public Color(int red, int green, int blue)
    {
        RedChannel = red;
        GreenChannel = green;
        BlueChannel = blue;
    }

    public static Color White
    {
        get { return new Color { RedChannel = 255, GreenChannel = 255, BlueChannel = 255 }; }
    }

    public static Color Black
    {
        get { return new Color { RedChannel = 0, GreenChannel = 0, BlueChannel = 0 }; }
    }

    public static Color Red
    {
        get { return new Color { RedChannel = 255, GreenChannel = 0, BlueChannel = 0 }; }
    }

    public static Color Orange
    {
        get { return new Color { RedChannel = 255, GreenChannel = 165, BlueChannel = 0 }; }
    }

    public static Color Yellow
    {
        get { return new Color { RedChannel = 255, GreenChannel = 255, BlueChannel = 0 }; }
    }

    public static Color Green
    {
        get { return new Color { RedChannel = 0, GreenChannel = 128, BlueChannel = 0 }; }
    }

    public static Color Blue
    {
        get { return new Color { RedChannel = 0, GreenChannel = 0, BlueChannel = 255 }; }
    }

    public static Color Purple
    {
        get { return new Color { RedChannel = 128, GreenChannel = 0, BlueChannel = 128 }; }
    }

}

// Boss Battle 3 - The Card
class Card
{
    public CardColor Color { get; }
    public CardRank Rank { get; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public void GetCardType()
    {
        if (Rank == CardRank.Dollar || Rank == CardRank.Percent || Rank == CardRank.Caret || Rank == CardRank.Ampersand)
            Console.WriteLine($"This card is a symbol card ranked {Rank}");
        else Console.WriteLine($"This card is a number card ranked {Rank}");
    }
}

// Boss Battle 4 - The Locked Door
public class Door
{
    public DoorState State { get; private set; } = DoorState.Closed;
    private int Passcode { get; set; }

    public Door(int passcode)
    {
        Passcode = passcode;
    }

    public void CloseDoor()
    {
        if (State == DoorState.Open) State = DoorState.Closed;
    }

    public void LockDoor()
    {
        if (State == DoorState.Closed) State = DoorState.Locked;
    }

    public void OpenDoor()
    {
        if (State == DoorState.Closed) State = DoorState.Open;
    }

    public void UnlockDoor(int currentPasscode)
    {
        if (State == DoorState.Locked && currentPasscode == Passcode) State = DoorState.Closed;
        else
        {
            Console.WriteLine("Incorrect passcode.");
            Console.ReadKey();
        }

    }

    public void ChangePasscode(int currentPasscode, int newPasscode)
    {

        if (currentPasscode == Passcode)
        {
            Passcode = newPasscode;
            Console.WriteLine("Passcode successfully changed.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Incorrect passcode");
            Console.ReadKey();
        }
    }


}

// Boss Battle 5 - The Password Validator
class PasswordValidator
{
    public string Password { get; }

    public PasswordValidator(string password)
    {
        Password = password;
    }

    public bool isValid()
    {
        int countLetters = 0, upperCases = 0, lowerCases = 0, digits = 0;
        bool hasForbiddenchar = false;
        foreach (char letter in Password)
        {
            countLetters++;
            if (char.IsUpper(letter) == true) upperCases++;
            if (char.IsLower(letter) == true) lowerCases++;
            if (char.IsDigit(letter) == true) digits++;
            if (letter.Equals('T') == true || letter.Equals('&') == true) hasForbiddenchar = true;
        }
        if (countLetters >= 6 && countLetters <= 13 && upperCases >= 1 && lowerCases >= 1 && digits >= 1 && hasForbiddenchar == false) return true;
        else return false;
    }
}


// Enumerations

// Boss Battle 3 - The Card
enum CardColor { Red, Green, Blue, Yellow }
enum CardRank { One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }

// Boss Battle 4 - The Locked Door
public enum DoorState { Open, Closed, Locked }




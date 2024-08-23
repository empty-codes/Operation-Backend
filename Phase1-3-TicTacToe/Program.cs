
char? player1_choice = ' ', player2_choice = ' ';
Players player = new Players();
void getPlayer1Choice()
{
    while (true)
    {
        Console.Write("Player 1, choose X or O: ");
        player1_choice = char.Parse(Console.ReadLine());
        if (player1_choice == 'X' || player1_choice == 'O') break;
        else Console.WriteLine("Error!, Enter X or O");
    }

    Console.Clear();
}

getPlayer1Choice();
TicTacToeGame play = new TicTacToeGame(player1_choice);
player2_choice = play.GetPlayer2Choice();
Console.WriteLine($"Player 2, you are {player2_choice}");
Console.ReadKey();
Console.Clear();

play.DisplayBoard();


// runs game in loop until winner determined
while (true)
{
    bool player1State = getPlayer1Square();
    if (getWin()) break;

    bool player2State = getPlayer2Square();
    if (getWin()) break;

    if (!player1State || !player2State)
    {
        Console.WriteLine("The game has ended as a draw!");
        break;

    }

}


bool getWin()
{
    if (play.checkForOWin())
    {
        if (player1_choice == 'O')
        {
            Console.WriteLine("Player 1 has WON!");
        }
        else
        {
            Console.WriteLine("Player 2 has WON!");
        }
        return true;
    }
    if (play.checkForXWin())
    {
        if (player1_choice == 'X')
        {
            Console.WriteLine("Player 1 has WON!");
        }
        else
        {
            Console.WriteLine("Player 2 has WON!");
        }
        return true;
    }
    return false;
}


bool getPlayer1Square()
{
    Console.Write("\n\nPlayer 1, choose the square you want to play in using numbers 1 to 9: ");
    int player1_square;
    while (!int.TryParse(Console.ReadLine(), out player1_square) || player1_square < 1 || player1_square > 9)
    {
        Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
    }
    if (play.UpdateBoard(player1_square, Players.Player1) == false)
    {
        Console.WriteLine("This square is already occupied! Choose another square");
        return getPlayer1Square();
    }
    if (play.IsBoardFull())
    {
        Console.WriteLine("The game has ended in a draw!");
        return false;
    }

    return true;

}

bool getPlayer2Square()
{
    int count2 = 0;
    Console.Write("\n\nPlayer 2, choose the square you want to play in using numbers 1 to 9: ");
    int player2_square;
    while (!int.TryParse(Console.ReadLine(), out player2_square) || player2_square < 1 || player2_square > 9)
    {
        Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
    }
    if (play.UpdateBoard(player2_square, Players.Player2) == false)
    {
        Console.WriteLine("This square is already occupied! Choose another square");
        return getPlayer2Square();
    }
    if (play.IsBoardFull())
    {
        Console.WriteLine("The game has ended in a draw!");
        return false;
    }

    return true;

}

Console.ReadKey();

class TicTacToeGame
{

    public char Player1 { get; }
    public char Player2 { get; private set; }
    public int Player1Square { get; }
    public int Player2Square { get; }
    public Players Player { get; }

    public char[,] Board { get; }

    public TicTacToeGame(char? player1)
    {
        Player1 = (char)player1;

        Board = new char[3, 3]
            {
                { '7', '8', '9' },
                { '4', '5', '6' },
                { '1', '2', '3' }
            };
    }

    public char GetPlayer2Choice()
    {
        switch (Player1)
        {
            case 'X':
                Player2 = 'O';
                break;
            case 'O':
                Player2 = 'X';
                break;
            default:
                Console.WriteLine("Error!, enter X or O");
                break;
        }
        return Player2;
    }

    public void DisplayBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + Board[i, j] + " ");
                if (j < 2)
                    Console.Write("|");
            }
            if (i < 2)
            {
                Console.WriteLine("\n---+---+---");
            }
        }
        Console.WriteLine();
    }

    // checks if square is occupied, if isn't updates, if is doesn't update
    public bool UpdateBoard(int playerSquare, Players Player)
    {
        switch (playerSquare)
        {
            case 1:
                if (Board[2, 0] == Player1 || Board[2, 0] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[2, 0] = Player1;
                    if (Player == Players.Player2) Board[2, 0] = Player2;
                }
                break;
            case 2:
                if (Board[2, 1] == Player1 || Board[2, 1] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[2, 1] = Player1;
                    if (Player == Players.Player2) Board[2, 1] = Player2;
                }
                break;
            case 3:
                if (Board[2, 2] == Player1 || Board[2, 2] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[2, 2] = Player1;
                    if (Player == Players.Player2) Board[2, 2] = Player2;
                }
                break;
            case 4:
                if (Board[1, 0] == Player1 || Board[1, 0] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[1, 0] = Player1;
                    if (Player == Players.Player2) Board[1, 0] = Player2;
                }
                break;
            case 5:
                if (Board[1, 1] == Player1 || Board[1, 1] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[1, 1] = Player1;
                    if (Player == Players.Player2) Board[1, 1] = Player2;
                }
                break;
            case 6:
                if (Board[1, 2] == Player1 || Board[1, 2] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[1, 2] = Player1;
                    if (Player == Players.Player2) Board[1, 2] = Player2;
                }
                break;
            case 7:
                if (Board[0, 0] == Player1 || Board[0, 0] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[0, 0] = Player1;
                    if (Player == Players.Player2) Board[0, 0] = Player2;
                }
                break;
            case 8:
                if (Board[0, 1] == Player1 || Board[0, 1] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[0, 1] = Player1;
                    if (Player == Players.Player2) Board[0, 1] = Player2;
                }
                break;
            case 9:
                if (Board[0, 2] == Player1 || Board[0, 2] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[0, 2] = Player1;
                    if (Player == Players.Player2) Board[0, 2] = Player2;
                }
                break;

        }
        Console.WriteLine("\n");
        DisplayBoard();
        return true;
    }

    public bool checkForXWin()
    {
        if (Board[0, 0] == 'X' && Board[1, 1] == 'X' && Board[2, 2] == 'X') return true;

        if (Board[0, 0] == 'X' && Board[0, 1] == 'X' && Board[0, 2] == 'X') return true;
        if (Board[1, 0] == 'X' && Board[1, 1] == 'X' && Board[1, 2] == 'X') return true;
        if (Board[2, 0] == 'X' && Board[2, 1] == 'X' && Board[2, 2] == 'X') return true;

        if (Board[0, 0] == 'X' && Board[1, 0] == 'X' && Board[2, 0] == 'X') return true;
        if (Board[0, 1] == 'X' && Board[1, 1] == 'X' && Board[2, 1] == 'X') return true;
        if (Board[0, 2] == 'X' && Board[1, 2] == 'X' && Board[2, 2] == 'X') return true;

        else return false;
    }

    public bool checkForOWin()
    {
        if (Board[0, 0] == 'O' && Board[1, 1] == 'O' && Board[2, 2] == 'O') return true;

        if (Board[0, 0] == 'O' && Board[0, 1] == 'O' && Board[0, 2] == 'O') return true;
        if (Board[1, 0] == 'O' && Board[1, 1] == 'O' && Board[1, 2] == 'O') return true;
        if (Board[2, 0] == 'O' && Board[2, 1] == 'O' && Board[2, 2] == 'O') return true;

        if (Board[0, 0] == 'O' && Board[1, 0] == 'O' && Board[2, 0] == 'O') return true;
        if (Board[0, 1] == 'O' && Board[1, 1] == 'O' && Board[2, 1] == 'O') return true;
        if (Board[0, 2] == 'O' && Board[1, 2] == 'O' && Board[2, 2] == 'O') return true;

        else return false;
    }

    public bool IsBoardFull()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (Board[i, j] != Player1 && Board[i, j] != Player2)
                {
                    return false;
                }
            }
        }
        return true;
    }


}

enum Players { Player1, Player2 }


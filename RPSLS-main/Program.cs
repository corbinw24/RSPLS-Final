namespace RPSLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();

            HumanPlayer HumanPlayer = new HumanPlayer("PlayerOne");
            ComputerPlayer Computerplayer = new ComputerPlayer("PlayerTwo");
        }
    } 
}
namespace OOP2
{
    internal class Program
    {
        static void Main()
        {
            BoxGame game1 = new BoxGame();

            Player pl1 = new Player() { Name = "Genadi", Address = "Varna" };
            Player pl2 = new Player() { Name = "Andrei", Address = "Tulbuhin" };

            game1.Player1 = pl1;
            game1.Player2 = pl2;

            //Варианти за създаване на игри
            BoxGame game2 = new BoxGame() { Player1 = pl2, Player2 = pl1 };

            BoxGame game3 = new BoxGame()
            {
                Player1 = new Player()
                { Name = "Asen", Address = "Turgovishte" }
            ,
                Player2 = new Player()
                { Name = "Vasko", Address = "Ruse" }
            };

            game1.GoNextRound(1, 1.8);
            game1.GoNextRound(2, 1.3);
          //  game1.KnockDown(false);

            game1.GoNextRound(1.6, 0.9);
            game1.GoNextRound(2, 1.3);
            game1.GoNextRound(1.6, 0.9);
        }
    }

    public class BoxGame
    {
        private double score1 = 0;
        private double score2 = 0;

        public int Round { get; private set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public double ScoreDifference
        {
            get
            {
                return score1 - score2;
                /*Ako играч 1 е с по голям резултат ще се върне положително число
                 * Ако играч 2 е с по-голям резултат ще се върне отрицателно число
                 * Ако двата играча имат равен резултат ще се върне 0*/
            }
        }
        public void KnockDown(bool Player1IsDown)
        {
            if (Player1IsDown)
            {
                score2 += 10;
                score1 = 0;
            }
            else
            {
                score1 += 10;
                score2 = 0;
            }
            PrintVictory();
            Console.WriteLine("This was knockdown Victory!!!");
        }

        public void GoNextRound(double scoreForPlayer1, double scoreForPlayer2)
        {
            IncreaseScore(true, scoreForPlayer1);
            IncreaseScore(false, scoreForPlayer2);
            Round++;
            Console.WriteLine($"!Round {Round} Fight!");
            if (Round == 5)
            {
                PrintVictory();
            }
        }

        private void PrintVictory()
        {
            Console.WriteLine("Winner is: " + (ScoreDifference > 0 ? $"Player 1 :{Player1.Name}" : $"Player 2 :{Player2.Name}"));
            Console.WriteLine($"Scores of both players are [{score1} : {score2}]");
            Console.WriteLine($"Score Difference is {ScoreDifference}");
            Console.WriteLine($"Final Round was: {Round}");
        }

        private void IncreaseScore(bool forPlayer1, double scorePoints)
        {
            if (scorePoints <= 0)
            {
                Console.WriteLine("Error invalid points");
                return;
            }
            if (forPlayer1)
            {
                score1 += scorePoints;
            }
            else
            {
                score2 += scorePoints;
            }
        }
    }
    public class Player
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
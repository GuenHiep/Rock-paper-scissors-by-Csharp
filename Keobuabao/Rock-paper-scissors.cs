using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keobuabao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            Console.WriteLine("This is Rock-paper-scissors game.");
            Console.WriteLine("Please choose : ");
            Console.WriteLine("1 is Rock.");
            Console.WriteLine("2 is Scissors");
            Console.WriteLine("3 la Paper");
            Console.Write("You choose number : ");


            int computer = rnd.Next(1, 3);
            int player = Int32.Parse(Console.ReadLine());

            String bot = computer.ToString();
            String P = player.ToString();



            //Computer
            if (computer == 1)
            {
                bot = "Rock";
            }
            else if (computer == 2)
            {
                bot = "Scissors";
            }
            else if (computer == 3)
            {
                bot = "Paper";
            }

            //Player
            if (player == 1)
            {
                P = "Rock";
            }
            else if (player == 2)
            {
                P = "Scissors";
            }
            else if (player == 3)
            {
                P = "Paper";
            }

            Console.WriteLine("Player choose : " + P);
            Console.WriteLine("Computer choose : " + bot);

            //rules
            if (P == "Rock" & bot == "Scissors")
            {
                Console.WriteLine("Player win !");
            }
            else if (P == "Scissors" & bot == "Paper")
            {
                Console.WriteLine("Player win !");
            }
            else if (P == "Paper" & bot == "Rock")
            {

                Console.WriteLine("Player win !");

            }
            else if (P == bot)
            {
                Console.WriteLine(" Draw ! ");
            }
            else
            {
                Console.WriteLine("Computer win ! ");
            }
        }
    }
}

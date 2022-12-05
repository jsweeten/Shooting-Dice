using System;

namespace ShootingDice
{
    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Pick a number");
            int myNumber = int.Parse(Console.ReadLine());
            return myNumber;
        }
        public HumanPlayer()
        {

        }
    }
}
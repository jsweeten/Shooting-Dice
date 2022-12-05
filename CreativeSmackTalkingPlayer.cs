using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private static List<string> _taunts = new List<string>()
        {
            "I'm not sure what I'm supposed to say.",
            "You mother was a hamster",
            "Your father smells of elderberry"
        };

        public string insult = _taunts[new Random().Next(_taunts.Count)];

        public override int Roll()
        {
            Console.WriteLine(insult);
            return base.Roll();
        }
        public CreativeSmackTalkingPlayer()
        {

        }
    }
}
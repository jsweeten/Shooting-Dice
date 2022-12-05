using System;

namespace ShootingDice
{
    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

            base.Play(other);
        }

        public OneHigherPlayer()
        {
            
        }
    }
}

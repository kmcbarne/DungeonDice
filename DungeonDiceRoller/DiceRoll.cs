using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDiceRoller
{
    public class DiceRoll
    {
        public void InitializeDice(int seed)
        {
            DateTime current = new DateTime(1000);
            current = DateTime.Now;
            seed += (int)(current.Millisecond);
            Random results = new Random(seed);            
        }

        public int[] RollDice(int sides, int rolls)
        {
            Random dieRoll = new Random((int)DateTime.Now.Millisecond);

            int[] results = new int[rolls];

            for(int i = 0; i < rolls; i++)
            {
                results[i] = dieRoll.Next(1, sides);                
            }

            return results;
        }
    }
}

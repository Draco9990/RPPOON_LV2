using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    class FlexibleDiceRoller : IDiceRollerFlexible, IDiceRollerClosed
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public void RemoveDiceConditional(int numb)
        {
            for(int i = 0; i < dice.Count; i++)
            {
                if(resultForEachRoll[i] == numb)
                {
                    dice.RemoveAt(i);
                    resultForEachRoll.RemoveAt(i);
                    i--;
                }
            }
        }

    }
}

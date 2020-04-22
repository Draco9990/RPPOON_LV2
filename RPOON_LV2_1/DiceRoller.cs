using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> lastRollResults;
        //Zadatak 4
        //private ILogger logger;

        public DiceRoller()
        {
            dice = new List<Die>();
            lastRollResults = new List<int>();
            //Zadatak 4
            //logger = new ConsoleLogger();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        
        public void RollAllDice()
        {
            lastRollResults = new List<int>();
            foreach(Die d in dice)
            {
                lastRollResults.Add(d.Roll());
            }
        }

        public List<int> GetRollingResults()
        {
            return lastRollResults;
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }

        //Zadatak 4
        /*public void LogRollingResults()
        {
            foreach (int result in lastRollResults)
            {
                logger.Log(result.ToString());
            }
        }
        
        public void SetLogger(ILogger loggerIn)
        {
            logger = loggerIn;
        }*/

        string ILogable.GetStringRepresentation()
        {
            string toReturn = "";
            foreach(int i in lastRollResults)
            {
                toReturn += (i.ToString() + " ");
            }
            return toReturn;
        }
    }
}

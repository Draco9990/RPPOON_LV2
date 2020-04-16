using System;

namespace RPOON_LV2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Zadatak1();

            Console.WriteLine();

            Zadatak2();

            Console.WriteLine();
            */
        }

        /*public static void Zadatak1()
        {
            DiceRoller diceRoller1 = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                diceRoller1.InsertDie(new Die(6));
            }
            diceRoller1.RollAllDice();
            Console.WriteLine("Rezultati bacanja kockica zadatka 1: ");
            foreach (int i in diceRoller1.GetRollingResults())
            {
                Console.WriteLine(i);
            }
        }*/

        /*public static void Zadatak2()
        {
            Random random = Random.GetInstance();
            DiceRoller diceRoller2 = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                diceRoller2.InsertDie(new Die(6, random));
            }
            diceRoller2.RollAllDice();
            Console.WriteLine("Rezultati bacanja kockica zadatka 2: ");
            foreach (int i in diceRoller2.GetRollingResults())
            {
                Console.WriteLine(i);
            }
        }*/
    }
}

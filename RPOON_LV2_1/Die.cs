using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    class Die
    {
        private int numberOfSides;
        //Zadatak 1
        //private Random randomGenerator;
        private RandomGenerator randomGenerator;
        private int result;

        public Die(int numberOfSidesIn)
        {
            numberOfSides = numberOfSidesIn;
            randomGenerator = RandomGenerator.GetInstance();
            Roll();
        }

        public Die(int numberOfSidesIn, RandomGenerator randomGeneratorIn)
        {
            numberOfSides = numberOfSidesIn;
            randomGenerator = randomGeneratorIn;
            Roll();
        }

        //Spremamo rezultat za kasnije te ga šaljemo nazad kroz funkciju za brži pristup
        public int Roll()
        {
            result = randomGenerator.NextInt(1, numberOfSides + 1);
            return result;
        }
    }
}

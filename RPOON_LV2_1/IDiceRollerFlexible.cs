using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    interface IDiceRollerFlexible
    {
        void InsertDie(Die die);
        void RemoveAllDice();
        void RollAllDice();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFCM
{
    class PRace
    {
        string name;
        int STR, DEX, CON, INT, WIS, CHA; //racial bonuses
        int size; //1-Fine, 2-Diminutive, 3-Tiny, 4-Small, 5-Medium, 6-Large, 7-Huge, 8-Gargantuan, 9-Colossal
        List<PAbilities> raceAbil;
    }
}

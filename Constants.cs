using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFCM
{
    public enum BONUS_TYPES : byte { ALCHEMY=0, ARMOR, BASE, CIRCUM, COMP, DEFLECT, DODGE, ENHANCE, 
                                        INHERENT, INSIGHT, LUCK, MORALE, NATARM, PROF, RACE, 
                                        RESIST, SACRED, SHIELD, SIZE, TRAIT, UNTYPED };
    public enum ABILITY_SCORES : byte { STR = 0, DEX, CON, INT, WIS, CHA };
    public enum ALIGNMENT : byte { LAWFUL_GOOD = 0, NEUTRAL_GOOD, CHAOTIC_GOOD,
                                        LAWFUL_NEUTRAL, NEUTRAL_NEUTRAL, CHAOTIC_NEUTRAL,
                                        LAWFUL_EVIL, NEUTRAL_EVIL, CHAOTIC_EVIL};

}

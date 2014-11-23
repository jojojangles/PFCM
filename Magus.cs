using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFCM
{
    class Magus : Archetype
    {
        int arcanePoolMax;

        public Magus(int level)
        {
            classLevel = level;
            hitDie = 8;
            skillRanks = 2;
            babfraction = .75f;
            saves = new Tuple<bool, bool, bool>(true, false, true);
            special = new HashSet<PAbilities>();
            castType = CASTER_TYPE.PREPARED_ARCANE;
        }
    }
}
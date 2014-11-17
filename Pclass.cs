using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFCM
{

    class PClass
    {
        string name;
        List<ALIGNMENT> allowedAlignments;
        int hitDie;
        List<PSkill> classSkills;
        int skillRanks;
        int babcount;
        Tuple<int,int,int> bab;
        Tuple<int,int,int> saves; //<fort,ref,will>
        int[] spellsPerDay;
        List<PAbilities> special;
    }
}

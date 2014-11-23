using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFCM
{

    class Archetype
    {
        string name;
        List<ALIGNMENT> allowedAlignments;
        int classLevel;
        int hitDie;
        List<PSkill> classSkills;
        int skillRanks;
        float babfraction;
        Tuple<bool, bool, bool> saves; //<fort,ref,will>
        HashSet<PAbilities> special;

        //Magic System Components
        PSpellGrowth spellProgression;
        PSpellList spellList;
        CASTER_TYPE castType;

        private int calcSave(bool good)
        {
            return good ? 2 + level / 2 : level / 3;
        }

        public int BAB
        {
            get
            {
                return (int)Math.Floor(babfraction * classLevel);
            }
        }

        public int skillPoints
        {
            get
            { return skillRanks * classLevel; }
        }

        public int fort
        {
            get { return calcSave(saves.Item1); }
        }

        public int refl
        {
            get { return calcSave(saves.Item2); }
        }

        public int will
        {
            get { return calcSave(saves.Item3); }
        }

        public int level
        {
            get { return classLevel; }
            set { classLevel = value; }
        }

        public List<int> spellCount
        {
            get { return spellProgression.get(classLevel); }
        }
    }
}


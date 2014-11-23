using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFCM
{

    class Archetype
    {
        protected string name;
        protected List<ALIGNMENT> allowedAlignments;
        protected int classLevel;
        protected int hitDie;
        protected List<PSkill> classSkills;
        protected int skillRanks;
        protected float babfraction;
        protected Tuple<bool, bool, bool> saves; //<fort,ref,will>
        protected HashSet<PAbilities> special;

        //Magic System Components
        protected PSpellGrowth spellProgression;
        protected PSpellList spellList;
        protected CASTER_TYPE castType;

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


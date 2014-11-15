using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFCM
{
    class AbilityScores
    {
        //Defines a set of ability scores (STR/DEX/CON/INT/WIS/CHA)
        //and provides a mechanism for adding, subtracting, and stacking bonuses
        private struct scores
        {
            private int[] values;
            private BONUS_TYPES b_type;
            private bool temp;
            public scores(int str, int dex, int con, int intl, int wis, int cha, BONUS_TYPES bonus_type, bool temporary)
            {
                values = new int[6];
                values[(int)ABILITY_SCORES.STR] = str;
                values[(int)ABILITY_SCORES.DEX] = dex;
                values[(int)ABILITY_SCORES.CON] = con;
                values[(int)ABILITY_SCORES.INT] = intl;
                values[(int)ABILITY_SCORES.WIS] = wis;
                values[(int)ABILITY_SCORES.CHA] = cha;
                b_type = bonus_type;
                temp = temporary;
            }

            public int getAttrib(ABILITY_SCORES attrib) 
            {
                return values[(int)attrib];
            }

            public void setAttrib(ABILITY_SCORES attrib, int val)
            {
                values[(int)attrib] = val;
            }

            //does not check types
            public scores(scores A, scores B)
            {
                values = new int[6];
                values[(int)ABILITY_SCORES.STR] = A.strength + B.strength;
                values[(int)ABILITY_SCORES.DEX] = A.dexterity + B.dexterity;
                values[(int)ABILITY_SCORES.CON] = A.constitution + B.constitution;
                values[(int)ABILITY_SCORES.INT] = A.intelligence + B.intelligence;
                values[(int)ABILITY_SCORES.WIS] = A.wisdom + B.wisdom;
                values[(int)ABILITY_SCORES.CHA] = A.charisma + B.wisdom;
                b_type = A.type == B.type ? A.type : BONUS_TYPES.UNTYPED;
                temp = A.temp || B.temp;
            }

            public int strength
            {
                get { return values[(int)ABILITY_SCORES.STR]; }
            }
            public int dexterity
            {
                get { return values[(int)ABILITY_SCORES.DEX]; }
            }
            public int constitution
            {
                get { return values[(int)ABILITY_SCORES.CON]; }
            }
            public int intelligence
            {
                get { return values[(int)ABILITY_SCORES.INT]; }
            }
            public int wisdom
            {
                get { return values[(int)ABILITY_SCORES.WIS]; }
            }
            public int charisma
            {
                get { return values[(int)ABILITY_SCORES.CHA]; }
            }
            public BONUS_TYPES type
            {
                get { return b_type; }
            }
            public bool temporary_bonus {
                get { return temp; } 
            }
        }

        HashSet<scores> all_scores;
        scores base_scores;
        scores permanent;
        scores current;
        bool recalculate_all;
        bool recalculate_temp;

        public AbilityScores()
        {
            configure(10, 10, 10, 10, 10, 10);
        }

        public AbilityScores(int str, int dex, int con, int intl, int wis, int cha)
        {
            configure(str, dex, con, intl, wis, cha);
        }
        
        private void configure(int str, int dex, int con, int intl, int wis, int cha)
        {
            all_scores = new HashSet<scores>();
            base_scores = new scores(str, dex, con, intl, wis, cha, BONUS_TYPES.BASE, false);
            calcScores(false);
            calcScores(true);
            recalculate_temp = false;
            recalculate_all = false;
        }

        //point buy helpers
        static private int calcCost(int stat)
        {
            int val = 0;
            bool neg = false;
            if (stat < 10)
            {
                neg = true;
            }

            while (stat != 10)
            {
                val += calcVal(stat, neg);
                stat += neg ? 1 : -1;
            }
            return val;
        }

        static private int calcVal(int stat, bool neg)
        {
            int step = ((stat < 10 ? stat - 1 : stat) - 10) / 2;
            return neg ? (step < 0 ? step : -1) : (step > 0 ? step : 1);
        }

        static public int calcDiff(int old, int curr)
        {
            int old_v = calcCost(old);
            int curr_v = calcCost(curr);
            return curr_v - old_v;
        }

        private void calcScores(bool include_temp)
        {
            int str = 0, dex = 0, con = 0, intl = 0, wis = 0, cha = 0;
            scores summation = new scores(0, 0, 0, 0, 0, 0, BONUS_TYPES.UNTYPED, true);
            foreach (BONUS_TYPES t in Enum.GetValues(typeof(BONUS_TYPES)))
            {
                //note: circumstance bonuses from the same source don't stack, so extend this sometime
                bool stack = t == BONUS_TYPES.UNTYPED || t == BONUS_TYPES.DODGE || t == BONUS_TYPES.CIRCUM;

                foreach (scores s in all_scores)
                {
                    if (s.type == t && (include_temp || !s.temporary_bonus))
                    {
                        str = stack ? str + s.strength : s.strength > str ? s.strength : str;
                        dex = stack ? dex + s.dexterity : s.dexterity > dex ? s.dexterity : dex;
                        con = stack ? con + s.constitution : s.constitution > con ? s.constitution : con;
                        intl = stack ? intl + s.intelligence : s.intelligence > intl ? s.intelligence : intl;
                        wis = stack ? wis + s.wisdom : s.wisdom > wis ? s.wisdom : wis;
                        cha = stack ? cha + s.charisma : s.charisma > cha ? s.charisma : cha;
                    }
                }
                summation = new scores(summation.strength + str, summation.dexterity + dex, summation.constitution + con,
                                       summation.intelligence + intl, summation.wisdom + wis, summation.charisma + cha,
                                       BONUS_TYPES.UNTYPED, include_temp);
            }
            if (include_temp)
            {
                current = new scores(base_scores, summation);
            }
            else
            {
                permanent = new scores(base_scores, summation);
            }
        }

        public void addModifier(int str, int dex, int con, int intl, int wis, int cha, BONUS_TYPES bonus_type, bool temporary) 
        {
            scores next = new scores(str, dex, con, intl, wis, cha, bonus_type, temporary);
            //if the permanent variables change, update everything
            if (!temporary) { recalculate_all = true; };
            //but always update the current status, anyway
            recalculate_temp = true;
        }

        public void clear()
        {
            all_scores.Clear();
            recalculate_all = true;
            recalculate_temp = true;
        }

        public int getBase(ABILITY_SCORES attrib)
        {
            return base_scores.getAttrib(attrib);
        }

        public int getPermanent(ABILITY_SCORES attrib)
        {
            if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
            return permanent.getAttrib(attrib);
        }

        public int getCurrent(ABILITY_SCORES attrib)
        {
            if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
            return current.getAttrib(attrib);
        }

        public void setBase(ABILITY_SCORES attrib, int val)
        {
            base_scores.setAttrib(attrib, val);
            recalculate_all = true;
            recalculate_temp = true;
        }

        public int STR
        {
            get
            {
                if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
                return current.strength;
            }
        }
        public int STR_perm
        {
            get
            {
                if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
                return permanent.strength;
            }
        }
        public int DEX
        {
            get
            {
                if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
                return current.dexterity;
            }
        }
        public int DEX_perm
        {
            get
            {
                if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
                return permanent.dexterity;
            }
        }
        public int CON
        {
            get
            {
                if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
                return current.constitution;
            }
        }
        public int CON_perm
        {
            get
            {
                if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
                return permanent.constitution;
            }
        }
        public int INT
        {
            get
            {
                if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
                return current.intelligence;
            }
        }
        public int INT_perm
        {
            get
            {
                if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
                return permanent.intelligence;
            }
        }
        public int WIS
        {
            get
            {
                if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
                return current.wisdom;
            }
        }
        public int WIS_perm
        {
            get
            {
                if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
                return permanent.wisdom;
            }
        }
        public int CHA
        {
            get
            {
                if (recalculate_temp || recalculate_all) { calcScores(true); recalculate_temp = false; }
                return current.charisma;
            }
        }
        public int CHA_perm
        {
            get
            {
                if (recalculate_all) { calcScores(false); calcScores(true); recalculate_temp = false; recalculate_all = false; }
                return permanent.charisma;
            }

        }
        public int STR_base
        {
            get { return base_scores.strength; }
            set { base_scores = new scores(base_scores, new scores(value, 0, 0, 0, 0, 0, BONUS_TYPES.BASE, false)); recalculate_all = true; recalculate_temp = true; }
        }
        public int DEX_base
        {
            get { return base_scores.dexterity; }
            set { base_scores = new scores(base_scores, new scores(0, value, 0, 0, 0, 0, BONUS_TYPES.BASE, false)); recalculate_all = true; recalculate_temp = true; }
        }
        public int CON_base
        {
            get { return base_scores.constitution; }
            set { base_scores = new scores(base_scores, new scores(0, 0, value, 0, 0, 0, BONUS_TYPES.BASE, false)); recalculate_all = true; recalculate_temp = true; }
        }
        public int INT_base
        {
            get { return base_scores.intelligence; }
            set { base_scores = new scores(base_scores, new scores(0, 0, 0, value, 0, 0, BONUS_TYPES.BASE, false)); recalculate_all = true; recalculate_temp = true; }
        }
        public int WIS_base
        {
            get { return base_scores.wisdom; }
            set { base_scores = new scores(base_scores, new scores(0, 0, 0, 0, value, 0, BONUS_TYPES.BASE, false)); recalculate_all = true; recalculate_temp = true; }
        }
        public int CHA_base
        {
            get { return base_scores.charisma; }
            set { base_scores = new scores(base_scores, new scores(0, 0, 0, 0, 0, value, BONUS_TYPES.BASE, false)); recalculate_all = true; recalculate_temp = true; }
        }
    }
}

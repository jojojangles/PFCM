using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFCM
{
    class Player
    {
        List<Tuple<Pclass, int>> myClasses; //List of <class object,level>
        List<Tuple<Pskill, int>> mySkills; //List of <skill object,total>
        Prace myRace; //Player race object
        int STR, DEX, CON, INT, WIS, CHA; //Ability scores
        int STRb, DEXb, CONb, INTb, WISb, CHAb; //Ability score bonuses
        Dictionary<Pbody,Pgear> myEquipped; //List of <body part object,gear object>
        List<Tuple<Pgear, int>> myBackpack; //List of <gear object,qty>
        int AC, armor, shield, deflection, size, natarmor, miscAC, touchAC, flatfootAC, baseAC;
        int initiative, initMisc;
        int totalHP, damresist, wounds, nonlethal;
        List<Pgear> myWeapons; //specifically, what attacks can this character make
        List<Pspell> mySpellbook; //strictly spell-caster spells
        List<Pabilities> myAbilities; //all spell-likes or extra combat-affecting or skill boosting abilities
        List<Pfeats> myFeats; //all feats, including activatables (which should appear in abilities as well)

        public Player()
        {
            myRace = new Prace();
            baseAC = 10;
            STR = 10;
            DEX = 10;
            CON = 10;
            INT = 10;
            WIS = 10;
            CHA = 10;
            myClasses = new List<Tuple<Pclass,int>>();
            mySkills = new List<Tuple<Pskill, int>>();
            myEquipped = new Dictionary<Pbody, Pgear>();
            myBackpack = new List<Tuple<Pgear, int>>();
            myWeapons = new List<Pgear>();
            mySpellbook = new List<Pspell>();
            myAbilities = new List<Pabilities>();
            myFeats = new List<Pfeats>();
        }
    }
}

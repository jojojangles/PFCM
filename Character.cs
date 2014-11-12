using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFCM
{
    class Player
    {
        List<Tuple<Pskill, int>> myClasses; //List of <class object,level>
        List<Tuple<Pskill, int>> mySkills; //List of <skill object,total>
        Prace myRace; //Player race object
        int STR,DEX,CON,INT,WIS,CHA; //Ability scores
        Dictionary<Pbody,Pgear> myEquipped; //List of <body part object,gear object>
        List<Tuple<Pgear, int>> myBackpack; //List of <gear object,qty>
        int AC, armor, shield, deflection, size, natarmor, miscAC, touchAC, flatfootAC;
        int initiative, initMisc;
        int totalHP, damresist, wounds, nonlethal;
        List<Pgear> weapons; //specifically, what attacks can this character make
        List<Pspell> mySpellbook; //strictly spell-caster spells
        List<Pabilities> myAbilities; //all spell-likes or extra combat-affecting or skill boosting abilities
        List<Pfeats> myFeats; //all feats, including activatables (which should appear in abilities as well)

        
        static void Main(string[] args)
        {
        }
    }
}

﻿using System;
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
        int STR,DEX,CON,INT,WIS,CHA; //Ability scores
        Dictionary<Pbody,Pgear> myEquipped; //List of <body part object,gear object>
        List<Tuple<Pgear, int>> myBackpack; //List of <gear object,qty>

        

        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFCM
{
    class PFCM
    {
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

        static private int calcDiff(int old, int curr)
        {
            int old_v = calcCost(old);
            int curr_v = calcCost(curr);
            return curr_v - old_v;
        }

        static private AbilityScores pointBuy(int starting_points) 
        {
            AbilityScores initial = new AbilityScores();
            System.Console.WriteLine("Create a character by specifying their attributes.");
            int target = 0;
            while (starting_points != 0)
            {
                if (target == 0)
                {
                    System.Console.WriteLine("Point Buy:\nRemaining Points: " + starting_points);
                    System.Console.WriteLine("STR: " + initial.STR + " DEX : " + initial.DEX + " CON : " + initial.CON);
                    System.Console.WriteLine("INT: " + initial.INT + " WIS : " + initial.WIS + " CHA : " + initial.CHA);
                    System.Console.WriteLine("Use 1 - 6 to select a stat.");
                    String test = System.Console.ReadLine();
                    while (test.Length > 1) { System.Console.WriteLine("Input is too long."); test = System.Console.ReadLine(); }
                    int selector = 0;
                    try
                    {
                        selector = Convert.ToInt32(test);
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine("Whatever you did, don't do that! Pick a number from 1 to 6.");
                    }
                    finally
                    {
                        if (selector > 0)
                        {
                            target = selector;
                            //try succeeded
                            switch (selector)
                            {
                                case 1:
                                    //STR
                                    System.Console.WriteLine(initial.STR_base + " is the current value, for a cost of " + calcCost(initial.STR_base)
                                                             + ". Type + to increase, - to decrease, or any number to set directly.");
                                    break;
                                case 2:
                                    //DEX
                                    System.Console.WriteLine(initial.DEX_base + " is the current value, for a cost of " + calcCost(initial.DEX_base)
                                                             + ". Type + to increase, - to decrease, or any number to set directly.");
                                    break;
                                case 3:
                                    //CON
                                    System.Console.WriteLine(initial.CON_base + " is the current value, for a cost of " + calcCost(initial.CON_base)
                                                             + ". Type + to increase, - to decrease, or any number to set directly.");
                                    break;
                                case 4:
                                    //INT
                                    System.Console.WriteLine(initial.INT_base + " is the current value, for a cost of " + calcCost(initial.INT_base)
                                                             + ". Type + to increase, - to decrease, or any number to set directly.");
                                    break;
                                case 5:
                                    //WIS
                                    System.Console.WriteLine(initial.WIS_base + " is the current value, for a cost of " + calcCost(initial.WIS_base)
                                                             + ". Type + to increase, - to decrease, or any number to set directly.");
                                    break;
                                case 6:
                                    //CHA
                                    System.Console.WriteLine(initial.CHA_base + " is the current value, for a cost of " + calcCost(initial.CHA_base)
                                                             + ". Type + to increase, - to decrease, or any number to set directly.");
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid integer. 1 to 6.");
                                    target = 0;
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    string not_enough = "You don't have enough points to make this change.";
                    string minimum = "You may not reduce the value of any ability score below seven.";
                    string test = System.Console.ReadLine();
                    if (test.Length == 1 && test.ElementAt(0) == '+')
                    {
                        //increment
                        int init_val = initial.getBase((ABILITY_SCORES)(target - 1));
                        int change = calcDiff(init_val, init_val + 1);
                        if (starting_points - change >= 0)
                        {
                            //valid change
                            starting_points -= change;
                            initial.setBase((ABILITY_SCORES)(target - 1), init_val + 1);
                        }
                        else
                        {
                            System.Console.WriteLine(not_enough);
                        }
                        target = 0;
                        continue;
                    }
                    if (test.Length == 1 && test.ElementAt(0) == '-')
                    {
                        //decrement
                        int init_val = initial.getBase((ABILITY_SCORES)(target - 1));
                        int change = calcDiff(init_val, init_val - 1);
                        if (init_val > 7)
                        {
                            //valid change
                            starting_points -= change;
                            initial.setBase((ABILITY_SCORES)(target - 1), init_val - 1);
                        }
                        else
                        {
                            System.Console.WriteLine(minimum);
                        }
                        target = 0;
                        continue;
                    }
                    //let user try to set value here
                }
            }
            return initial;
        }
        static void Main(string[] args)
        {
            HashSet<Player> characters = new HashSet<Player>();
            Player current = new Player();
            System.Console.WriteLine("Welcome to PFCM");
            //store magic number somewhere
            AbilityScores scores = pointBuy(20);

        }
    }
}

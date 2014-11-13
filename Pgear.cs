using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFCM
{
    class PGear
    {
        string name; //name of item
        Boolean usable; //is it activateble?
        int charges; //only needed if usable, -1 if NA
        Boolean equipable; //is it worn?
        Boolean improvisedWep; //can it be used to attack?
        PBody slot; //what slot is the object worn on? set to Inventory if NA
        int value; //using gold as unit

        //need to pair with an "affector" system, so that objects can affect Character?
    }
}

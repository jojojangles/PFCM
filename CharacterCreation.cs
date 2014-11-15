using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFCM
{
    public partial class CharacterCreation : Form
    {
        int points;
        AbilityScores scores;

        private void updatePoints() 
        {
            PointsLeft.Text = "Point Buy : " + points + " pts remaining.";
        }

        public CharacterCreation()
        {
            InitializeComponent();
            //allow point buy method choice
            points = 20;
            scores = new AbilityScores(10, 10, 10, 10, 10, 10);
            updatePoints();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Discard Character?", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.Yes)) 
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Strength_ValueChanged(object sender, EventArgs e)
        {
            int change = AbilityScores.calcDiff(scores.STR_base, (int)Strength.Value);
            if (points - change >= 0)
            {
                //valid
                scores.setBase(ABILITY_SCORES.STR, (int)Strength.Value);
                points -= change;
                updatePoints();
            }
            else
            {
                Strength.Value = scores.STR_base;
            }
        }

        private void Dexterity_ValueChanged(object sender, EventArgs e)
        {
            int change = AbilityScores.calcDiff(scores.DEX_base, (int)Dexterity.Value);
            if (points - change >= 0)
            {
                //valid
                scores.setBase(ABILITY_SCORES.DEX, (int)Dexterity.Value);
                points -= change;
                updatePoints();
            }
            else
            {
                Dexterity.Value = scores.DEX_base;
            }
        }

        private void Constitution_ValueChanged(object sender, EventArgs e)
        {
            int change = AbilityScores.calcDiff(scores.CON_base, (int)Constitution.Value);
            if (points - change >= 0)
            {
                //valid
                scores.setBase(ABILITY_SCORES.CON, (int)Constitution.Value);
                points -= change;
                updatePoints();
            }
            else
            {
                Constitution.Value = scores.CON_base;
            }
        }

        private void Intelligence_ValueChanged(object sender, EventArgs e)
        {
            int change = AbilityScores.calcDiff(scores.INT_base, (int)Intelligence.Value);
            if (points - change >= 0)
            {
                //valid
                scores.setBase(ABILITY_SCORES.INT, (int)Intelligence.Value);
                points -= change;
                updatePoints();
            }
            else
            {
                Intelligence.Value = scores.INT_base;
            }
        }

        private void Wisdom_ValueChanged(object sender, EventArgs e)
        {
            int change = AbilityScores.calcDiff(scores.WIS_base, (int)Wisdom.Value);
            if (points - change >= 0)
            {
                //valid
                scores.setBase(ABILITY_SCORES.WIS, (int)Wisdom.Value);
                points -= change;
                updatePoints();
            }
            else
            {
                Wisdom.Value = scores.WIS_base;
            }
        }

        private void Charisma_ValueChanged(object sender, EventArgs e)
        {
            int change = AbilityScores.calcDiff(scores.CHA_base, (int)Charisma.Value);
            if (points - change >= 0)
            {
                //valid
                scores.setBase(ABILITY_SCORES.CHA, (int)Charisma.Value);
                points -= change;
                updatePoints();
            }
            else
            {
                Charisma.Value = scores.CHA_base;
            }
        }
    }
}

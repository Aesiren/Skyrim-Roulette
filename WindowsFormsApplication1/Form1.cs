using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create each component of the character
            string Race;
            string Faction;
            string Playstyle;
            string Description;
            string Character;
            Random x = new Random();
            int y;

            string[] Race_Num = new string[10] { "Breton", "Bosmer", "Redguard", "Argonian", "Orc", "Altmer", "Khajit", "Imperial", "Nord", "Dunmer" };

            string[] Fact_Num = new string[10] { "Companions", "Mage's College", "Dark Brotherhood", "Thieves Guild", "Dawnguard", "Vampire", "Blade", "Imperial Army", "Stormcloak", "Bard's College" };

            string[] Play_Num = new string[10] { "Wizard", "Knght", "Ranger", "Barbarian", "Spellsword", "Shaman", "Necromancer", "Assassin", "Paladin", "Bard" };

            string[] PNDesc = new string[10] { "Destruction, Restoriation, and Alteration. Can't use armor. Enchanting focus", "Heavy Armor, One-Handed, and Blocking or Two-Handed and Archery. Can't use magiv. Smithing focus.", "Light armor, One-Handed, and Archery. Can't use heavy armor. Alchemy focus.", "Two-Handed or Dual Wielding, Light Armor, and Archery. Can't use magiv or heavy armor. Alchemy focus.", "Conuration, One-Handed or Two-Handed, and Destruction. Can't use non-conjured weapons. Enchanting focus.", "Restoration, One-Handed, and Destruction. Can't user heavy armor. Alchemy focus.", "Conjuration, Destruction, and Alteration. Can't use restoration. Alchemy focus.", "Sneak, Illusion, and One-Handed or Archery. Can;t use heavy armor. Enchantin focus.", "Heavy Armor, Restoration, and One-Handed or Two-Handed. Can;t use magic other than Restoration. Smithing focus.", "Illusion, Restoration, and One-Handed. Can;t use destruction magic. Enchanting focus." };

            y = x.Next(0, 9);
            Race = Race_Num[y];
            y = x.Next(0, 9);
            Faction = Fact_Num[y];
            y = x.Next(0, 9);
            Playstyle = Play_Num[y];
            Description = PNDesc[y];

            Character = Race + " PLAYER, " + Playstyle + " of the " + Faction;
            label1.Text = Character;
            lblDesc.Text = Description;





        }
    }
}

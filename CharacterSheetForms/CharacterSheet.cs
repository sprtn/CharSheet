using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheetForms
{
    public partial class CharacterSheet : Form
    {
        int
            strength, strMod,
            dexterity, dexMod,
            constitution, conMod,
            intelligence, intMod,
            wisdom, wisMod,
            charisma, chaMod;

        public CharacterSheet()
        {
            InitializeComponent();
        }
    }
}

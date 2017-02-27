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
            strength, strMod, raceStrModifier, featStrModifier,
            dexterity, dexMod,
            constitution, conMod,
            intelligence, intMod,
            wisdom, wisMod,
            charisma, chaMod;

        enum modifiers { str, dex, con, inte, wis, cha };

        Point savedLocation;

        private void ListboxRace_SelectedValueChanged(object sender, EventArgs e)
        {
            RaceText.Text = ListboxRace.Text;
            HidePopups();
            Refresh();
        }

        private void ListboxClass_SelectedValueChanged(object sender, EventArgs e)
        {
            ClassText.Text = ListboxClass.Text;
            HidePopups();
            Refresh();
        }

        // TextChanged events, calling on the tryParseAndChange function.

        private void StrengthField_TextChanged(object sender, EventArgs e)
        {
            tryParseAndChange(StrengthField, modifiers.str);
        }
        private void DexterityField_TextChanged(object sender, EventArgs e)
        {
            tryParseAndChange(DexterityField, modifiers.dex);
        }
        private void ConstitutionField_TextChanged(object sender, EventArgs e)
        {
            tryParseAndChange(ConstitutionField, modifiers.con);
        }
        private void IntelligenceField_TextChanged(object sender, EventArgs e)
        {
            tryParseAndChange(IntelligenceField, modifiers.inte);
        }
        private void WisdomField_TextChanged(object sender, EventArgs e)
        {
            tryParseAndChange(WisdomField, modifiers.wis);
        }
        private void CharismaField_TextChanged(object sender, EventArgs e)
        {
            tryParseAndChange(CharismaField, modifiers.cha);
        }

        /// <summary>
        /// A dynamic function, working for all ability scores, and short enough.
        /// Needs an else.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="mod"></param>
        private void tryParseAndChange(TextBox field, modifiers mod)
        {
            int result;
            int.TryParse(field.Text.Trim(), out result);
            if (result <= 30 && result > 0)
                calculateMod(mod, result);
            else
            {
                Popup(AttributeNotification, field.Location);
                field.Text = "10";
                tryParseAndChange(field, mod);
            }   
        }

        private void calculateMod(modifiers mod, int result)
        {
            
            switch (mod)
            {
                case modifiers.str:
                    UpdateAttributes(strength, strMod, StrengthModLabel, result);
                    break;
                case modifiers.dex:
                    UpdateAttributes(dexterity, dexMod, DexterityModLabel, result);
                    break;
                case modifiers.con:
                    UpdateAttributes(constitution, conMod, ConstitutionModLabel, result);
                    break;
                case modifiers.inte:
                    UpdateAttributes(intelligence, intMod, IntelligenceModLabel, result);
                    break;
                case modifiers.wis:
                    UpdateAttributes(wisdom, wisMod, WisdomModLabel, result);
                    break;
                case modifiers.cha:
                    UpdateAttributes(charisma, chaMod, CharismaModLabel, result);
                    break;
            }
        }

        private void UpdateAttributes(int attribute, int modifier, Label label, int result)
        {
            attribute = result;
            modifier = (int)((result - 10) / 2);
            if (attribute < 10 && attribute % 2 == 1)
                modifier -= 1;
            label.Text = modifier.ToString();
        }

        private void RandomizeStats_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            StrengthField.Text = r.Next(3, 21).ToString();
            DexterityField.Text = r.Next(3, 21).ToString();
            ConstitutionField.Text = r.Next(3, 21).ToString();
            IntelligenceField.Text = r.Next(3, 21).ToString();
            WisdomField.Text = r.Next(3, 21).ToString();
            CharismaField.Text = r.Next(3, 21).ToString();
        }

        private void AttributeNotification_Click(object sender, EventArgs e)
        {
            HidePopups();
        }

        private void TopBox_Click(object sender, EventArgs e)
        {
            HidePopups();
        }

        private void Race_Click(object sender, EventArgs e)
        {
            HidePopups();
            Popup(ListboxRace, Cursor.Position);
        }

        private void Level_Click(object sender, EventArgs e)
        {
            HidePopups();
        }

        private void LeftBox_Click(object sender, EventArgs e)
        {
            HidePopups();
        }

        private void Class_Click(object sender, EventArgs e)
        {
            HidePopups();
            Popup(ListboxClass, Cursor.Position);
        }

        private void Popup(ListBox listBox, Point setPoint)
        {
            saveLocation(setPoint);
            listBox.BringToFront();
            listBox.Location = savedLocation;
            listBox.Visible = true;
        }

        private void Popup(Label label, Point setPoint)
        {
            setPoint.Y -= 30;
            saveLocation(setPoint);
            label.BringToFront();
            label.Location = savedLocation;
            label.Visible = true;
        }

        private void saveLocation(Point setPoint)
        {
            if (setPoint == Cursor.Position)
                savedLocation = PointToClient(setPoint);
            else
                savedLocation = setPoint;
        }

        private void HidePopups()
        {
            ListboxRace.Visible = false;
            ListboxClass.Visible = false;
            AttributeNotification.Visible = false;
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            HidePopups();
        }

        public CharacterSheet()
        {
            InitializeComponent();
        }
    }
}

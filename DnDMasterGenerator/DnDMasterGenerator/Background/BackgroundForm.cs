﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDClassesTest
{
    public partial class BackgroundForm : Form
    {
        public Background_Class Character = new Background_Class();

        public string Personality, Ideal, Bond, Flaw;

        string[] allLanguages = { "Common", "Dwarvish", "Elvish", "Giant", "Gnomish", "Goblin", "Halfling", "Orc", "Abyssal", "Celestial", "Draconic", "Deep Speech", "Infernal", "Primordial", "Sylvan", "Undercommon" };

        public BackgroundForm(ref string Personality, ref string Ideal, ref string Bond, ref string Flaw)
        {
            InitializeComponent();
            setInfo(ref Personality, ref Ideal, ref Flaw, ref Bond);
        }

        public BackgroundForm(ref string Background)
        {
            InitializeComponent();
            Background = BGChoice.Text;
        }

        public BackgroundForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void langList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (langList.CheckedItems.Count == Character.getNumLang())
                langList.Enabled = false;
        }

        private void PERSONALITY_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Personality = "", Ideal = "", Flaw = "", Bond = "";
            string choice = BGChoice.Text;
            //Background_Class Character = new Background_Class(choice);

            Character.loadFile(choice);
            //TEXTBOX.Text = choice;
            //TEXTBOX.Text = Character.PersonalityTrait();
            Character.Traits(ref Personality, ref Ideal, ref Flaw, ref Bond);
            PERSONALITY.Text = Personality;
            IDEAL.Text = Ideal;
            FLAW.Text = Flaw;
            BOND.Text = Bond;


            if (Character.getNumLang() > 0)
            {
                chooseLang();
                langList.Visible = true;
            }
            else
                langList.Visible = false;
        }

        protected void chooseLang()
        {
            Race race = new Race("Half-Orc");
            langList.Items.Clear();
            for (int i = 0; i < 8; i++) {
                if (!(race.getLangRace()[i])) {
                    langList.Items.Add(allLanguages[i]);
                }
            }
        }

        public void setInfo(ref string Personality, ref string Ideal, ref string Flaw, ref string Bond)
        {
            this.Personality = Personality;
            this.Ideal = Ideal;
            this.Flaw = Flaw;
            this.Bond = Bond;
        }

        //Submit button
        //setBackground(string background);
        //setTraits(string, string, string, string)
        //setProfs(string, string, string)
        //this.Close();
    }
}


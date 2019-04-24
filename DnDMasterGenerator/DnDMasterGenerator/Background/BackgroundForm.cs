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
        //public Background_Class Character = new Background_Class();
        public Race race = new DnDClassesTest.Race();

        public string Personality, Ideal, Bond, Flaw, Race;

        string[] allLanguages = { "Common", "Dwarvish", "Elvish", "Giant", "Gnomish", "Goblin", "Halfling", "Orc", "Abyssal", "Celestial", "Draconic", "Deep Speech", "Infernal", "Primordial", "Sylvan", "Undercommon" };
        public bool[] backlanguage = new bool[16];

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

        public BackgroundForm(Race race)
        {
            InitializeComponent();
            this.race = race;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< 8; i++)
            {
                if (langList.CheckedItems.ToString() == allLanguages[i])
                {
                    backlanguage[i] = true;
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void langList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (langList.CheckedItems.Count == selected.getNumLang())
                langList.Enabled = false;
        }

        private void PERSONALITY_TextChanged(object sender, EventArgs e)
        {

        }

        public Background_Class selected { get; set; }

        private void BGChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = new Background_Class(BGChoice.SelectedItem.ToString());

            PERSONALITY.Text = selected.Personality;
            IDEAL.Text = selected.Ideal;
            FLAW.Text = selected.Flaw;
            BOND.Text = selected.Bond;

            if (selected.getNumLang() > 0)
            {
                chooseLang();
                langList.Visible = true;
            }
            else
                langList.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BackgroundForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Race race = new Race();
        protected void chooseLang()
        {
            selected.setNumLang(race.getMoreLang());
            langList.Items.Clear();
            for (int i = 0; i < 8; i++)
            {
                if (!(race.getLangRace(i)))
                {
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


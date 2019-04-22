﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDClassesTest
{
    class Druid : Profession
    {
        protected bool[] PickedSkills;
        public bool[] _pickedSkills
        {
            get
            {
                return PickedSkills;
            }
            set
            {//will be passed a bool[18], needs validations
                PickedSkills = value;
            }
        }
        protected override List<string> Features
        { get; set; }
        public Druid()
        {
            this._level = 1;
            this._hitDie = 8;
            this._caster = true;
            this._numProSkills = 2;
        }

        public Druid(int level, int path)
        {
            this._level = level;
            this._hitDie = 8;
            this._caster = true;
            this._proPath = path;
            this._numProSkills = 2;
            this.Features = this.ClassFeatures();
        }
        public override bool[] ClassSkills()
        {//history insight medicine persuasion religion
            bool[] SkillList = new bool[18];
            /*Arcana, Animal Handling, Insight, Medicine, Nature, Perception, Religion, and Survival
             * bool[] = true;
             * bool[] = true;
             * bool[] = true;
             * bool[] = true;
             * bool[] = true;
             bool[] = true;
             bool[] = true;
             bool[] = true;*/
            return SkillList;
        }

        public override bool[] SavingThrows()
        {
            bool[] Saves = new bool[6] /*{ 0, 1, 0, 0, 0, 1 }*/
            ;
            Saves[4] = true;
            Saves[5] = true;
            return Saves;
        }

        public int ProficiencyBonus()
        {//passes the proficiency bonus to main function
            return 2 + (this._level / 5);
        }

        public override List<string> ClassFeatures()
        {
            List<string> features = new List<string>();
            String path = Path.Combine(Environment.CurrentDirectory, @"..\..\Professions\ClassFeatures\DruidClassFeatures.txt");
            //string path = @"C:\Users\csous\source\repos\DnDClassesTest\DnDClassesTest\Professions\ClassFeatures\BarbarianClassFeatures.txt";
            string[] temp = new string[15];
            temp = File.ReadAllLines(path);
            foreach (string i in temp)
            {
                features.Add(i);
            }

            return features;
        }



        public override bool[] Unlocked()
        {
            bool[] unlocked = new bool[7]/*{ false, false, false, false, false, false, false, false }*/;
            unlocked[0] = true;         //false is the default, shouldn't need that
            if (this._level >= 2) unlocked[1] = true;
            if (this._level >= 6) unlocked[2] = true;
            if (this._level >= 10) unlocked[3] = true;
            if (this._level >= 14) unlocked[4] = true;
            if (this._level >= 18) unlocked[5] = true;
            if (this._level >= 20) unlocked[6] = true;
            return unlocked;
        }

        public override List<string> CurrentFeatures()
        {
            List<string> current = new List<string>();
            bool[] unlock = this.Unlocked();
            int i;
            for (i = 0; i <= 6; ++i)
            {
                if (!unlock[i]) break;
            }
            current.Add(Features[0]);
            if (i == 1) current = Features.GetRange(0, 1);
            else if (i == 5) current = Features.GetRange(0, 3);
            else if (i >= 6) current = Features.GetRange(0, 4);

            if (_proPath == 0)
            {
                if (i < 1) return current;
                if (i >= 1)
                {
                    current.Add(Features[5]);
                    current.Add(Features[6]);
                }
                if (i >= 2) current.Add(Features[7]);
                if (i >= 3) current.Add(Features[8]);
                if (i >= 4) current.Add(Features[9]);
            }
            else if (_proPath == 1)
            {
                if (i < 1) return current;
                if (i >= 1)
                {
                    current.Add(Features[10]);
                    current.Add(Features[11]);
                }
                if (i >= 2) current.Add(Features[12]);
                if (i >= 3) current.Add(Features[13]);
                if (i >= 4) current.Add(Features[14]);
            }
            return current;
        }

        //insert class feature methods here

    }
}

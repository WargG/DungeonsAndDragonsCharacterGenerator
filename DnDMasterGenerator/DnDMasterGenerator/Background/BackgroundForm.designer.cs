﻿namespace DnDClassesTest
{
    partial class BackgroundForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
            this.BOND = new System.Windows.Forms.TextBox();
            this.FLAW = new System.Windows.Forms.TextBox();
            this.IDEAL = new System.Windows.Forms.TextBox();
            this.PERSONALITY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BGChoice = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.langList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonalityDropDown = new System.Windows.Forms.ComboBox();
            this.ChooseTraits = new System.Windows.Forms.CheckBox();
            this.IdealDropDown = new System.Windows.Forms.ComboBox();
            this.FlawDropDown = new System.Windows.Forms.ComboBox();
            this.BondDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HairMasked = new System.Windows.Forms.MaskedTextBox();
            this.SkinMasked = new System.Windows.Forms.MaskedTextBox();
            this.EyesMasked = new System.Windows.Forms.MaskedTextBox();
            this.GenderMasked = new System.Windows.Forms.MaskedTextBox();
            this.HeightMasked = new System.Windows.Forms.MaskedTextBox();
            this.AgeMasked = new System.Windows.Forms.MaskedTextBox();
            this.WeightMasked = new System.Windows.Forms.MaskedTextBox();
            this.ageValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BOND
            // 
            this.BOND.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.BOND.Location = new System.Drawing.Point(27, 334);
            this.BOND.Name = "BOND";
            this.BOND.Size = new System.Drawing.Size(495, 27);
            this.BOND.TabIndex = 11;
            // 
            // FLAW
            // 
            this.FLAW.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.FLAW.Location = new System.Drawing.Point(27, 281);
            this.FLAW.Name = "FLAW";
            this.FLAW.Size = new System.Drawing.Size(495, 27);
            this.FLAW.TabIndex = 10;
            // 
            // IDEAL
            // 
            this.IDEAL.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.IDEAL.Location = new System.Drawing.Point(26, 228);
            this.IDEAL.Name = "IDEAL";
            this.IDEAL.Size = new System.Drawing.Size(495, 27);
            this.IDEAL.TabIndex = 9;
            this.IDEAL.TextChanged += new System.EventHandler(this.IDEAL_TextChanged);
            // 
            // PERSONALITY
            // 
            this.PERSONALITY.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.PERSONALITY.Location = new System.Drawing.Point(26, 175);
            this.PERSONALITY.Name = "PERSONALITY";
            this.PERSONALITY.Size = new System.Drawing.Size(495, 27);
            this.PERSONALITY.TabIndex = 8;
            this.PERSONALITY.TextChanged += new System.EventHandler(this.PERSONALITY_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 20F);
            this.label1.Location = new System.Drawing.Point(176, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Background:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BGChoice
            // 
            this.BGChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BGChoice.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.BGChoice.FormattingEnabled = true;
            this.BGChoice.ItemHeight = 19;
            this.BGChoice.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.BGChoice.Location = new System.Drawing.Point(202, 112);
            this.BGChoice.MaxDropDownItems = 13;
            this.BGChoice.Name = "BGChoice";
            this.BGChoice.Size = new System.Drawing.Size(143, 27);
            this.BGChoice.Sorted = true;
            this.BGChoice.TabIndex = 6;
            this.BGChoice.SelectedIndexChanged += new System.EventHandler(this.BGChoice_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.btnNext.Location = new System.Drawing.Point(202, 697);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 31);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // langList
            // 
            this.langList.CheckOnClick = true;
            this.langList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langList.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.langList.FormattingEnabled = true;
            this.langList.Location = new System.Drawing.Point(27, 370);
            this.langList.MultiColumn = true;
            this.langList.Name = "langList";
            this.langList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.langList.Size = new System.Drawing.Size(494, 92);
            this.langList.TabIndex = 14;
            this.langList.Visible = false;
            this.langList.SelectedIndexChanged += new System.EventHandler(this.langList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Personality Trait:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ideal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label4.Location = new System.Drawing.Point(23, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Flaw:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label5.Location = new System.Drawing.Point(22, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bond:";
            // 
            // PersonalityDropDown
            // 
            this.PersonalityDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonalityDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonalityDropDown.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.PersonalityDropDown.FormattingEnabled = true;
            this.PersonalityDropDown.ItemHeight = 19;
            this.PersonalityDropDown.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.PersonalityDropDown.Location = new System.Drawing.Point(26, 175);
            this.PersonalityDropDown.MaxDropDownItems = 13;
            this.PersonalityDropDown.Name = "PersonalityDropDown";
            this.PersonalityDropDown.Size = new System.Drawing.Size(495, 27);
            this.PersonalityDropDown.Sorted = true;
            this.PersonalityDropDown.TabIndex = 19;
            // 
            // ChooseTraits
            // 
            this.ChooseTraits.AutoSize = true;
            this.ChooseTraits.BackColor = System.Drawing.Color.Transparent;
            this.ChooseTraits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseTraits.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.ChooseTraits.Location = new System.Drawing.Point(12, 112);
            this.ChooseTraits.Name = "ChooseTraits";
            this.ChooseTraits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChooseTraits.Size = new System.Drawing.Size(126, 23);
            this.ChooseTraits.TabIndex = 20;
            this.ChooseTraits.Text = "Choose Traits";
            this.ChooseTraits.UseVisualStyleBackColor = false;
            this.ChooseTraits.CheckedChanged += new System.EventHandler(this.ChooseTraits_CheckedChanged);
            // 
            // IdealDropDown
            // 
            this.IdealDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdealDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdealDropDown.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.IdealDropDown.FormattingEnabled = true;
            this.IdealDropDown.ItemHeight = 19;
            this.IdealDropDown.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.IdealDropDown.Location = new System.Drawing.Point(26, 228);
            this.IdealDropDown.MaxDropDownItems = 13;
            this.IdealDropDown.Name = "IdealDropDown";
            this.IdealDropDown.Size = new System.Drawing.Size(495, 27);
            this.IdealDropDown.Sorted = true;
            this.IdealDropDown.TabIndex = 21;
            // 
            // FlawDropDown
            // 
            this.FlawDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlawDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlawDropDown.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.FlawDropDown.FormattingEnabled = true;
            this.FlawDropDown.ItemHeight = 19;
            this.FlawDropDown.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.FlawDropDown.Location = new System.Drawing.Point(26, 281);
            this.FlawDropDown.MaxDropDownItems = 13;
            this.FlawDropDown.Name = "FlawDropDown";
            this.FlawDropDown.Size = new System.Drawing.Size(495, 27);
            this.FlawDropDown.Sorted = true;
            this.FlawDropDown.TabIndex = 22;
            // 
            // BondDropDown
            // 
            this.BondDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BondDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BondDropDown.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.BondDropDown.FormattingEnabled = true;
            this.BondDropDown.ItemHeight = 19;
            this.BondDropDown.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.BondDropDown.Location = new System.Drawing.Point(26, 333);
            this.BondDropDown.MaxDropDownItems = 13;
            this.BondDropDown.Name = "BondDropDown";
            this.BondDropDown.Size = new System.Drawing.Size(495, 27);
            this.BondDropDown.Sorted = true;
            this.BondDropDown.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label6.Location = new System.Drawing.Point(71, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hair:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label7.Location = new System.Drawing.Point(251, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Skin:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label8.Location = new System.Drawing.Point(430, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Eyes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label9.Location = new System.Drawing.Point(432, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label10.Location = new System.Drawing.Point(239, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Weight:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label11.Location = new System.Drawing.Point(63, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.label12.Location = new System.Drawing.Point(238, 613);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Gender:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Baskerville Old Face", 9F);
            this.button1.Location = new System.Drawing.Point(446, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HairMasked
            // 
            this.HairMasked.BeepOnError = true;
            this.HairMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HairMasked.Location = new System.Drawing.Point(26, 509);
            this.HairMasked.Mask = "L?????????????????????????????????????????????";
            this.HairMasked.Name = "HairMasked";
            this.HairMasked.Size = new System.Drawing.Size(135, 27);
            this.HairMasked.TabIndex = 40;
            this.HairMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.HairMasked_MaskInputRejected);
            // 
            // SkinMasked
            // 
            this.SkinMasked.BeepOnError = true;
            this.SkinMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinMasked.Location = new System.Drawing.Point(202, 509);
            this.SkinMasked.Mask = "L?????????????????????????????????????????????";
            this.SkinMasked.Name = "SkinMasked";
            this.SkinMasked.Size = new System.Drawing.Size(135, 27);
            this.SkinMasked.TabIndex = 41;
            this.SkinMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SkinMasked_MaskInputRejected);
            // 
            // EyesMasked
            // 
            this.EyesMasked.BeepOnError = true;
            this.EyesMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EyesMasked.Location = new System.Drawing.Point(387, 509);
            this.EyesMasked.Mask = "L?????????????????????????????????????????????";
            this.EyesMasked.Name = "EyesMasked";
            this.EyesMasked.Size = new System.Drawing.Size(135, 27);
            this.EyesMasked.TabIndex = 42;
            this.EyesMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.EyesMasked_MaskInputRejected);
            // 
            // GenderMasked
            // 
            this.GenderMasked.BeepOnError = true;
            this.GenderMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderMasked.Location = new System.Drawing.Point(202, 635);
            this.GenderMasked.Mask = "L?????????????????????????????????????????????";
            this.GenderMasked.Name = "GenderMasked";
            this.GenderMasked.Size = new System.Drawing.Size(135, 27);
            this.GenderMasked.TabIndex = 43;
            this.GenderMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.GenderMasked_MaskInputRejected);
            // 
            // HeightMasked
            // 
            this.HeightMasked.BeepOnError = true;
            this.HeightMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightMasked.Location = new System.Drawing.Point(26, 573);
            this.HeightMasked.Mask = "0\'##\"";
            this.HeightMasked.Name = "HeightMasked";
            this.HeightMasked.Size = new System.Drawing.Size(135, 27);
            this.HeightMasked.TabIndex = 44;
            this.HeightMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.HeightMasked_MaskInputRejected);
            // 
            // AgeMasked
            // 
            this.AgeMasked.BeepOnError = true;
            this.AgeMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeMasked.Location = new System.Drawing.Point(387, 573);
            this.AgeMasked.Mask = "##0";
            this.AgeMasked.Name = "AgeMasked";
            this.AgeMasked.Size = new System.Drawing.Size(135, 27);
            this.AgeMasked.TabIndex = 45;
            this.AgeMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AgeMasked_MaskInputRejected);
            // 
            // WeightMasked
            // 
            this.WeightMasked.BeepOnError = true;
            this.WeightMasked.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightMasked.Location = new System.Drawing.Point(202, 573);
            this.WeightMasked.Mask = "###0 lbs";
            this.WeightMasked.Name = "WeightMasked";
            this.WeightMasked.Size = new System.Drawing.Size(135, 27);
            this.WeightMasked.TabIndex = 46;
            this.WeightMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.WeightMasked_MaskInputRejected);
            // 
            // ageValid
            // 
            this.ageValid.AutoSize = true;
            this.ageValid.BackColor = System.Drawing.Color.Transparent;
            this.ageValid.ForeColor = System.Drawing.Color.Red;
            this.ageValid.Location = new System.Drawing.Point(384, 603);
            this.ageValid.Name = "ageValid";
            this.ageValid.Size = new System.Drawing.Size(129, 17);
            this.ageValid.TabIndex = 47;
            this.ageValid.Text = "Choose a valid age";
            // 
            // BackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 743);
            this.Controls.Add(this.ageValid);
            this.Controls.Add(this.WeightMasked);
            this.Controls.Add(this.AgeMasked);
            this.Controls.Add(this.HeightMasked);
            this.Controls.Add(this.GenderMasked);
            this.Controls.Add(this.EyesMasked);
            this.Controls.Add(this.SkinMasked);
            this.Controls.Add(this.HairMasked);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BondDropDown);
            this.Controls.Add(this.FlawDropDown);
            this.Controls.Add(this.IdealDropDown);
            this.Controls.Add(this.ChooseTraits);
            this.Controls.Add(this.PersonalityDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.langList);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.BOND);
            this.Controls.Add(this.FLAW);
            this.Controls.Add(this.IDEAL);
            this.Controls.Add(this.PERSONALITY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BackgroundForm";
            this.Text = "BackgroundForm";
            this.Load += new System.EventHandler(this.BackgroundForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BOND;
        private System.Windows.Forms.TextBox FLAW;
        private System.Windows.Forms.TextBox IDEAL;
        private System.Windows.Forms.TextBox PERSONALITY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BGChoice;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckedListBox langList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PersonalityDropDown;
        private System.Windows.Forms.CheckBox ChooseTraits;
        private System.Windows.Forms.ComboBox IdealDropDown;
        private System.Windows.Forms.ComboBox FlawDropDown;
        private System.Windows.Forms.ComboBox BondDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox HairMasked;
        private System.Windows.Forms.MaskedTextBox SkinMasked;
        private System.Windows.Forms.MaskedTextBox EyesMasked;
        private System.Windows.Forms.MaskedTextBox GenderMasked;
        private System.Windows.Forms.MaskedTextBox HeightMasked;
        private System.Windows.Forms.MaskedTextBox AgeMasked;
        private System.Windows.Forms.MaskedTextBox WeightMasked;
        private System.Windows.Forms.Label ageValid;
    }
}
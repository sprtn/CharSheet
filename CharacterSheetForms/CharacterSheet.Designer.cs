namespace CharacterSheetForms
{
    partial class CharacterSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSheet));
            this.StrengthField = new System.Windows.Forms.TextBox();
            this.StrengthModLabel = new System.Windows.Forms.Label();
            this.DexterityModLabel = new System.Windows.Forms.Label();
            this.DexterityField = new System.Windows.Forms.TextBox();
            this.ConstitutionModLabel = new System.Windows.Forms.Label();
            this.ConstitutionField = new System.Windows.Forms.TextBox();
            this.IntelligenceModLabel = new System.Windows.Forms.Label();
            this.IntelligenceField = new System.Windows.Forms.TextBox();
            this.WisdomModLabel = new System.Windows.Forms.Label();
            this.WisdomField = new System.Windows.Forms.TextBox();
            this.CharismaModLabel = new System.Windows.Forms.Label();
            this.CharismaField = new System.Windows.Forms.TextBox();
            this.LeftBox = new System.Windows.Forms.PictureBox();
            this.StrHeader = new System.Windows.Forms.Label();
            this.DexHeader = new System.Windows.Forms.Label();
            this.ConstitutionHeader = new System.Windows.Forms.Label();
            this.IntelligenceHeader = new System.Windows.Forms.Label();
            this.WisdomHeader = new System.Windows.Forms.Label();
            this.CharismaHeader = new System.Windows.Forms.Label();
            this.TopBox = new System.Windows.Forms.PictureBox();
            this.ListboxClass = new System.Windows.Forms.ListBox();
            this.ListboxRace = new System.Windows.Forms.ListBox();
            this.Class = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Label();
            this.ClassLevel = new System.Windows.Forms.TextBox();
            this.Level = new System.Windows.Forms.Label();
            this.ClassText = new System.Windows.Forms.TextBox();
            this.RaceText = new System.Windows.Forms.TextBox();
            this.AttributeNotification = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.RandomizeStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StrengthField
            // 
            this.StrengthField.AccessibleDescription = "StrengthField";
            this.StrengthField.AccessibleName = "StrengthField";
            this.StrengthField.Location = new System.Drawing.Point(37, 47);
            this.StrengthField.MaxLength = 2;
            this.StrengthField.Name = "StrengthField";
            this.StrengthField.Size = new System.Drawing.Size(35, 20);
            this.StrengthField.TabIndex = 0;
            this.StrengthField.Text = "10";
            this.StrengthField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrengthField.TextChanged += new System.EventHandler(this.StrengthField_TextChanged);
            // 
            // StrengthModLabel
            // 
            this.StrengthModLabel.AccessibleDescription = "StrengthModLabel";
            this.StrengthModLabel.AccessibleName = "StrengthModLabel";
            this.StrengthModLabel.AutoSize = true;
            this.StrengthModLabel.Location = new System.Drawing.Point(48, 79);
            this.StrengthModLabel.Name = "StrengthModLabel";
            this.StrengthModLabel.Size = new System.Drawing.Size(13, 13);
            this.StrengthModLabel.TabIndex = 1;
            this.StrengthModLabel.Text = "0";
            this.StrengthModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexterityModLabel
            // 
            this.DexterityModLabel.AccessibleDescription = "DexterityModLabel";
            this.DexterityModLabel.AccessibleName = "DexterityModLabel";
            this.DexterityModLabel.AutoSize = true;
            this.DexterityModLabel.Location = new System.Drawing.Point(48, 156);
            this.DexterityModLabel.Name = "DexterityModLabel";
            this.DexterityModLabel.Size = new System.Drawing.Size(13, 13);
            this.DexterityModLabel.TabIndex = 3;
            this.DexterityModLabel.Text = "0";
            this.DexterityModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexterityField
            // 
            this.DexterityField.AccessibleDescription = "DexterityField";
            this.DexterityField.AccessibleName = "DexterityField";
            this.DexterityField.Location = new System.Drawing.Point(37, 124);
            this.DexterityField.MaxLength = 2;
            this.DexterityField.Name = "DexterityField";
            this.DexterityField.Size = new System.Drawing.Size(35, 20);
            this.DexterityField.TabIndex = 2;
            this.DexterityField.Text = "10";
            this.DexterityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DexterityField.TextChanged += new System.EventHandler(this.DexterityField_TextChanged);
            // 
            // ConstitutionModLabel
            // 
            this.ConstitutionModLabel.AccessibleDescription = "ConstitutionModLabel";
            this.ConstitutionModLabel.AccessibleName = "ConstitutionModLabel";
            this.ConstitutionModLabel.AutoSize = true;
            this.ConstitutionModLabel.Location = new System.Drawing.Point(48, 233);
            this.ConstitutionModLabel.Name = "ConstitutionModLabel";
            this.ConstitutionModLabel.Size = new System.Drawing.Size(13, 13);
            this.ConstitutionModLabel.TabIndex = 5;
            this.ConstitutionModLabel.Text = "0";
            this.ConstitutionModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConstitutionField
            // 
            this.ConstitutionField.AccessibleDescription = "ConstitutionField";
            this.ConstitutionField.AccessibleName = "ConstitutionField";
            this.ConstitutionField.Location = new System.Drawing.Point(37, 201);
            this.ConstitutionField.MaxLength = 2;
            this.ConstitutionField.Name = "ConstitutionField";
            this.ConstitutionField.Size = new System.Drawing.Size(35, 20);
            this.ConstitutionField.TabIndex = 4;
            this.ConstitutionField.Text = "10";
            this.ConstitutionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConstitutionField.TextChanged += new System.EventHandler(this.ConstitutionField_TextChanged);
            // 
            // IntelligenceModLabel
            // 
            this.IntelligenceModLabel.AccessibleDescription = "IntelligenceModLabel";
            this.IntelligenceModLabel.AccessibleName = "IntelligenceModLabel";
            this.IntelligenceModLabel.AutoSize = true;
            this.IntelligenceModLabel.Location = new System.Drawing.Point(48, 314);
            this.IntelligenceModLabel.Name = "IntelligenceModLabel";
            this.IntelligenceModLabel.Size = new System.Drawing.Size(13, 13);
            this.IntelligenceModLabel.TabIndex = 7;
            this.IntelligenceModLabel.Text = "0";
            this.IntelligenceModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntelligenceField
            // 
            this.IntelligenceField.AccessibleDescription = "IntelligenceField";
            this.IntelligenceField.AccessibleName = "IntelligenceField";
            this.IntelligenceField.Location = new System.Drawing.Point(37, 282);
            this.IntelligenceField.MaxLength = 2;
            this.IntelligenceField.Name = "IntelligenceField";
            this.IntelligenceField.Size = new System.Drawing.Size(35, 20);
            this.IntelligenceField.TabIndex = 6;
            this.IntelligenceField.Text = "10";
            this.IntelligenceField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntelligenceField.TextChanged += new System.EventHandler(this.IntelligenceField_TextChanged);
            // 
            // WisdomModLabel
            // 
            this.WisdomModLabel.AccessibleDescription = "WisdomModLabel";
            this.WisdomModLabel.AccessibleName = "WisdomModLabel";
            this.WisdomModLabel.AutoSize = true;
            this.WisdomModLabel.Location = new System.Drawing.Point(48, 400);
            this.WisdomModLabel.Name = "WisdomModLabel";
            this.WisdomModLabel.Size = new System.Drawing.Size(13, 13);
            this.WisdomModLabel.TabIndex = 9;
            this.WisdomModLabel.Text = "0";
            this.WisdomModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WisdomField
            // 
            this.WisdomField.AccessibleDescription = "WisdomField";
            this.WisdomField.AccessibleName = "WisdomField";
            this.WisdomField.Location = new System.Drawing.Point(38, 368);
            this.WisdomField.MaxLength = 2;
            this.WisdomField.Name = "WisdomField";
            this.WisdomField.Size = new System.Drawing.Size(34, 20);
            this.WisdomField.TabIndex = 8;
            this.WisdomField.Text = "10";
            this.WisdomField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WisdomField.TextChanged += new System.EventHandler(this.WisdomField_TextChanged);
            // 
            // CharismaModLabel
            // 
            this.CharismaModLabel.AccessibleDescription = "CharismaModLabel";
            this.CharismaModLabel.AccessibleName = "CharismaModLabel";
            this.CharismaModLabel.AutoSize = true;
            this.CharismaModLabel.Location = new System.Drawing.Point(48, 482);
            this.CharismaModLabel.Name = "CharismaModLabel";
            this.CharismaModLabel.Size = new System.Drawing.Size(13, 13);
            this.CharismaModLabel.TabIndex = 11;
            this.CharismaModLabel.Text = "0";
            this.CharismaModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharismaField
            // 
            this.CharismaField.AccessibleDescription = "CharismaField";
            this.CharismaField.AccessibleName = "CharismaField";
            this.CharismaField.Location = new System.Drawing.Point(37, 450);
            this.CharismaField.MaxLength = 2;
            this.CharismaField.Name = "CharismaField";
            this.CharismaField.Size = new System.Drawing.Size(35, 20);
            this.CharismaField.TabIndex = 10;
            this.CharismaField.Text = "10";
            this.CharismaField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharismaField.TextChanged += new System.EventHandler(this.CharismaField_TextChanged);
            // 
            // LeftBox
            // 
            this.LeftBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeftBox.Location = new System.Drawing.Point(12, 12);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Padding = new System.Windows.Forms.Padding(5);
            this.LeftBox.Size = new System.Drawing.Size(84, 490);
            this.LeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LeftBox.TabIndex = 12;
            this.LeftBox.TabStop = false;
            this.LeftBox.Click += new System.EventHandler(this.LeftBox_Click);
            // 
            // StrHeader
            // 
            this.StrHeader.AccessibleName = "StrHeader";
            this.StrHeader.AutoSize = true;
            this.StrHeader.Location = new System.Drawing.Point(34, 31);
            this.StrHeader.Name = "StrHeader";
            this.StrHeader.Size = new System.Drawing.Size(47, 13);
            this.StrHeader.TabIndex = 13;
            this.StrHeader.Text = "Strength";
            // 
            // DexHeader
            // 
            this.DexHeader.AccessibleName = "DexHeader";
            this.DexHeader.AutoSize = true;
            this.DexHeader.Location = new System.Drawing.Point(33, 108);
            this.DexHeader.Name = "DexHeader";
            this.DexHeader.Size = new System.Drawing.Size(48, 13);
            this.DexHeader.TabIndex = 14;
            this.DexHeader.Text = "Dexterity";
            // 
            // ConstitutionHeader
            // 
            this.ConstitutionHeader.AccessibleName = "ConstitutionHeader";
            this.ConstitutionHeader.AutoSize = true;
            this.ConstitutionHeader.Location = new System.Drawing.Point(23, 185);
            this.ConstitutionHeader.Name = "ConstitutionHeader";
            this.ConstitutionHeader.Size = new System.Drawing.Size(62, 13);
            this.ConstitutionHeader.TabIndex = 15;
            this.ConstitutionHeader.Text = "Constitution";
            // 
            // IntelligenceHeader
            // 
            this.IntelligenceHeader.AccessibleName = "IntelligenceHeader";
            this.IntelligenceHeader.AutoSize = true;
            this.IntelligenceHeader.Location = new System.Drawing.Point(24, 266);
            this.IntelligenceHeader.Name = "IntelligenceHeader";
            this.IntelligenceHeader.Size = new System.Drawing.Size(61, 13);
            this.IntelligenceHeader.TabIndex = 16;
            this.IntelligenceHeader.Text = "Intelligence";
            // 
            // WisdomHeader
            // 
            this.WisdomHeader.AccessibleName = "WisdomHeader";
            this.WisdomHeader.AutoSize = true;
            this.WisdomHeader.Location = new System.Drawing.Point(34, 352);
            this.WisdomHeader.Name = "WisdomHeader";
            this.WisdomHeader.Size = new System.Drawing.Size(45, 13);
            this.WisdomHeader.TabIndex = 17;
            this.WisdomHeader.Text = "Wisdom";
            // 
            // CharismaHeader
            // 
            this.CharismaHeader.AccessibleName = "CharismaHeader";
            this.CharismaHeader.AutoSize = true;
            this.CharismaHeader.Location = new System.Drawing.Point(31, 434);
            this.CharismaHeader.Name = "CharismaHeader";
            this.CharismaHeader.Size = new System.Drawing.Size(50, 13);
            this.CharismaHeader.TabIndex = 18;
            this.CharismaHeader.Text = "Charisma";
            // 
            // TopBox
            // 
            this.TopBox.BackColor = System.Drawing.SystemColors.Control;
            this.TopBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopBox.Location = new System.Drawing.Point(102, 12);
            this.TopBox.Name = "TopBox";
            this.TopBox.Padding = new System.Windows.Forms.Padding(5);
            this.TopBox.Size = new System.Drawing.Size(400, 84);
            this.TopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TopBox.TabIndex = 19;
            this.TopBox.TabStop = false;
            this.TopBox.Click += new System.EventHandler(this.TopBox_Click);
            // 
            // ListboxClass
            // 
            this.ListboxClass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListboxClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListboxClass.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxClass.FormattingEnabled = true;
            this.ListboxClass.ItemHeight = 12;
            this.ListboxClass.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.ListboxClass.Location = new System.Drawing.Point(6, -4);
            this.ListboxClass.Name = "ListboxClass";
            this.ListboxClass.Size = new System.Drawing.Size(93, 64);
            this.ListboxClass.TabIndex = 21;
            this.ListboxClass.SelectedValueChanged += new System.EventHandler(this.ListboxClass_SelectedValueChanged);
            // 
            // ListboxRace
            // 
            this.ListboxRace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListboxRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListboxRace.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxRace.FormattingEnabled = true;
            this.ListboxRace.ItemHeight = 12;
            this.ListboxRace.Items.AddRange(new object[] {
            "Aasimar",
            "Deep Gnome / Sfirneblin",
            "Dragonborn",
            "Dwarf: Mountain ",
            "Dwarf: Hill",
            "Dwarf: Duergar",
            "Elf: High",
            "Elf: Wood",
            "Elf: Drow",
            "Firbolg",
            "Genasi",
            "Gnome",
            "Goblin",
            "Goliath",
            "Halfling: Lightfoot",
            "Halfling: Stout",
            "Halfling: Ghostwise",
            "Half-Elf",
            "Half-Elf: Variant",
            "Half-Orc",
            "Hobgoblin",
            "Human: Standard",
            "Human: Variant",
            "Kenku",
            "Kobold",
            "Lizardfolk",
            "Orc",
            "Tabaxi",
            "Tiefling",
            "Tiefling: Variant",
            "Triton",
            "Yuan-Ti Pureblood"});
            this.ListboxRace.Location = new System.Drawing.Point(6, 0);
            this.ListboxRace.Name = "ListboxRace";
            this.ListboxRace.Size = new System.Drawing.Size(189, 76);
            this.ListboxRace.TabIndex = 22;
            this.ListboxRace.Visible = false;
            this.ListboxRace.SelectedValueChanged += new System.EventHandler(this.ListboxRace_SelectedValueChanged);
            // 
            // Class
            // 
            this.Class.AccessibleDescription = "Class";
            this.Class.AccessibleName = "Class";
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(113, 21);
            this.Class.Name = "Class";
            this.Class.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Class.Size = new System.Drawing.Size(32, 13);
            this.Class.TabIndex = 23;
            this.Class.Text = "Class";
            this.Class.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Race
            // 
            this.Race.AccessibleDescription = "Race";
            this.Race.AccessibleName = "Race";
            this.Race.AutoSize = true;
            this.Race.Location = new System.Drawing.Point(113, 47);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(33, 13);
            this.Race.TabIndex = 24;
            this.Race.Text = "Race";
            this.Race.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // ClassLevel
            // 
            this.ClassLevel.AccessibleDescription = "ClassLevel";
            this.ClassLevel.AccessibleName = "ClassLevel";
            this.ClassLevel.Location = new System.Drawing.Point(300, 18);
            this.ClassLevel.MaxLength = 2;
            this.ClassLevel.Name = "ClassLevel";
            this.ClassLevel.Size = new System.Drawing.Size(18, 20);
            this.ClassLevel.TabIndex = 25;
            this.ClassLevel.Text = "20";
            // 
            // Level
            // 
            this.Level.AccessibleDescription = "Class";
            this.Level.AccessibleName = "Class";
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(261, 21);
            this.Level.Name = "Level";
            this.Level.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Level.Size = new System.Drawing.Size(33, 13);
            this.Level.TabIndex = 26;
            this.Level.Text = "Level";
            this.Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Level.Click += new System.EventHandler(this.Level_Click);
            // 
            // ClassText
            // 
            this.ClassText.AccessibleDescription = "ClassText";
            this.ClassText.AccessibleName = "ClassText";
            this.ClassText.Location = new System.Drawing.Point(151, 18);
            this.ClassText.Name = "ClassText";
            this.ClassText.ReadOnly = true;
            this.ClassText.Size = new System.Drawing.Size(103, 20);
            this.ClassText.TabIndex = 27;
            this.ClassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaceText
            // 
            this.RaceText.AccessibleDescription = "RaceText";
            this.RaceText.AccessibleName = "RaceText";
            this.RaceText.Location = new System.Drawing.Point(151, 44);
            this.RaceText.Name = "RaceText";
            this.RaceText.ReadOnly = true;
            this.RaceText.Size = new System.Drawing.Size(103, 20);
            this.RaceText.TabIndex = 28;
            this.RaceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttributeNotification
            // 
            this.AttributeNotification.AccessibleDescription = "AttributeNotification";
            this.AttributeNotification.AccessibleName = "AttributeNotification";
            this.AttributeNotification.AutoSize = true;
            this.AttributeNotification.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AttributeNotification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttributeNotification.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributeNotification.Location = new System.Drawing.Point(6, 1);
            this.AttributeNotification.Name = "AttributeNotification";
            this.AttributeNotification.Size = new System.Drawing.Size(287, 14);
            this.AttributeNotification.TabIndex = 29;
            this.AttributeNotification.Text = "Attribute score must be between 1 and 30";
            this.AttributeNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AttributeNotification.Visible = false;
            this.AttributeNotification.Click += new System.EventHandler(this.AttributeNotification_Click);
            // 
            // RandomizeStats
            // 
            this.RandomizeStats.AccessibleDescription = "RandomizeStats";
            this.RandomizeStats.AccessibleName = "RandomizeStats";
            this.RandomizeStats.BackColor = System.Drawing.Color.Orange;
            this.RandomizeStats.Location = new System.Drawing.Point(12, 508);
            this.RandomizeStats.Name = "RandomizeStats";
            this.RandomizeStats.Size = new System.Drawing.Size(84, 45);
            this.RandomizeStats.TabIndex = 30;
            this.RandomizeStats.Text = "Randomize Stats";
            this.RandomizeStats.UseVisualStyleBackColor = false;
            this.RandomizeStats.Click += new System.EventHandler(this.RandomizeStats_Click);
            // 
            // CharacterSheet
            // 
            this.AccessibleName = "CharacterSheet";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 699);
            this.Controls.Add(this.RandomizeStats);
            this.Controls.Add(this.RaceText);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.ClassLevel);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.CharismaHeader);
            this.Controls.Add(this.WisdomHeader);
            this.Controls.Add(this.IntelligenceHeader);
            this.Controls.Add(this.ConstitutionHeader);
            this.Controls.Add(this.DexHeader);
            this.Controls.Add(this.StrHeader);
            this.Controls.Add(this.CharismaModLabel);
            this.Controls.Add(this.CharismaField);
            this.Controls.Add(this.WisdomModLabel);
            this.Controls.Add(this.WisdomField);
            this.Controls.Add(this.IntelligenceModLabel);
            this.Controls.Add(this.IntelligenceField);
            this.Controls.Add(this.ConstitutionModLabel);
            this.Controls.Add(this.ConstitutionField);
            this.Controls.Add(this.DexterityModLabel);
            this.Controls.Add(this.DexterityField);
            this.Controls.Add(this.StrengthModLabel);
            this.Controls.Add(this.StrengthField);
            this.Controls.Add(this.LeftBox);
            this.Controls.Add(this.TopBox);
            this.Controls.Add(this.ListboxRace);
            this.Controls.Add(this.ListboxClass);
            this.Controls.Add(this.AttributeNotification);
            this.Name = "CharacterSheet";
            this.RightToLeftLayout = true;
            this.Text = "Character Sheet";
            this.Load += new System.EventHandler(this.CharacterSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StrengthField;
        private System.Windows.Forms.Label StrengthModLabel;
        private System.Windows.Forms.Label DexterityModLabel;
        private System.Windows.Forms.TextBox DexterityField;
        private System.Windows.Forms.Label ConstitutionModLabel;
        private System.Windows.Forms.TextBox ConstitutionField;
        private System.Windows.Forms.Label IntelligenceModLabel;
        private System.Windows.Forms.TextBox IntelligenceField;
        private System.Windows.Forms.Label WisdomModLabel;
        private System.Windows.Forms.TextBox WisdomField;
        private System.Windows.Forms.Label CharismaModLabel;
        private System.Windows.Forms.TextBox CharismaField;
        private System.Windows.Forms.PictureBox LeftBox;
        private System.Windows.Forms.Label StrHeader;
        private System.Windows.Forms.Label DexHeader;
        private System.Windows.Forms.Label ConstitutionHeader;
        private System.Windows.Forms.Label IntelligenceHeader;
        private System.Windows.Forms.Label WisdomHeader;
        private System.Windows.Forms.Label CharismaHeader;
        private System.Windows.Forms.PictureBox TopBox;
        private System.Windows.Forms.ListBox ListboxClass;
        private System.Windows.Forms.ListBox ListboxRace;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label Race;
        private System.Windows.Forms.TextBox ClassLevel;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.TextBox ClassText;
        private System.Windows.Forms.TextBox RaceText;
        private System.Windows.Forms.Label AttributeNotification;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button RandomizeStats;
    }
}


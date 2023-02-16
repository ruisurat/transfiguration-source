
namespace Transfiguration
{
    partial class PotionOptions
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
            this.potionsUpdateDbBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.potionTypeSelection = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.potionBrewTimeValue = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.potionYieldValue = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ingredient1QuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ingredient2QuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ingredient2Selection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ingredient3QuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ingredient3Selection = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ingredient4QuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ingredient4Selection = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ingredient5QuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ingredient5Selection = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ingredient6QuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.ingredient6Selection = new System.Windows.Forms.ComboBox();
            this.potionSelectionBox = new System.Windows.Forms.ComboBox();
            this.ingredient1Selection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.potionBrewTimeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionYieldValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient1QuantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient2QuantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient3QuantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient4QuantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient5QuantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient6QuantityValue)).BeginInit();
            this.SuspendLayout();
            // 
            // potionsUpdateDbBtn
            // 
            this.potionsUpdateDbBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.potionsUpdateDbBtn.FlatAppearance.BorderSize = 0;
            this.potionsUpdateDbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.potionsUpdateDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.potionsUpdateDbBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionsUpdateDbBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.potionsUpdateDbBtn.Location = new System.Drawing.Point(199, 12);
            this.potionsUpdateDbBtn.Name = "potionsUpdateDbBtn";
            this.potionsUpdateDbBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.potionsUpdateDbBtn.Size = new System.Drawing.Size(119, 29);
            this.potionsUpdateDbBtn.TabIndex = 38;
            this.potionsUpdateDbBtn.Text = "Update Record";
            this.potionsUpdateDbBtn.UseVisualStyleBackColor = false;
            this.potionsUpdateDbBtn.Click += new System.EventHandler(this.potionsUpdateDbBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Potion Type (untested)";
            // 
            // potionTypeSelection
            // 
            this.potionTypeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.potionTypeSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.potionTypeSelection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionTypeSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.potionTypeSelection.FormattingEnabled = true;
            this.potionTypeSelection.Items.AddRange(new object[] {
            "combat",
            "energy",
            "forage"});
            this.potionTypeSelection.Location = new System.Drawing.Point(12, 76);
            this.potionTypeSelection.Name = "potionTypeSelection";
            this.potionTypeSelection.Size = new System.Drawing.Size(178, 25);
            this.potionTypeSelection.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(210, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 45;
            this.label12.Text = "Brewing Time (s)";
            // 
            // potionBrewTimeValue
            // 
            this.potionBrewTimeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.potionBrewTimeValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionBrewTimeValue.ForeColor = System.Drawing.SystemColors.Control;
            this.potionBrewTimeValue.Location = new System.Drawing.Point(214, 165);
            this.potionBrewTimeValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.potionBrewTimeValue.Name = "potionBrewTimeValue";
            this.potionBrewTimeValue.Size = new System.Drawing.Size(178, 25);
            this.potionBrewTimeValue.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(7, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "Brewing Yield";
            // 
            // potionYieldValue
            // 
            this.potionYieldValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.potionYieldValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionYieldValue.ForeColor = System.Drawing.SystemColors.Control;
            this.potionYieldValue.Location = new System.Drawing.Point(11, 165);
            this.potionYieldValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.potionYieldValue.Name = "potionYieldValue";
            this.potionYieldValue.Size = new System.Drawing.Size(178, 25);
            this.potionYieldValue.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(7, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Brewing Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ingredient Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ingredient 1";
            // 
            // ingredient1QuantityValue
            // 
            this.ingredient1QuantityValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient1QuantityValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient1QuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient1QuantityValue.Location = new System.Drawing.Point(214, 261);
            this.ingredient1QuantityValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ingredient1QuantityValue.Name = "ingredient1QuantityValue";
            this.ingredient1QuantityValue.Size = new System.Drawing.Size(178, 25);
            this.ingredient1QuantityValue.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(210, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ingredient 1 Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(210, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ingredient 2 Quantity";
            // 
            // ingredient2QuantityValue
            // 
            this.ingredient2QuantityValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient2QuantityValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient2QuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient2QuantityValue.Location = new System.Drawing.Point(214, 322);
            this.ingredient2QuantityValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ingredient2QuantityValue.Name = "ingredient2QuantityValue";
            this.ingredient2QuantityValue.Size = new System.Drawing.Size(178, 25);
            this.ingredient2QuantityValue.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ingredient 2";
            // 
            // ingredient2Selection
            // 
            this.ingredient2Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient2Selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredient2Selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient2Selection.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient2Selection.FormattingEnabled = true;
            this.ingredient2Selection.Items.AddRange(new object[] {
            "LacewingFlies",
            "LeechJuice",
            "AshwinderEggs",
            "LeapingToadstool_Byproduct",
            "HorklumpJuice",
            "Fluxweed_Byproduct",
            "Shrivelfig_Byproduct",
            "Wolf_Byproduct",
            "Knotgrass_Byproduct",
            "Spider_Fang",
            "Dittany_Byproduct",
            "Dugbog_Pellet",
            "StenchOfTheDead",
            "TrollMucus"});
            this.ingredient2Selection.Location = new System.Drawing.Point(12, 322);
            this.ingredient2Selection.Name = "ingredient2Selection";
            this.ingredient2Selection.Size = new System.Drawing.Size(178, 25);
            this.ingredient2Selection.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(209, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ingredient 3 Quantity";
            // 
            // ingredient3QuantityValue
            // 
            this.ingredient3QuantityValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient3QuantityValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient3QuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient3QuantityValue.Location = new System.Drawing.Point(213, 383);
            this.ingredient3QuantityValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ingredient3QuantityValue.Name = "ingredient3QuantityValue";
            this.ingredient3QuantityValue.Size = new System.Drawing.Size(178, 25);
            this.ingredient3QuantityValue.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(7, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Ingredient 3";
            // 
            // ingredient3Selection
            // 
            this.ingredient3Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient3Selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredient3Selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient3Selection.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient3Selection.FormattingEnabled = true;
            this.ingredient3Selection.Items.AddRange(new object[] {
            "LacewingFlies",
            "LeechJuice",
            "AshwinderEggs",
            "LeapingToadstool_Byproduct",
            "HorklumpJuice",
            "Fluxweed_Byproduct",
            "Shrivelfig_Byproduct",
            "Wolf_Byproduct",
            "Knotgrass_Byproduct",
            "Spider_Fang",
            "Dittany_Byproduct",
            "Dugbog_Pellet",
            "StenchOfTheDead",
            "TrollMucus"});
            this.ingredient3Selection.Location = new System.Drawing.Point(11, 383);
            this.ingredient3Selection.Name = "ingredient3Selection";
            this.ingredient3Selection.Size = new System.Drawing.Size(178, 25);
            this.ingredient3Selection.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(209, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "Ingredient 4 Quantity";
            // 
            // ingredient4QuantityValue
            // 
            this.ingredient4QuantityValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient4QuantityValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient4QuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient4QuantityValue.Location = new System.Drawing.Point(213, 444);
            this.ingredient4QuantityValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ingredient4QuantityValue.Name = "ingredient4QuantityValue";
            this.ingredient4QuantityValue.Size = new System.Drawing.Size(178, 25);
            this.ingredient4QuantityValue.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(7, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 55;
            this.label13.Text = "Ingredient 4";
            // 
            // ingredient4Selection
            // 
            this.ingredient4Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient4Selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredient4Selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient4Selection.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient4Selection.FormattingEnabled = true;
            this.ingredient4Selection.Items.AddRange(new object[] {
            "LacewingFlies",
            "LeechJuice",
            "AshwinderEggs",
            "LeapingToadstool_Byproduct",
            "HorklumpJuice",
            "Fluxweed_Byproduct",
            "Shrivelfig_Byproduct",
            "Wolf_Byproduct",
            "Knotgrass_Byproduct",
            "Spider_Fang",
            "Dittany_Byproduct",
            "Dugbog_Pellet",
            "StenchOfTheDead",
            "TrollMucus"});
            this.ingredient4Selection.Location = new System.Drawing.Point(11, 444);
            this.ingredient4Selection.Name = "ingredient4Selection";
            this.ingredient4Selection.Size = new System.Drawing.Size(178, 25);
            this.ingredient4Selection.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(210, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 19);
            this.label14.TabIndex = 61;
            this.label14.Text = "Ingredient 5 Quantity";
            // 
            // ingredient5QuantityValue
            // 
            this.ingredient5QuantityValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient5QuantityValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient5QuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient5QuantityValue.Location = new System.Drawing.Point(214, 504);
            this.ingredient5QuantityValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ingredient5QuantityValue.Name = "ingredient5QuantityValue";
            this.ingredient5QuantityValue.Size = new System.Drawing.Size(178, 25);
            this.ingredient5QuantityValue.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(8, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 19);
            this.label15.TabIndex = 59;
            this.label15.Text = "Ingredient 5";
            // 
            // ingredient5Selection
            // 
            this.ingredient5Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient5Selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredient5Selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient5Selection.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient5Selection.FormattingEnabled = true;
            this.ingredient5Selection.Items.AddRange(new object[] {
            "LacewingFlies",
            "LeechJuice",
            "AshwinderEggs",
            "LeapingToadstool_Byproduct",
            "HorklumpJuice",
            "Fluxweed_Byproduct",
            "Shrivelfig_Byproduct",
            "Wolf_Byproduct",
            "Knotgrass_Byproduct",
            "Spider_Fang",
            "Dittany_Byproduct",
            "Dugbog_Pellet",
            "StenchOfTheDead",
            "TrollMucus"});
            this.ingredient5Selection.Location = new System.Drawing.Point(12, 504);
            this.ingredient5Selection.Name = "ingredient5Selection";
            this.ingredient5Selection.Size = new System.Drawing.Size(178, 25);
            this.ingredient5Selection.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(210, 542);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 19);
            this.label16.TabIndex = 65;
            this.label16.Text = "Ingredient 6 Quantity";
            // 
            // ingredient6QuantityValue
            // 
            this.ingredient6QuantityValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient6QuantityValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient6QuantityValue.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient6QuantityValue.Location = new System.Drawing.Point(214, 565);
            this.ingredient6QuantityValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ingredient6QuantityValue.Name = "ingredient6QuantityValue";
            this.ingredient6QuantityValue.Size = new System.Drawing.Size(178, 25);
            this.ingredient6QuantityValue.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(8, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 19);
            this.label17.TabIndex = 63;
            this.label17.Text = "Ingredient 6";
            // 
            // ingredient6Selection
            // 
            this.ingredient6Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient6Selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredient6Selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient6Selection.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient6Selection.FormattingEnabled = true;
            this.ingredient6Selection.Items.AddRange(new object[] {
            "LacewingFlies",
            "LeechJuice",
            "AshwinderEggs",
            "LeapingToadstool_Byproduct",
            "HorklumpJuice",
            "Fluxweed_Byproduct",
            "Shrivelfig_Byproduct",
            "Wolf_Byproduct",
            "Knotgrass_Byproduct",
            "Spider_Fang",
            "Dittany_Byproduct",
            "Dugbog_Pellet",
            "StenchOfTheDead",
            "TrollMucus"});
            this.ingredient6Selection.Location = new System.Drawing.Point(12, 565);
            this.ingredient6Selection.Name = "ingredient6Selection";
            this.ingredient6Selection.Size = new System.Drawing.Size(178, 25);
            this.ingredient6Selection.TabIndex = 62;
            // 
            // potionSelectionBox
            // 
            this.potionSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.potionSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.potionSelectionBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionSelectionBox.ForeColor = System.Drawing.SystemColors.Control;
            this.potionSelectionBox.FormattingEnabled = true;
            this.potionSelectionBox.Items.AddRange(new object[] {
            "AMFillPotion",
            "AutoDamagePotion",
            "Edurus",
            "FelixFelicis",
            "InvisibilityPotion",
            "Maxima",
            "WoundCleaning"});
            this.potionSelectionBox.Location = new System.Drawing.Point(12, 15);
            this.potionSelectionBox.Name = "potionSelectionBox";
            this.potionSelectionBox.Size = new System.Drawing.Size(178, 25);
            this.potionSelectionBox.TabIndex = 69;
            this.potionSelectionBox.SelectedIndexChanged += new System.EventHandler(this.potionSelectionBox_SelectedIndexChanged_1);
            // 
            // ingredient1Selection
            // 
            this.ingredient1Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ingredient1Selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredient1Selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient1Selection.ForeColor = System.Drawing.SystemColors.Control;
            this.ingredient1Selection.FormattingEnabled = true;
            this.ingredient1Selection.Items.AddRange(new object[] {
            "LacewingFlies",
            "LeechJuice",
            "AshwinderEggs",
            "LeapingToadstool_Byproduct",
            "HorklumpJuice",
            "Fluxweed_Byproduct",
            "Shrivelfig_Byproduct",
            "Wolf_Byproduct",
            "Knotgrass_Byproduct",
            "Spider_Fang",
            "Dittany_Byproduct",
            "Dugbog_Pellet",
            "StenchOfTheDead",
            "TrollMucus"});
            this.ingredient1Selection.Location = new System.Drawing.Point(11, 260);
            this.ingredient1Selection.Name = "ingredient1Selection";
            this.ingredient1Selection.Size = new System.Drawing.Size(178, 25);
            this.ingredient1Selection.TabIndex = 70;
            // 
            // PotionOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(532, 593);
            this.Controls.Add(this.ingredient1Selection);
            this.Controls.Add(this.potionSelectionBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ingredient6QuantityValue);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ingredient6Selection);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ingredient5QuantityValue);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ingredient5Selection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ingredient4QuantityValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ingredient4Selection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ingredient3QuantityValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ingredient3Selection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingredient2QuantityValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ingredient2Selection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ingredient1QuantityValue);
            this.Controls.Add(this.potionBrewTimeValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.potionYieldValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.potionTypeSelection);
            this.Controls.Add(this.potionsUpdateDbBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "PotionOptions";
            this.Text = "PotionOptions";
            ((System.ComponentModel.ISupportInitialize)(this.potionBrewTimeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionYieldValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient1QuantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient2QuantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient3QuantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient4QuantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient5QuantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredient6QuantityValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button potionsUpdateDbBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox potionTypeSelection;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown potionBrewTimeValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown potionYieldValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ingredient1QuantityValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ingredient2QuantityValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ingredient2Selection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ingredient3QuantityValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ingredient3Selection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ingredient4QuantityValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ingredient4Selection;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown ingredient5QuantityValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ingredient5Selection;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown ingredient6QuantityValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ingredient6Selection;
        private System.Windows.Forms.ComboBox potionSelectionBox;
        private System.Windows.Forms.ComboBox ingredient1Selection;
    }
}
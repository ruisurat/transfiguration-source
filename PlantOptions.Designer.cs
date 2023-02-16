
namespace Transfiguration
{
    partial class PlantOptions
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
            this.plantSelectionBox = new System.Windows.Forms.ComboBox();
            this.btnUpdatePlantDb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.byProductSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.potSizeSelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.initGrowthValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.regrowthValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.hrvstYieldValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.frgYieldValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.multiHarvestableCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.plantTierValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.initGrowthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regrowthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrvstYieldValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frgYieldValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTierValue)).BeginInit();
            this.SuspendLayout();
            // 
            // plantSelectionBox
            // 
            this.plantSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.plantSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plantSelectionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantSelectionBox.ForeColor = System.Drawing.SystemColors.Control;
            this.plantSelectionBox.FormattingEnabled = true;
            this.plantSelectionBox.Items.AddRange(new object[] {
            "ChompingCabbage_Plant",
            "Dittany",
            "Fluxweed",
            "Knotgrass",
            "Mallowsweet",
            "Mandrake",
            "Shrivelfig",
            "VenomousTentacula"});
            this.plantSelectionBox.Location = new System.Drawing.Point(12, 12);
            this.plantSelectionBox.Name = "plantSelectionBox";
            this.plantSelectionBox.Size = new System.Drawing.Size(178, 29);
            this.plantSelectionBox.TabIndex = 37;
            this.plantSelectionBox.SelectedIndexChanged += new System.EventHandler(this.plantSelectionBox_SelectedIndexChanged);
            // 
            // btnUpdatePlantDb
            // 
            this.btnUpdatePlantDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUpdatePlantDb.FlatAppearance.BorderSize = 0;
            this.btnUpdatePlantDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnUpdatePlantDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePlantDb.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlantDb.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdatePlantDb.Location = new System.Drawing.Point(199, 12);
            this.btnUpdatePlantDb.Name = "btnUpdatePlantDb";
            this.btnUpdatePlantDb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdatePlantDb.Size = new System.Drawing.Size(119, 29);
            this.btnUpdatePlantDb.TabIndex = 38;
            this.btnUpdatePlantDb.Text = "Update Record";
            this.btnUpdatePlantDb.UseVisualStyleBackColor = false;
            this.btnUpdatePlantDb.Click += new System.EventHandler(this.btnUpdatePlantDb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Harvesting Settings";
            // 
            // byProductSelection
            // 
            this.byProductSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.byProductSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byProductSelection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byProductSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.byProductSelection.FormattingEnabled = true;
            this.byProductSelection.Items.AddRange(new object[] {
            "ChompingCabbage_Byproduct",
            "Dittany_Byproduct",
            "Fluxweed_Byproduct",
            "Knotgrass_Byproduct",
            "Mallowsweet_Byproduct",
            "Mandrake_Byproduct",
            "Shrivelfig_Byproduct",
            "VenomousTentacula_Byproduct"});
            this.byProductSelection.Location = new System.Drawing.Point(12, 202);
            this.byProductSelection.Name = "byProductSelection";
            this.byProductSelection.Size = new System.Drawing.Size(178, 25);
            this.byProductSelection.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "By Product";
            // 
            // potSizeSelection
            // 
            this.potSizeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.potSizeSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.potSizeSelection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potSizeSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.potSizeSelection.FormattingEnabled = true;
            this.potSizeSelection.Items.AddRange(new object[] {
            "Small_Plant",
            "Medium_Plant",
            "Large_Plant"});
            this.potSizeSelection.Location = new System.Drawing.Point(215, 202);
            this.potSizeSelection.Name = "potSizeSelection";
            this.potSizeSelection.Size = new System.Drawing.Size(178, 25);
            this.potSizeSelection.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(211, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pot Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Initial Growth Time (s)";
            // 
            // initGrowthValue
            // 
            this.initGrowthValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.initGrowthValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initGrowthValue.ForeColor = System.Drawing.SystemColors.Control;
            this.initGrowthValue.Location = new System.Drawing.Point(12, 262);
            this.initGrowthValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.initGrowthValue.Name = "initGrowthValue";
            this.initGrowthValue.Size = new System.Drawing.Size(178, 25);
            this.initGrowthValue.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(211, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Regrowth Time (s)";
            // 
            // regrowthValue
            // 
            this.regrowthValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.regrowthValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regrowthValue.ForeColor = System.Drawing.SystemColors.Control;
            this.regrowthValue.Location = new System.Drawing.Point(215, 262);
            this.regrowthValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.regrowthValue.Name = "regrowthValue";
            this.regrowthValue.Size = new System.Drawing.Size(178, 25);
            this.regrowthValue.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Yield";
            // 
            // hrvstYieldValue
            // 
            this.hrvstYieldValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hrvstYieldValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrvstYieldValue.ForeColor = System.Drawing.SystemColors.Control;
            this.hrvstYieldValue.Location = new System.Drawing.Point(12, 323);
            this.hrvstYieldValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hrvstYieldValue.Name = "hrvstYieldValue";
            this.hrvstYieldValue.Size = new System.Drawing.Size(178, 25);
            this.hrvstYieldValue.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(7, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Foraging Settings";
            // 
            // frgYieldValue
            // 
            this.frgYieldValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.frgYieldValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frgYieldValue.ForeColor = System.Drawing.SystemColors.Control;
            this.frgYieldValue.Location = new System.Drawing.Point(11, 416);
            this.frgYieldValue.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.frgYieldValue.Name = "frgYieldValue";
            this.frgYieldValue.Size = new System.Drawing.Size(178, 25);
            this.frgYieldValue.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(7, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Yield";
            // 
            // multiHarvestableCheckbox
            // 
            this.multiHarvestableCheckbox.AutoSize = true;
            this.multiHarvestableCheckbox.FlatAppearance.BorderSize = 0;
            this.multiHarvestableCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.multiHarvestableCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiHarvestableCheckbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiHarvestableCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.multiHarvestableCheckbox.Location = new System.Drawing.Point(11, 55);
            this.multiHarvestableCheckbox.Name = "multiHarvestableCheckbox";
            this.multiHarvestableCheckbox.Size = new System.Drawing.Size(173, 24);
            this.multiHarvestableCheckbox.TabIndex = 37;
            this.multiHarvestableCheckbox.Text = "Is Multi Harvestable?";
            this.multiHarvestableCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(7, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tier";
            // 
            // plantTierValue
            // 
            this.plantTierValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.plantTierValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantTierValue.ForeColor = System.Drawing.SystemColors.Control;
            this.plantTierValue.Location = new System.Drawing.Point(11, 105);
            this.plantTierValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.plantTierValue.Name = "plantTierValue";
            this.plantTierValue.Size = new System.Drawing.Size(178, 25);
            this.plantTierValue.TabIndex = 37;
            // 
            // PlantOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(466, 518);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.plantTierValue);
            this.Controls.Add(this.multiHarvestableCheckbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.frgYieldValue);
            this.Controls.Add(this.hrvstYieldValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regrowthValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initGrowthValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdatePlantDb);
            this.Controls.Add(this.potSizeSelection);
            this.Controls.Add(this.plantSelectionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.byProductSelection);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "PlantOptions";
            this.Text = "PlantOptions";
            ((System.ComponentModel.ISupportInitialize)(this.initGrowthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regrowthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrvstYieldValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frgYieldValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTierValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox plantSelectionBox;
        private System.Windows.Forms.Button btnUpdatePlantDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox byProductSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox potSizeSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown initGrowthValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown regrowthValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown hrvstYieldValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown frgYieldValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox multiHarvestableCheckbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown plantTierValue;
    }
}
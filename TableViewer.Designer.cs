
namespace Transfiguration
{
    partial class TableViewer
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
            this.tableNamesSelection = new System.Windows.Forms.ComboBox();
            this.btnLoadTables = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableNamesSelection
            // 
            this.tableNamesSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableNamesSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableNamesSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNamesSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.tableNamesSelection.FormattingEnabled = true;
            this.tableNamesSelection.Location = new System.Drawing.Point(12, 12);
            this.tableNamesSelection.Name = "tableNamesSelection";
            this.tableNamesSelection.Size = new System.Drawing.Size(178, 29);
            this.tableNamesSelection.TabIndex = 37;
            this.tableNamesSelection.SelectedIndexChanged += new System.EventHandler(this.tableNamesSelection_SelectedIndexChanged);
            // 
            // btnLoadTables
            // 
            this.btnLoadTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadTables.FlatAppearance.BorderSize = 0;
            this.btnLoadTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnLoadTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTables.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTables.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadTables.Location = new System.Drawing.Point(199, 12);
            this.btnLoadTables.Name = "btnLoadTables";
            this.btnLoadTables.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadTables.Size = new System.Drawing.Size(119, 29);
            this.btnLoadTables.TabIndex = 38;
            this.btnLoadTables.Text = "Load Tables";
            this.btnLoadTables.UseVisualStyleBackColor = false;
            this.btnLoadTables.Click += new System.EventHandler(this.btnLoadTables_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 506);
            this.dataGridView1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "No table being viewed...";
            // 
            // TableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(466, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadTables);
            this.Controls.Add(this.tableNamesSelection);
            this.Name = "TableViewer";
            this.Text = "TableViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableNamesSelection;
        private System.Windows.Forms.Button btnLoadTables;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

namespace Transfiguration
{
    partial class CustomSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomSQL));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sqlUseCheckbox = new System.Windows.Forms.CheckBox();
            this.customSqlTextbox = new System.Windows.Forms.RichTextBox();
            this.customSqlExecuteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom SQL";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(17, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 284);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // sqlUseCheckbox
            // 
            this.sqlUseCheckbox.AutoSize = true;
            this.sqlUseCheckbox.FlatAppearance.BorderSize = 0;
            this.sqlUseCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.sqlUseCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlUseCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sqlUseCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.sqlUseCheckbox.Location = new System.Drawing.Point(17, 379);
            this.sqlUseCheckbox.Name = "sqlUseCheckbox";
            this.sqlUseCheckbox.Size = new System.Drawing.Size(385, 19);
            this.sqlUseCheckbox.TabIndex = 3;
            this.sqlUseCheckbox.Text = "I accept the risks of corruption, and confirm I am able to use SQL.\r\n";
            this.sqlUseCheckbox.UseVisualStyleBackColor = true;
            this.sqlUseCheckbox.CheckedChanged += new System.EventHandler(this.sqlUseCheckbox_CheckedChanged);
            // 
            // customSqlTextbox
            // 
            this.customSqlTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customSqlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customSqlTextbox.Enabled = false;
            this.customSqlTextbox.ForeColor = System.Drawing.Color.White;
            this.customSqlTextbox.Location = new System.Drawing.Point(17, 405);
            this.customSqlTextbox.Name = "customSqlTextbox";
            this.customSqlTextbox.Size = new System.Drawing.Size(442, 96);
            this.customSqlTextbox.TabIndex = 4;
            this.customSqlTextbox.Text = "";
            // 
            // customSqlExecuteBtn
            // 
            this.customSqlExecuteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customSqlExecuteBtn.Enabled = false;
            this.customSqlExecuteBtn.FlatAppearance.BorderSize = 0;
            this.customSqlExecuteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.customSqlExecuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSqlExecuteBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customSqlExecuteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.customSqlExecuteBtn.Location = new System.Drawing.Point(17, 507);
            this.customSqlExecuteBtn.Name = "customSqlExecuteBtn";
            this.customSqlExecuteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customSqlExecuteBtn.Size = new System.Drawing.Size(119, 29);
            this.customSqlExecuteBtn.TabIndex = 37;
            this.customSqlExecuteBtn.Text = "Execute";
            this.customSqlExecuteBtn.UseVisualStyleBackColor = false;
            this.customSqlExecuteBtn.Click += new System.EventHandler(this.customSqlExecuteBtn_Click);
            // 
            // CustomSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(534, 663);
            this.Controls.Add(this.customSqlExecuteBtn);
            this.Controls.Add(this.customSqlTextbox);
            this.Controls.Add(this.sqlUseCheckbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "CustomSQL";
            this.Text = "CustomSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox sqlUseCheckbox;
        private System.Windows.Forms.RichTextBox customSqlTextbox;
        private System.Windows.Forms.Button customSqlExecuteBtn;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transfiguration
{
    public partial class MainApp : Form
    {
        public string connectionString = "";
        string targetPath = Application.StartupPath + "\\build\\Phoenix\\Content\\SQLiteDB";

        SQLiteDataReader dr;

        string isActive;

        private void OpenDBFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "db files (*.sqlite)|*.sqlite";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                File.Copy(ofd.FileName, targetPath + "\\PhoenixShipData.sqlite", true);
                dbLabel.Text = "Database Loaded!";
                connectionString = targetPath + "\\PhoenixShipData.sqlite";
                btnTablesDropdown.Enabled = true;
                btnCustomSQL.Enabled = true;
                btnTableViewer.Enabled = true;
                MessageBox.Show("Database successfully copied. The new DB file can be found in " + targetPath);
            }
        }

        public MainApp()
        {
            InitializeComponent();
            SetPanels();
        }

        private void SetPanels()
        {
            panel2.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            openChildForm(new Welcome());
        }

        private void btnTablesDropdown_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnBeasts_Click(object sender, EventArgs e)
        {
            this.Text = "Transfiguration ~ Beasts";
            openChildForm(new BeastsOptions(connectionString));
            hideSubMenu();
        }

        private void btnPotions_Click(object sender, EventArgs e)
        {
            this.Text = "Transfiguration ~ Potions";
            hideSubMenu();
            openChildForm(new PotionOptions(connectionString));
        }

        private void btnROR_Click(object sender, EventArgs e)
        {
            this.Text = "Transfiguration ~ Room of Requirement";
            hideSubMenu();
            openChildForm(new ROROptions(connectionString));
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {
            this.Text = "Transfiguration ~ Potions";
            hideSubMenu();
            openChildForm(new SpellOptions(connectionString));
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openChildForm(new Welcome());
            hideSubMenu();
            OpenDBFile();
        }

        private void btnCustomSQL_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Transfiguration ~ Custom SQL";
            openChildForm(new CustomSQL(connectionString));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Transfiguration ~ Help";
            openChildForm(new Help());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Transfiguration ~ Table Viewer";
            openChildForm(new TableViewer(connectionString));
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Transfiguration ~ Plants";
            openChildForm(new PlantOptions(connectionString));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Transfiguration ~ Items";
            openChildForm(new ItemOptions(connectionString));
        }
    }
}

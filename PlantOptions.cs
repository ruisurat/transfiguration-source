using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transfiguration
{
    public partial class PlantOptions : Form
    {
        SQLiteDataReader dr;

        public PlantOptions(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void GetPlantsData(string plant)
        {
            multiHarvestableCheckbox.Checked = false;
            try
            {
                var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
                con.Open();

                var cmd = new SQLiteCommand("SELECT Tier, Plant_Product, PlotSize, GrowthTimeSec, IsMultiHarvestable, RegrowthTimeSec, Yield_Planted, Yield_Foraged FROM PlantDefinition WHERE PlantID='" + plant + "'", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    plantTierValue.Value = dr.GetInt32(0);
                    byProductSelection.SelectedIndex = byProductSelection.FindStringExact(dr.GetString(1));
                    potSizeSelection.SelectedIndex = potSizeSelection.FindStringExact(dr.GetString(2));
                    initGrowthValue.Value = dr.GetInt32(3);
                    if (dr.GetInt32(4) == 1)
                        multiHarvestableCheckbox.Checked = true;
                    regrowthValue.Value = dr.GetInt32(5);
                    hrvstYieldValue.Value = dr.GetInt32(6);
                    frgYieldValue.Value = dr.GetInt32(7);
                }
            }
            catch
            {

            }
        }

        private void UpdatePlantsData(string plant)
        {
            int multiHarvest = 0;

            if (multiHarvestableCheckbox.Checked) multiHarvest = 1;

            try
            {
                var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
                con.Open();

                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "UPDATE PlantDefinition SET " +
                    "Tier = @tier, " +
                    "Plant_Product = @product, " +
                    "PlotSize = @plot, " +
                    "GrowthTimeSec = @initGrowth, " +
                    "IsMultiHarvestable = @multi, " +
                    "RegrowthTimeSec = @regrowth, " +
                    "Yield_Planted = @plantedYield, " +
                    "Yield_Foraged = @frgYield WHERE PlantID='" + plant + "'";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@tier", plantTierValue.Value);
                cmd.Parameters.AddWithValue("@product", byProductSelection.Text);
                cmd.Parameters.AddWithValue("@plot", potSizeSelection.Text);
                cmd.Parameters.AddWithValue("@initGrowth", initGrowthValue.Value);
                cmd.Parameters.AddWithValue("@multi", multiHarvest);
                cmd.Parameters.AddWithValue("@regrowth", regrowthValue.Value);
                cmd.Parameters.AddWithValue("@plantedYield", hrvstYieldValue.Value);
                cmd.Parameters.AddWithValue("@frgYield", frgYieldValue.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show(plant + " updated successfully!", "Transfiguration ~ Success!");
            }
            catch
            {
                MessageBox.Show("Can't update value.", "Transfiguration ~ Error!");
                return;
            }
        }

        private void plantSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdatePlantDb.Enabled = true;
            if (this.ConnectionString != "")
            {
                GetPlantsData(plantSelectionBox.Text);
            }
            else
            {
            }
        }

        private void btnUpdatePlantDb_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Please keep in mind some things are untested, and issues can occur with editing certain values. Are you sure you want to edit " + plantSelectionBox.Text + "'s values?", "Transfiguration ~ Warning!", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                UpdatePlantsData(plantSelectionBox.Text);
            }
        }
    }
}

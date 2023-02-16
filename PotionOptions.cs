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
    public partial class PotionOptions : Form
    {
        SQLiteDataReader dr;


        public PotionOptions(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void GetPotionsData(string potion)
        {
            try
            {
                var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
                con.Open();

                var cmd = new SQLiteCommand("SELECT PotionTypeID, Ingredient1, Quantity1, Ingredient2, Quantity2, Ingredient3, Quantity3, Ingredient4, Quantity4, Ingredient5, Quantity5, Ingredient6, Quantity6, TimeToBrewSec, Yield FROM PotionDefinition WHERE PotionID=\"" + potion + "\"", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var ing1Quantity = dr.GetValue(2);
                    var ing2Quantity = dr.GetValue(4);
                    var ing3Quantity = dr.GetValue(6);
                    var ing4Quantity = dr.GetValue(8);
                    var ing5Quantity = dr.GetValue(10);
                    var ing6Quantity = dr.GetValue(12);

                    potionTypeSelection.SelectedIndex = potionTypeSelection.FindStringExact(dr.GetValue(0).ToString());

                    if (dr[2].GetType() != typeof(DBNull))
                        ingredient1QuantityValue.Value = Int32.Parse(ing1Quantity.ToString());
                    else
                        ingredient1QuantityValue.Value = 0;

                    if (dr[4].GetType() != typeof(DBNull))
                        ingredient2QuantityValue.Value = Int32.Parse(ing2Quantity.ToString());
                    else
                        ingredient2QuantityValue.Value = 0;

                    if (dr[6].GetType() != typeof(DBNull))
                        ingredient3QuantityValue.Value = Int32.Parse(ing3Quantity.ToString());
                    else
                        ingredient3QuantityValue.Value = 0;

                    if (dr[8].GetType() != typeof(DBNull))
                        ingredient4QuantityValue.Value = Int32.Parse(ing4Quantity.ToString());
                    else
                        ingredient4QuantityValue.Value = 0;

                    if (dr[10].GetType() != typeof(DBNull))
                        ingredient5QuantityValue.Value = Int32.Parse(ing5Quantity.ToString());
                    else
                        ingredient5QuantityValue.Value = 0;

                    if (dr[12].GetType() != typeof(DBNull))
                        ingredient6QuantityValue.Value = Int32.Parse(ing6Quantity.ToString());
                    else
                        ingredient6QuantityValue.Value = 0;

                    ingredient1Selection.SelectedIndex = ingredient1Selection.FindStringExact(dr.GetValue(1).ToString());
                    ingredient2Selection.SelectedIndex = ingredient2Selection.FindStringExact(dr.GetValue(3).ToString());
                    ingredient3Selection.SelectedIndex = ingredient3Selection.FindStringExact(dr.GetValue(5).ToString());
                    ingredient4Selection.SelectedIndex = ingredient4Selection.FindStringExact(dr.GetValue(7).ToString());
                    ingredient5Selection.SelectedIndex = ingredient5Selection.FindStringExact(dr.GetValue(9).ToString());
                    ingredient6Selection.SelectedIndex = ingredient6Selection.FindStringExact(dr.GetValue(11).ToString());
                    potionBrewTimeValue.Value = Int32.Parse(dr.GetValue(13).ToString());
                    potionYieldValue.Value = Int32.Parse(dr.GetValue(14).ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please open a supported DB file.", "Transfiguration ~ Error!");
            }
        }

        private void UpdatePotionsData(string potion)
        {
            var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
            con.Open();

            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE PotionDefinition SET " +
                    "PotionTypeID=@potionTypeID," +
                    "Ingredient1=@ingredient1," +
                    "Quantity1=@quantity1," +
                    "Ingredient2=@ingredient2," +
                    "Quantity2=@quantity2," +
                    "Ingredient3=@ingredient3," +
                    "Quantity3=@quantity3," +
                    "Ingredient4=@ingredient4," +
                    "Quantity4=@quantity4," +
                    "Ingredient5=@ingredient5," +
                    "Quantity5=@quantity5," +
                    "Ingredient6=@ingredient6," +
                    "Quantity6=@quantity6," +
                    "TimeToBrewSec=@timeToBrew," +
                    "Yield=@yield WHERE PotionID=\"" + potion + "\"";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@potionTypeID", potionTypeSelection.Text);
                cmd.Parameters.AddWithValue("@ingredient1", ingredient1Selection.Text);
                cmd.Parameters.AddWithValue("@quantity1", ingredient2QuantityValue.Value);
                cmd.Parameters.AddWithValue("@ingredient2", ingredient2Selection.Text);
                cmd.Parameters.AddWithValue("@quantity2", ingredient2QuantityValue.Value);
                cmd.Parameters.AddWithValue("@ingredient3", ingredient3Selection.Text);
                cmd.Parameters.AddWithValue("@quantity3", ingredient3QuantityValue.Value);
                cmd.Parameters.AddWithValue("@ingredient4", ingredient4Selection.Text);
                cmd.Parameters.AddWithValue("@quantity4", ingredient4QuantityValue.Value);
                cmd.Parameters.AddWithValue("@ingredient5", ingredient5Selection.Text);
                cmd.Parameters.AddWithValue("@quantity5", ingredient5QuantityValue.Value);
                cmd.Parameters.AddWithValue("@ingredient6", ingredient6Selection.Text);
                cmd.Parameters.AddWithValue("@quantity6", ingredient6QuantityValue.Value);
                cmd.Parameters.AddWithValue("@timeToBrew", potionBrewTimeValue.Value);
                cmd.Parameters.AddWithValue("@yield", potionYieldValue.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show(potion + " updated successfully!", "Transfiguration ~ Success!");
            }
            catch
            {
                MessageBox.Show("Can't update value.");
                return;
            }
        }

        private void potionSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void potionSelectionBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            potionsUpdateDbBtn.Enabled = true;
            if (this.ConnectionString != "")
            {
                GetPotionsData(potionSelectionBox.Text);
            }
            else
            {
            }
        }

        private void potionsUpdateDbBtn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Please keep in mind some things are untested, and issues can occur with editing certain values. Are you sure you want to edit " + potionSelectionBox.Text + "'s values?", "Transfiguration ~ Warning!", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                UpdatePotionsData(potionSelectionBox.Text);
            }
        }
    }
}

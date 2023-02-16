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
    public partial class BeastsOptions : Form
    {
        SQLiteDataReader dr;
        public BeastsOptions(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void GetBeastsData(string beast)
        {
            canBeCapturedValue.Checked = false;
            isCarnivoreValue.Checked = false;
            isAggressiveValue.Checked = false;
            var con = new SQLiteConnection(@"Data Source = " + this.ConnectionString);
            con.Open();

            try
            {
                var cmd = new SQLiteCommand("SELECT ByProduct, ByproductHarvestCount, ByproductProductionTimeSec, PreferredToy, Conflict1, Conflict2, CanBeCaptured, CompletedYearForCapture, CapturingTime, CapturingGates, CapturingDistanceMax, isCarnivore, isAgressive, BaseEconomyValue, MinShutdownDistance, MaxShutdownDistance, RenderShutdownDistance  FROM CreatureDefinition WHERE CreatureID=\"" + beast + "\"", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    beastsByproductSelection.SelectedIndex = beastsByproductSelection.FindStringExact(dr.GetString(0));
                    byProductHarvestValue.Value = dr.GetInt32(1);
                    byProductTimeValue.Value = dr.GetDecimal(2);
                    preferredToySelection.SelectedIndex = preferredToySelection.FindStringExact(dr.GetString(3));

                    if (dr[4] != null)
                    {
                        var value = dr.GetValue(4);
                        conflict1Selection.SelectedIndex = conflict1Selection.FindStringExact(value.ToString());
                    }
                    if (dr[5] != null)
                    {
                        var value = dr.GetValue(5);
                        conflict2Selection.SelectedIndex = conflict2Selection.FindStringExact(value.ToString());
                    }

                    if (dr.GetInt32(6) == 1)
                    {
                        canBeCapturedValue.Checked = true;
                    }

                    yearToCaptureValue.Value = dr.GetInt32(7);
                    capturingTimeValue.Value = dr.GetDecimal(8);
                    captureGatesValue.Value = dr.GetInt32(9);
                    captureDistanceValue.Value = dr.GetInt32(10);

                    if (dr.GetInt32(11) == 1)
                    {
                        isCarnivoreValue.Checked = true;
                    }

                    if (dr.GetInt32(12) == 1)
                    {
                        isAggressiveValue.Checked = true;
                    }

                    beastsEconomyValue.Value = dr.GetInt32(13);
                    shutdownDistanceMinValue.Value = dr.GetDecimal(14);
                    shutdownDistanceMaxValue.Value = dr.GetDecimal(15);
                    renderShutdownDistanceValue.Value = dr.GetDecimal(16);
                }
            }
            catch
            {
                MessageBox.Show("Please open a supported DB file.", "Transfiguration ~ Error!");
            }
        }

        private void UpdateBeastData(string beast)
        {
            int canBeCaptured = 0, isCarnivore = 0, isAggressive = 0;

            if (canBeCapturedValue.Checked) canBeCaptured = 1;
            if (isCarnivoreValue.Checked) isCarnivore = 1;
            if (isAggressiveValue.Checked) isAggressive = 1;

            var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                if (conflict1Selection.Text != "" && conflict2Selection.Text != "")
                {
                    cmd.CommandText = "UPDATE CreatureDefinition SET " +
                        "ByProduct=@byProduct, " +
                        "ByproductHarvestCount=@byproductHarvestCount, " +
                        "ByproductProductionTimeSec=@byproductProductionTimeSec, " +
                        "PreferredToy=@preferredToy, " +
                        "Conflict1=@conflict1, " +
                        "Conflict2=@conflict2, " +
                        "CanBeCaptured=@canBeCaptured, " +
                        "CompletedYearForCapture=@completedYearForCapture, " +
                        "CapturingTime=@capturingTime, " +
                        "CapturingGates=@capturingGates, " +
                        "CapturingDistanceMax=@capturingDistanceMax, " +
                        "isCarnivore=@isCarnivore, " +
                        "isAgressive=@isAggressive, " +
                        "BaseEconomyValue=@baseEconomyValue, " +
                        "MinShutdownDistance=@minShutdownDistance, " +
                        "MaxShutdownDistance=@maxShutdownDistance, " +
                        "RenderShutdownDistance=@renderShutdownDistance WHERE CreatureID=\"" + beast + "\"";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@byProduct", beastsByproductSelection.Text);
                    cmd.Parameters.AddWithValue("@byproductHarvestCount", byProductHarvestValue.Value);
                    cmd.Parameters.AddWithValue("@byproductProductionTimeSec", byProductTimeValue.Value);
                    cmd.Parameters.AddWithValue("@preferredToy", preferredToySelection.Text);
                    cmd.Parameters.AddWithValue("@conflict1", conflict1Selection.Text);
                    cmd.Parameters.AddWithValue("@conflict2", conflict2Selection.Text);
                    cmd.Parameters.AddWithValue("@canBeCaptured", canBeCaptured);
                    cmd.Parameters.AddWithValue("@completedYearForCapture", yearToCaptureValue.Value);
                    cmd.Parameters.AddWithValue("@capturingTime", capturingTimeValue.Value);
                    cmd.Parameters.AddWithValue("@capturingGates", captureGatesValue.Value);
                    cmd.Parameters.AddWithValue("@capturingDistanceMax", captureDistanceValue.Value);
                    cmd.Parameters.AddWithValue("@isCarnivore", isCarnivore);
                    cmd.Parameters.AddWithValue("@isAggressive", isAggressive);
                    cmd.Parameters.AddWithValue("@baseEconomyValue", beastsEconomyValue.Value);
                    cmd.Parameters.AddWithValue("@minShutdownDistance", shutdownDistanceMinValue.Value);
                    cmd.Parameters.AddWithValue("@maxShutdownDistance", shutdownDistanceMaxValue.Value);
                    cmd.Parameters.AddWithValue("@renderShutdownDistance", renderShutdownDistanceValue.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(beast + " updated successfully!", "Transfiguration ~ Success!");
                }
                else if (conflict1Selection.Text != "" && conflict2Selection.Text == "")
                {
                    cmd.CommandText = "UPDATE CreatureDefinition SET " +
                        "ByProduct=@byProduct, " +
                        "ByproductHarvestCount=@byproductHarvestCount, " +
                        "ByproductProductionTimeSec=@byproductProductionTimeSec, " +
                        "PreferredToy=@preferredToy, " +
                        "Conflict1=@conflict1, " +
                        "CanBeCaptured=@canBeCaptured, " +
                        "CompletedYearForCapture=@completedYearForCapture, " +
                        "CapturingTime=@capturingTime, " +
                        "CapturingGates=@capturingGates, " +
                        "CapturingDistanceMax=@capturingDistanceMax, " +
                        "isCarnivore=@isCarnivore, " +
                        "isAgressive=@isAggressive, " +
                        "BaseEconomyValue=@baseEconomyValue, " +
                        "MinShutdownDistance=@minShutdownDistance, " +
                        "MaxShutdownDistance=@maxShutdownDistance, " +
                        "RenderShutdownDistance=@renderShutdownDistance WHERE CreatureID=\"" + beast + "\"";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@byProduct", beastsByproductSelection.Text);
                    cmd.Parameters.AddWithValue("@byproductHarvestCount", byProductHarvestValue.Value);
                    cmd.Parameters.AddWithValue("@byproductProductionTimeSec", byProductTimeValue.Value);
                    cmd.Parameters.AddWithValue("@preferredToy", preferredToySelection.Text);
                    cmd.Parameters.AddWithValue("@conflict1", conflict1Selection.Text);
                    cmd.Parameters.AddWithValue("@canBeCaptured", canBeCaptured);
                    cmd.Parameters.AddWithValue("@completedYearForCapture", yearToCaptureValue.Value);
                    cmd.Parameters.AddWithValue("@capturingTime", capturingTimeValue.Value);
                    cmd.Parameters.AddWithValue("@capturingGates", captureGatesValue.Value);
                    cmd.Parameters.AddWithValue("@capturingDistanceMax", captureDistanceValue.Value);
                    cmd.Parameters.AddWithValue("@isCarnivore", isCarnivore);
                    cmd.Parameters.AddWithValue("@isAggressive", isAggressive);
                    cmd.Parameters.AddWithValue("@baseEconomyValue", beastsEconomyValue.Value);
                    cmd.Parameters.AddWithValue("@minShutdownDistance", shutdownDistanceMinValue.Value);
                    cmd.Parameters.AddWithValue("@maxShutdownDistance", shutdownDistanceMaxValue.Value);
                    cmd.Parameters.AddWithValue("@renderShutdownDistance", renderShutdownDistanceValue.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(beast + " updated successfully!", "Transfiguration ~ Success!");
                }
                else
                {
                    cmd.CommandText = "UPDATE CreatureDefinition SET " +
                        "ByProduct=@byProduct, " +
                        "ByproductHarvestCount=@byproductHarvestCount, " +
                        "ByproductProductionTimeSec=@byproductProductionTimeSec, " +
                        "PreferredToy=@preferredToy, " +
                        "CanBeCaptured=@canBeCaptured, " +
                        "CompletedYearForCapture=@completedYearForCapture, " +
                        "CapturingTime=@capturingTime, " +
                        "CapturingGates=@capturingGates, " +
                        "CapturingDistanceMax=@capturingDistanceMax, " +
                        "isCarnivore=@isCarnivore, " +
                        "isAgressive=@isAggressive, " +
                        "BaseEconomyValue=@baseEconomyValue, " +
                        "MinShutdownDistance=@minShutdownDistance, " +
                        "MaxShutdownDistance=@maxShutdownDistance, " +
                        "RenderShutdownDistance=@renderShutdownDistance WHERE CreatureID=\"" + beast + "\"";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@byProduct", beastsByproductSelection.Text);
                    cmd.Parameters.AddWithValue("@byproductHarvestCount", byProductHarvestValue.Value);
                    cmd.Parameters.AddWithValue("@byproductProductionTimeSec", byProductTimeValue.Value);
                    cmd.Parameters.AddWithValue("@preferredToy", preferredToySelection.Text);
                    cmd.Parameters.AddWithValue("@canBeCaptured", canBeCaptured);
                    cmd.Parameters.AddWithValue("@completedYearForCapture", yearToCaptureValue.Value);
                    cmd.Parameters.AddWithValue("@capturingTime", capturingTimeValue.Value);
                    cmd.Parameters.AddWithValue("@capturingGates", captureGatesValue.Value);
                    cmd.Parameters.AddWithValue("@capturingDistanceMax", captureDistanceValue.Value);
                    cmd.Parameters.AddWithValue("@isCarnivore", isCarnivore);
                    cmd.Parameters.AddWithValue("@isAggressive", isAggressive);
                    cmd.Parameters.AddWithValue("@baseEconomyValue", beastsEconomyValue.Value);
                    cmd.Parameters.AddWithValue("@minShutdownDistance", shutdownDistanceMinValue.Value);
                    cmd.Parameters.AddWithValue("@maxShutdownDistance", shutdownDistanceMaxValue.Value);
                    cmd.Parameters.AddWithValue("@renderShutdownDistance", renderShutdownDistanceValue.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(beast + " updated successfully!", "Transfiguration ~ Success!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't update value.", "Transfiguration ~ Error!");
                return;
            }
        }

        private void beastsSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void beastsSelectionBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            beastsUpdateFieldBtn.Enabled = true;
            if (this.ConnectionString != "")
            {
                GetBeastsData(beastsSelectionBox.Text);
            }
            else
            {
                MessageBox.Show("There's currently no database loaded.", "Transfiguration ~ Error!");
            }
        }

        private void beastsUpdateFieldBtn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Please keep in mind some things are untested, and issues can occur with editing certain values. Are you sure you want to edit " + beastsSelectionBox.Text + "'s values?", "Transfiguration ~ Warning!", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                UpdateBeastData(beastsSelectionBox.Text);
            }
        }
    }
}

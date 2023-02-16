using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace Transfiguration
{
    public partial class Form1 : Form
    {
        string connectionString;
        string targetPath = Application.StartupPath + "\\build\\Phoenix\\Content\\SQLiteDB";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        private void OpenDBFile()
        {
            bool isSupportedFile;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "db files (*.sqlite)|*.sqlite";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                File.Copy(ofd.FileName, targetPath + "\\PhoenixShipData.sqlite", true);

                fileNameTxt.Text = ofd.FileName;
                connectionString = targetPath + "\\PhoenixShipData.sqlite";
                tabControl1.Enabled = true;
                sqlUseCheckbox.Checked = false;
                sqlUseCheckbox.Enabled = true;
                MessageBox.Show("Please keep in mind when editing individual items you must press the \"UPDATE\" button before editing something else. This will likely be changed in a future update.", "Transfiguration ~ Information!");
            }
        }

        private void ConvertToMod()
        {
            string extractPath = Application.StartupPath + "\\builds";

            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.Write("UnrealPak.exe " + connectionString + " -Create=" + extractPath + "\\zUpdatedDB_P.pak");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
        }

        private void GetPotionsData(string potion)
        {
            var con = new SQLiteConnection(@"Data Source=" + connectionString);
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

        private void UpdatePotionsData(string potion)
        {
            var con = new SQLiteConnection(@"Data Source=" + connectionString);
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
            }
            catch
            {
                MessageBox.Show("Can't update value.");
                return;
            }
        }

        private void GetBeastsData(string beast)
        {
            canBeCapturedValue.Checked = false;
            isCarnivoreValue.Checked = false;
            isAggressiveValue.Checked = false;
            var con = new SQLiteConnection(@"Data Source = " + connectionString);
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

        private void CustomSQLExecution(string sql)
        {
            var con = new SQLiteConnection(@"Data Source=" + connectionString);
            con.Open();

            var cmd = new SQLiteCommand(con);
            
            try
            {
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Field updated successfully!", "Transfiguration ~ Success!");
            }
            catch
            {
                MessageBox.Show("The SQL command you've attempted to execute was invalid. If you're struggling, please refer to https://learntocodewith.me/posts/sql-guide/", "Transfiguration ~ Error!");
            }
        }

        private void UpdateBeastData(string beast)
        {
            int canBeCaptured = 0, isCarnivore = 0, isAggressive = 0;

            if (canBeCapturedValue.Checked) canBeCaptured = 1;
            if (isCarnivoreValue.Checked) isCarnivore = 1;
            if (isAggressiveValue.Checked) isAggressive = 1;

            var con = new SQLiteConnection(@"Data Source=" + connectionString);
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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't update value.");
                return;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void fileOpenBtn_Click(object sender, EventArgs e)
        {
            OpenDBFile();
        }

        private void beastsSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            beastsUpdateFieldBtn.Enabled = true;
            if (connectionString != "")
            {
                GetBeastsData(beastsSelectionBox.Text);
            } else
            {
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlUseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            sqlUseCheckbox.Enabled = false;
            customSqlTextBox.Enabled = true;
            customSqlExecuteBtn.Enabled = true;
            DialogResult d = MessageBox.Show("By clicking yes you confirm you're experienced with SQL, and know exactly what you're editing. Not understanding how to use SQL commands may break the DB and render it unusable.", "Transfiguration ~ Warning!");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("For now, the tool doesn't convert the SQLite file automatically to .pak. A guide on how to do so can be found in the readme.txt packaged with the tool. Thanks for using Transfiguration! <3", "Transfiguration ~ Information!", MessageBoxButtons.OK);

        }

        private void customSqlExecuteBtn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to execute the following SQL command? Command: " + customSqlTextBox.Text, "Transfiguration ~ Warning!", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                CustomSQLExecution(customSqlTextBox.Text);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void shutdownDistanceMaxValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void potionSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            potionsUpdateDbBtn.Enabled = true;
            if (connectionString != "")
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

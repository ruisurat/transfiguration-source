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
    public partial class ROROptions : Form
    {
        SQLiteDataReader dr;

        List<int> conjurationData = new List<int>();
        List<int> creatureData = new List<int>();
        List<int> speciesData = new List<int>();
        List<int> cyfcData = new List<int>();

        public ROROptions(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void GetRORData()
        {
            var con = new SQLiteConnection(@"Data Source = " + this.ConnectionString);
            con.Open();

            

            try
            {
                var cmd = new SQLiteCommand("SELECT PoolStartAmount FROM TransfigurationSlotPools", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    conjurationData.Add(dr.GetInt32(0));
                }

                cmd = new SQLiteCommand("SELECT MaxNumCreatures, MaxNumSpecies, MaxCreatureCompletedYearForCapture FROM NurturingSpaceDefinition", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    creatureData.Add(dr.GetInt32(0));
                    speciesData.Add(dr.GetInt32(1));
                    cyfcData.Add(dr.GetInt32(2));
                }

                feederMaxValue.Value = conjurationData[0];
                chopMaxValue.Value = conjurationData[1];
                ddMaxValue.Value = conjurationData[2];
                dungMaxValue.Value = conjurationData[3];
                hopMaxValue.Value = conjurationData[4];
                matMaxValue.Value = conjurationData[5];
                toyMaxValue.Value = conjurationData[6];
                herbMaxValue.Value = conjurationData[7];
                potionsMaxValue.Value = conjurationData[8];

                b1CreatureMax.Value = creatureData[0];
                b2CreatureMax.Value = creatureData[1];
                b3CreatureMax.Value = creatureData[2];
                coastCreatureMax.Value = creatureData[3];
                forestCreatureMax.Value = creatureData[4];
                grassCreatureMax.Value = creatureData[5];
                swampCreatureMax.Value = creatureData[6];

                b1SpeciesMax.Value = speciesData[0];
                b2SpeciesMax.Value = speciesData[1];
                b3SpeciesMax.Value = speciesData[2];
                coastSpeciesMax.Value = speciesData[3];
                forestSpeciesMax.Value = speciesData[4];
                grassSpeciesMax.Value = speciesData[5];
                swampSpeciesMax.Value = speciesData[6];

                b1CYFC.Value = cyfcData[0];
                b2CYFC.Value = cyfcData[1];
                b3CYFC.Value = cyfcData[2];
                coastCYFC.Value = cyfcData[3];
                forestCYFC.Value = cyfcData[4];
                grassCYFC.Value = cyfcData[5];
                swampCYFC.Value = cyfcData[6];
            }
            catch
            {
                MessageBox.Show("Please open a supported DB file.", "Transfiguration ~ Error!");
            }
        }

        private void UpdateRORData()
        {
            var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
            con.Open();
            try
            {
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "UPDATE TransfigurationSlotPools " +
                    "SET PoolStartAmount = CASE TransfigSlotID " +
                    "WHEN 'BeastFeederSlot' THEN @beast " +
                    "WHEN 'ChoppingTableSlot' THEN @chop " +
                    "WHEN 'DeskDescriptionSlot' THEN @desk " +
                    "WHEN 'DungComposterSlot' THEN @dung " +
                    "WHEN 'HoppingPotSlot' THEN @hop " +
                    "WHEN 'MatRefinerSlot' THEN @mat " +
                    "WHEN 'ToyboxSlot' THEN @toy " +
                    "WHEN 'WorkstationSlot_Herb' THEN @herb " +
                    "WHEN 'WorkstationSlot_Pot' THEN @pot END;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@beast", feederMaxValue.Value);
                cmd.Parameters.AddWithValue("@chop", chopMaxValue.Value);
                cmd.Parameters.AddWithValue("@desk", ddMaxValue.Value);
                cmd.Parameters.AddWithValue("@dung", dungMaxValue.Value);
                cmd.Parameters.AddWithValue("@hop", hopMaxValue.Value);
                cmd.Parameters.AddWithValue("@mat", matMaxValue.Value);
                cmd.Parameters.AddWithValue("@toy", toyMaxValue.Value);
                cmd.Parameters.AddWithValue("@herb", herbMaxValue.Value);
                cmd.Parameters.AddWithValue("@pot", potionsMaxValue.Value);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE NurturingSpaceDefinition " +
                    "SET MaxNumCreatures = CASE NurturingSpaceID " +
                    "WHEN 'Beast_Class' THEN @b1 " +
                    "WHEN 'Beast_Class2' THEN @b2 " +
                    "WHEN 'Beast_Class3' THEN @b3 " +
                    "WHEN 'NV_Biome_Coastal' THEN @coast " +
                    "WHEN 'NV_Biome_Forest' THEN @forest " +
                    "WHEN 'NV_Biome_Grassland' THEN @grass " +
                    "WHEN 'NV_Biome_SWAMP' THEN @swamp END;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@b1", b1CreatureMax.Value);
                cmd.Parameters.AddWithValue("@b2", b2CreatureMax.Value);
                cmd.Parameters.AddWithValue("@b3", b3CreatureMax.Value);
                cmd.Parameters.AddWithValue("@coast", coastCreatureMax.Value);
                cmd.Parameters.AddWithValue("@forest", forestCreatureMax.Value);
                cmd.Parameters.AddWithValue("@grass", grassCreatureMax.Value);
                cmd.Parameters.AddWithValue("@swamp", swampCreatureMax.Value);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE NurturingSpaceDefinition " +
                    "SET MaxNumSpecies = CASE NurturingSpaceID " +
                    "WHEN 'Beast_Class' THEN @b1 " +
                    "WHEN 'Beast_Class2' THEN @b2 " +
                    "WHEN 'Beast_Class3' THEN @b3 " +
                    "WHEN 'NV_Biome_Coastal' THEN @coast " +
                    "WHEN 'NV_Biome_Forest' THEN @forest " +
                    "WHEN 'NV_Biome_Grassland' THEN @grass " +
                    "WHEN 'NV_Biome_SWAMP' THEN @swamp END;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@b1", b1SpeciesMax.Value);
                cmd.Parameters.AddWithValue("@b2", b2SpeciesMax.Value);
                cmd.Parameters.AddWithValue("@b3", b3SpeciesMax.Value);
                cmd.Parameters.AddWithValue("@coast", coastSpeciesMax.Value);
                cmd.Parameters.AddWithValue("@forest", forestSpeciesMax.Value);
                cmd.Parameters.AddWithValue("@grass", grassSpeciesMax.Value);
                cmd.Parameters.AddWithValue("@swamp", swampSpeciesMax.Value);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE NurturingSpaceDefinition " +
                    "SET MaxCreatureCompletedYearForCapture = CASE NurturingSpaceID " +
                    "WHEN 'Beast_Class' THEN @b1 " +
                    "WHEN 'Beast_Class2' THEN @b2 " +
                    "WHEN 'Beast_Class3' THEN @b3 " +
                    "WHEN 'NV_Biome_Coastal' THEN @coast " +
                    "WHEN 'NV_Biome_Forest' THEN @forest " +
                    "WHEN 'NV_Biome_Grassland' THEN @grass " +
                    "WHEN 'NV_Biome_SWAMP' THEN @swamp END;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@b1", b1CYFC.Value);
                cmd.Parameters.AddWithValue("@b2", b2CYFC.Value);
                cmd.Parameters.AddWithValue("@b3", b3CYFC.Value);
                cmd.Parameters.AddWithValue("@coast", coastCYFC.Value);
                cmd.Parameters.AddWithValue("@forest", forestCYFC.Value);
                cmd.Parameters.AddWithValue("@grass", grassCYFC.Value);
                cmd.Parameters.AddWithValue("@swamp", swampCYFC.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated the Room of Requirement's record.", "Transfiguration ~ Success!");
            }
            catch
            {
                MessageBox.Show("Couldn't update a record's values. Please try again.", "Transfiguration ~ Error!");
            }
        }

        private void ROROptions_Load(object sender, EventArgs e)
        {
            GetRORData();
        }

        private void rorUpdateDbBtn_Click(object sender, EventArgs e)
        {
            UpdateRORData();
        }
    }
}

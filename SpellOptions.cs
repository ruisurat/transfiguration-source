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
    public partial class SpellOptions : Form
    {
        SQLiteDataReader dr;
        public SpellOptions(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void GetSpellsData(string spell)
        {
            animateCheckBox.Checked = false;
            inAnimateCheckBox.Checked = false;
            plantCheckBox.Checked = false;
            waterCheckBox.Checked = false;
            deadCheckBox.Checked = false;
            beastCapCheckBox.Checked = false;
            upgradedCheckBox.Checked = false;
            objectImpactCheckBox.Checked = false;
            plyShieldBreakCheckBox.Checked = false;
            limitedCountCharacterCheckBox.Checked = false;
            limitedCountObjectCheckBox.Checked = false;

            var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
            con.Open();

            try
            {
                var cmd = new SQLiteCommand("SELECT Upgrade, Range, CooldownTime, NonCombatCooldownMultiplier, DamageObject, DamageCharacter, PhysicsImpulseSuccess, PhysicsImpulseFailed, ImpactType, SizeLimit, Duration, DurationCharacter, DurationCreature, DurationPlayer, ChargeTime, ChargedMaxTime, ChannelingMinTime, Animate, Inanimate, Plant, Dead, Water, UpgradedMechanics, PlayObjectImpactEffects, LimitedCountObject, LimitedCountCharacter, PlayerShieldBreaker, EnemyShieldBreaker, CastNoise, ImpactNoise, ProjectileSpeed, ProjectileGravity, BeastCapture FROM SpellDefinition WHERE SpellTypeID=\"" + spell + "\"", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    upgradeTypeSelection.SelectedIndex = upgradeTypeSelection.FindStringExact(dr.GetString(0));
                    spellRangeValue.Value = dr.GetDecimal(1);
                    spellCooldownValue.Value = dr.GetDecimal(2);
                    spellCooldownMultValue.Value = dr.GetDecimal(3);
                    spellDamageObjValue.Value = dr.GetDecimal(4);
                    spellDamageNPCValue.Value = dr.GetDecimal(5);
                    physicsImpulseSValue.Value = dr.GetDecimal(6);
                    physicsImpulseFValue.Value = dr.GetDecimal(7);
                    impactTypeSelection.SelectedIndex = impactTypeSelection.FindStringExact(dr.GetString(8));
                    sizeLimitSelection.SelectedIndex = sizeLimitSelection.FindStringExact(dr.GetString(9));
                    spellDurationValue.Value = dr.GetDecimal(10);
                    spellDurationCharValue.Value = dr.GetDecimal(11);
                    spellDurationCreatValue.Value = dr.GetDecimal(12);
                    spellDurationPlyValue.Value = dr.GetDecimal(13);
                    spellChargeTimeValue.Value = dr.GetDecimal(14);
                    spellChargedMaxValue.Value = dr.GetDecimal(15);
                    spellChannelingMinValue.Value = dr.GetDecimal(16);
                    if (dr[17].GetType() != typeof(DBNull))
                        if (dr.GetInt32(17) == 1)
                            animateCheckBox.Checked = true;
                    if (dr[18].GetType() != typeof(DBNull))
                        if (dr.GetInt32(18) == 1)
                            inAnimateCheckBox.Checked = true;
                    if (dr[19].GetType() != typeof(DBNull))
                        if (dr.GetInt32(19) == 1)
                            plantCheckBox.Checked = true;
                    if (dr[20].GetType() != typeof(DBNull))
                        if (dr.GetInt32(20) == 1)
                            deadCheckBox.Checked = true;
                    if (dr[21].GetType() != typeof(DBNull))
                        if (dr.GetInt32(21) == 1)
                            waterCheckBox.Checked = true;
                    if (dr[22].GetType() != typeof(DBNull))
                        if (dr.GetInt32(22) == 1)
                            upgradedCheckBox.Checked = true;
                    if (dr[23].GetType() != typeof(DBNull))
                        if (dr.GetInt32(23) == 1)
                            objectImpactCheckBox.Checked = true;
                    if (dr[24].GetType() != typeof(DBNull))
                        if (dr.GetInt32(24) == 1)
                            limitedCountObjectCheckBox.Checked = true;
                    if (dr[25].GetType() != typeof(DBNull))
                        if (dr.GetInt32(25) == 1)
                            limitedCountCharacterCheckBox.Checked = true;
                    if (dr[26].GetType() != typeof(DBNull))
                        if (dr.GetInt32(26) == 1)
                            limitedCountCharacterCheckBox.Checked = true;
                    enemyShieldBreakSelection.SelectedIndex = enemyShieldBreakSelection.FindStringExact(dr.GetString(27));
                    castNoiseSelection.SelectedIndex = castNoiseSelection.FindStringExact(dr.GetString(28));
                    impactNoiseSelection.SelectedIndex = impactNoiseSelection.FindStringExact(dr.GetString(29));
                    spellProjSpeedValue.Value = dr.GetDecimal(30);
                    spellProjGravValue.Value = dr.GetDecimal(31);
                    if (dr[32].GetType() != typeof(DBNull))
                        if (dr.GetInt32(32) == 1)
                            beastCapCheckBox.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Please open a supported DB file.", "Transfiguration ~ Error!");
            }
        }

        private void UpdateSpellData(string spell)
        {
            int animate = 0, inanimate = 0, plant = 0, water = 0, dead = 0, beast = 0, upgraded = 0, impact = 0, shield = 0, countChar = 0, countObj = 0;

            if (animateCheckBox.Checked) animate = 1;
            if (inAnimateCheckBox.Checked) inanimate = 1;
            if (plantCheckBox.Checked) plant = 1;
            if (waterCheckBox.Checked) water = 1;
            if (deadCheckBox.Checked) dead = 1;
            if (beastCapCheckBox.Checked) beast = 1;
            if (upgradedCheckBox.Checked) upgraded = 1;
            if (objectImpactCheckBox.Checked) impact = 1;
            if (plyShieldBreakCheckBox.Checked) shield = 1;
            if (limitedCountCharacterCheckBox.Checked) countChar = 1;
            if (limitedCountObjectCheckBox.Checked) countObj = 1;

            var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
            con.Open();

            try
            {
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "UPDATE SpellDefinition SET " +
                        "Upgrade=@upgrade," +
                        "Range=@range," +
                        "CooldownTime=@cooldownTime, " +
                        "NonCombatCooldownMultiplier=@cooldownMult, " +
                        "DamageObject=@dmgObj," +
                        "DamageCharacter=@dmgChar," +
                        "PhysicsImpulseSuccess=@physIS," +
                        "PhysicsImpulseFailed=@physIF," +
                        "ImpactType=@impactType," +
                        "SizeLimit=@sizeLimit," +
                        "Duration=@duration," +
                        "DurationCharacter=@durChar," +
                        "DurationCreature=@durCreat," +
                        "DurationPlayer=@durPly," +
                        "ChargeTime=@charge," +
                        "ChargedMaxTime=@chargeMax," +
                        "ChannelingMinTime=@channelMin," +
                        "Animate=@animate," +
                        "Inanimate=@inanimate," +
                        "Plant=@plant," +
                        "Dead=@dead," +
                        "Water=@water," +
                        "UpgradedMechanics=@upgraded," +
                        "PlayObjectImpactEffects=@impact," +
                        "LimitedCountObject=@countObj," +
                        "LimitedCountCharacter=@countChar," +
                        "PlayerShieldBreaker=@shield," +
                        "EnemyShieldBreaker=@shieldEnem," +
                        "CastNoise=@castNoise," +
                        "ImpactNoise=@impactNoise," +
                        "ProjectileSpeed=@projSpeed," +
                        "ProjectileGravity=@projGrav," +
                        "BeastCapture=@beast " +
                        "WHERE SpellTypeID=\"" + spell + "\"";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@upgrade", upgradeTypeSelection.Text);
                cmd.Parameters.AddWithValue("@range", spellRangeValue.Value);
                cmd.Parameters.AddWithValue("@cooldownTime", spellCooldownValue.Value);
                cmd.Parameters.AddWithValue("@cooldownMult", spellCooldownMultValue.Value);
                cmd.Parameters.AddWithValue("@dmgObj", spellDamageObjValue.Value);
                cmd.Parameters.AddWithValue("@dmgChar", spellDamageNPCValue.Value);
                cmd.Parameters.AddWithValue("@physIS", physicsImpulseSValue.Value);
                cmd.Parameters.AddWithValue("@physIF", physicsImpulseFValue.Value);
                cmd.Parameters.AddWithValue("@impactType", impactTypeSelection.Text);
                cmd.Parameters.AddWithValue("@sizeLimit", sizeLimitSelection.Text);
                cmd.Parameters.AddWithValue("@duration", spellDurationValue.Value);
                cmd.Parameters.AddWithValue("@durChar", spellDurationCharValue.Value);
                cmd.Parameters.AddWithValue("@durCreat", spellDurationCreatValue.Value);
                cmd.Parameters.AddWithValue("@durPly", spellDurationPlyValue.Value);
                cmd.Parameters.AddWithValue("@charge", spellChargeTimeValue.Value);
                cmd.Parameters.AddWithValue("@chargeMax", spellChargedMaxValue.Value);
                cmd.Parameters.AddWithValue("@channelMin", spellChannelingMinValue.Value);
                cmd.Parameters.AddWithValue("@animate", animate);
                cmd.Parameters.AddWithValue("@inanimate", inanimate);
                cmd.Parameters.AddWithValue("@plant", plant);
                cmd.Parameters.AddWithValue("@dead", dead);
                cmd.Parameters.AddWithValue("@water", water);
                cmd.Parameters.AddWithValue("@upgraded", upgraded);
                cmd.Parameters.AddWithValue("@impact", impact);
                cmd.Parameters.AddWithValue("@countObj", countObj);
                cmd.Parameters.AddWithValue("@countChar", countChar);
                cmd.Parameters.AddWithValue("@shield", shield);
                cmd.Parameters.AddWithValue("@shieldEnem", enemyShieldBreakSelection.Text);
                cmd.Parameters.AddWithValue("@castNoise", castNoiseSelection.Text);
                cmd.Parameters.AddWithValue("@impactNoise", impactNoiseSelection.Text);
                cmd.Parameters.AddWithValue("@projSpeed", spellProjSpeedValue.Value);
                cmd.Parameters.AddWithValue("@projGrav", spellProjGravValue.Value);
                cmd.Parameters.AddWithValue("@beast", beast);

                cmd.ExecuteNonQuery();
                MessageBox.Show(spell + " updated successfully!", "Transfiguration ~ Success!");
            }
            catch
            {
                MessageBox.Show("Couldn't update record. Please try again.", "Transfiguration ~ Error!");
                return;
            }
        }

        private void spellSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            spellsUpdateDbBtn.Enabled = true;
            if (this.ConnectionString != "")
            {
                GetSpellsData(spellSelectionBox.Text);
            }
            else
            {
                MessageBox.Show("There's currently no database loaded.", "Transfiguration ~ Error!");
            }
        }

        private void spellsUpdateDbBtn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Please keep in mind some things are untested, and issues can occur with editing certain values. Are you sure you want to edit " + spellSelectionBox.Text + "'s values?", "Transfiguration ~ Warning!", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                UpdateSpellData(spellSelectionBox.Text);
            }
        }
    }
}

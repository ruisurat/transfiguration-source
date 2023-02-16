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
    public partial class ItemOptions : Form
    {
        SQLiteDataReader dr;

        public ItemOptions(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void GetItemData(string item)
        {
            persistentCheck.Checked = false;
            inventoryCheck.Checked = false;
            giftableCheck.Checked = false;
            sellableCheck.Checked = false;
            dropableCheck.Checked = false;
            consumableCheck.Checked = false;
            triggerCheck.Checked = false;
            usableCheck.Checked = false;

            try
            {
                var con = new SQLiteConnection(@"Data Source = " + this.ConnectionString);
                con.Open();

                var cmd = new SQLiteCommand("SELECT ItemType, ItemType2, RarityTier, EconomyValue, SellPrice, Inventoryable, Persistent, Giftable, Sellable, Dropable, SlotLevel, Consumable, TriggerAbilityOnConsume, UsableOnDiamond, StorageLocation FROM ItemDefinition WHERE ItemID='" + item + "'", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    itemTypeSelection.SelectedIndex = itemTypeSelection.FindStringExact(dr.GetString(0));
                    if (dr[1].GetType() != typeof(DBNull))
                        itemType2Selection.SelectedIndex = itemType2Selection.FindStringExact(dr.GetString(1));
                    itemRaritySelection.SelectedIndex = itemRaritySelection.FindStringExact(dr.GetString(2));
                    buyValue.Value = dr.GetInt32(3);
                    sellValue.Value = dr.GetInt32(4);
                    if (dr[5].GetType() != typeof(DBNull))
                        if (dr.GetInt32(5) == 1) inventoryCheck.Checked = true;
                    if (dr[6].GetType() != typeof(DBNull))
                        if (dr.GetInt32(6) == 1) persistentCheck.Checked = true;
                    if (dr[7].GetType() != typeof(DBNull))
                        if (dr.GetInt32(7) == 1) giftableCheck.Checked = true;
                    if (dr[8].GetType() != typeof(DBNull))
                        if (dr.GetInt32(8) == 1) sellableCheck.Checked = true;
                    if (dr[9].GetType() != typeof(DBNull))
                        if (dr.GetInt32(9) == 1) dropableCheck.Checked = true;
                    slotCheck.SelectedIndex = slotCheck.FindStringExact(dr.GetString(10));
                    if (dr[11].GetType() != typeof(DBNull))
                        if (dr.GetInt32(11) == 1) consumableCheck.Checked = true;
                    if (dr[12].GetType() != typeof(DBNull))
                        if (dr.GetInt32(12) == 1) triggerCheck.Checked = true;
                    if (dr[13].GetType() != typeof(DBNull))
                        if (dr.GetInt32(13) == 1) usableCheck.Checked = true;
                    storageSelection.SelectedIndex = storageSelection.FindStringExact(dr.GetString(14));
                }
            }
            catch
            {
                MessageBox.Show("Please open a supported DB file.", "Transfiguration ~ Error!");
            }
        }

        private void UpdateItemData(string item)
        {
            int inventory = 0, persistent = 0, giftable = 0, sellable = 0, dropable = 0, consumable = 0, trigger = 0, usable = 0;
            if (inventoryCheck.Checked) inventory = 1;
            if (persistentCheck.Checked) persistent = 1;
            if (giftableCheck.Checked) giftable = 1;
            if (sellableCheck.Checked) sellable = 1;
            if (dropableCheck.Checked) dropable = 1;
            if (consumableCheck.Checked) consumable = 1;
            if (triggerCheck.Checked) trigger = 1;
            if (usableCheck.Checked) usable = 1;

            try
            {
                var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
                con.Open();

                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "UPDATE ItemDefinition SET " +
                    "ItemType = @type, " +
                    "ItemType2 = @type2, " +
                    "RarityTier = @rarity, " +
                    "EconomyValue = @buy, " +
                    "SellPrice = @sell, " +
                    "Inventoryable = @inventory, " +
                    "Persistent = @persistent, " +
                    "Giftable = @gift," +
                    "Sellable = @sellable, " +
                    "Dropable = @dropable, " +
                    "SlotLevel = @slotlevel, " +
                    "Consumable = @consumable, " +
                    "TriggerAbilityOnConsume = @trigger, " +
                    "UsableOnDiamond = @usable, " +
                    "StorageLocation = @storage WHERE ItemID='" + item + "'";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@type", itemTypeSelection.Text);
                cmd.Parameters.AddWithValue("@type2", itemType2Selection.Text);
                cmd.Parameters.AddWithValue("@rarity", itemRaritySelection.Text);
                cmd.Parameters.AddWithValue("@buy", buyValue.Value);
                cmd.Parameters.AddWithValue("@sell", sellValue.Value);
                cmd.Parameters.AddWithValue("@inventory", inventory);
                cmd.Parameters.AddWithValue("@persistent", persistent);
                cmd.Parameters.AddWithValue("@gift", giftable);
                cmd.Parameters.AddWithValue("@sellable", sellable);
                cmd.Parameters.AddWithValue("@dropable", dropable);
                cmd.Parameters.AddWithValue("@slotlevel", slotCheck.Text);
                cmd.Parameters.AddWithValue("@consumable", consumable);
                cmd.Parameters.AddWithValue("@trigger", trigger);
                cmd.Parameters.AddWithValue("@usable", usable);
                cmd.Parameters.AddWithValue("@storage", storageSelection.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(item + " updated successfully!", "Transfiguration ~ Success!");
            }
            catch
            {
                MessageBox.Show("Please open a supported DB file.", "Transfiguration ~ Error!");
            }
        }

        private void itemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdateItemDb.Enabled = true;
            if (this.ConnectionString != "")
            {
                GetItemData(itemSelection.Text);
            }
            else
            {
                MessageBox.Show("There's currently no database loaded.", "Transfiguration ~ Error!");
            }
        }

        private void btnUpdateItemDb_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Please keep in mind some things are untested, and issues can occur with editing certain values. Are you sure you want to edit " + itemSelection.Text + "'s values?", "Transfiguration ~ Warning!", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                UpdateItemData(itemSelection.Text);
            }
        }
    }
}

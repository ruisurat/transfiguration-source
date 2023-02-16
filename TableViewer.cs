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
    public partial class TableViewer : Form
    {
        SQLiteDataReader dr;
        SQLiteDataAdapter db;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();

        List<String> tableNames = new List<String>();

        public TableViewer(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void LoadDBTables()
        {
            tableNames.Clear();
            tableNamesSelection.Items.Clear();

            var con = new SQLiteConnection(@"Data Source = " + this.ConnectionString);
            con.Open();

            var cmd = new SQLiteCommand("SELECT name FROM sqlite_schema WHERE type='table' AND name NOT LIKE 'sqlite_%'", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tableNames.Add(dr.GetString(0));
            }
            
            foreach (string s in tableNames)
            {
                tableNamesSelection.Items.Add(s);
            }

            MessageBox.Show("Tables loaded successfully!", "Transfiguration ~ Success!");
        }

        private void LoadDataFromTable(string table)
        {
            try
            {
                var con = new SQLiteConnection(@"Data Source = " + this.ConnectionString);
                con.Open();

                var cmd = con.CreateCommand();
                string commandText = "SELECT * FROM " + table;
                db = new SQLiteDataAdapter(commandText, con);
                DS.Reset();
                db.Fill(DS);
                DT = DS.Tables[0];
                dataGridView1.DataSource = DT;
                con.Close();
                label1.Text = "Currently viewing: " + table;
            }
            catch
            {

            }
        }


        private void btnLoadTables_Click(object sender, EventArgs e)
        {
            LoadDBTables();
        }

        private void tableNamesSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataFromTable(tableNamesSelection.Text);
        }
    }
}

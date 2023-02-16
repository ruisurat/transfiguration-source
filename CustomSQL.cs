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
    public partial class CustomSQL : Form
    {
        public CustomSQL(string connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void CustomSQLExecution(string sql)
        {
            var con = new SQLiteConnection(@"Data Source=" + this.ConnectionString);
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

        private void sqlUseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            sqlUseCheckbox.Enabled = false;
            customSqlTextbox.Enabled = true;
            customSqlExecuteBtn.Enabled = true;
        }

        private void customSqlExecuteBtn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to execute the following SQL command? Command: " + customSqlTextbox.Text, "Transfiguration ~ Warning!", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                CustomSQLExecution(customSqlTextbox.Text);
            }
        }
    }
}

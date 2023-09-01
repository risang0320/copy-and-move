using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace copy_and_move
{
    public partial class dashboard1 : Form
    {
        public dashboard1()
        {
            InitializeComponent();
        }
        private void dashboard1_Load_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\riyas\\OneDrive\\Documents\\copy.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dashboard1", con);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

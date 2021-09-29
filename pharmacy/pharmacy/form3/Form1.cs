using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy.form3
{
    public partial class HomePage : Form
    {
        SqlConnection connection = null;
        SqlDataAdapter dataAdapter = null;
        DataTable table = null;

        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
        }
        void load_data()
        {
            connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\MRTMTex00104\source\repos\pharmacy\pharmacy\Database1.mdf; Integrated Security = True");
            string readQuery = "Select * from pharmacy;";
            dataAdapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            dataAdapter.Fill(table);
            guna2DataGridView1.DataSource = table;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}

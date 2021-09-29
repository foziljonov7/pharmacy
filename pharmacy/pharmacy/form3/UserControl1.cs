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
    public partial class UserControl1 : UserControl
    {
        SqlConnection connection = null;
        SqlDataAdapter DataAdapter = null;
        DataTable table = null;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Load_datA();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Load_datA();


            
     
        }
        void Load_datA()

        {
            connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\MRTMTex00104\source\repos\pharmacy\pharmacy\Database1.mdf; Integrated Security = True");
            string readQuery = "SELECT * FROM Pharmacy;";
            DataAdapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            DataAdapter.Fill(table);

            guna2DataGridView1.DataSource = table;

        }
    }
}

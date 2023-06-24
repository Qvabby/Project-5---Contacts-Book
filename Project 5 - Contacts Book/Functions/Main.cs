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

namespace Project_5___Contacts_Book.Functions
{
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ContactsBook_db;Integrated Security=True");

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Contacts_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            countL.Text = dt.Rows.Count.ToString();
        }
    }
}

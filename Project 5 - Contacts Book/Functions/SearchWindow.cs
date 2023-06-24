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
    public partial class SearchWindow : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ContactsBook_db;Integrated Security=True");
        DataTable dt = new DataTable();
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            SearchDGV.Rows.Clear();
            SearchDGV.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString().ToLower().Contains(SearchTb.Text.ToLower()))
                {
                    SearchDGV.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    SearchDGV.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    SearchDGV.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                }
            }
            for (int i = 0; i < SearchDGV.Rows.Count; i++)
            {
                DataGridViewRow row = SearchDGV.Rows[i];
                if (string.IsNullOrWhiteSpace((string)row.Cells[1].Value))
                {
                    SearchDGV.Rows.RemoveAt(row.Index);
                    i--;
                }
            }
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Contacts_Tb",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();
            search();
        }
    }
}

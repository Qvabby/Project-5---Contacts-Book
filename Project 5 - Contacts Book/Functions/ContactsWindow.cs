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
    public partial class ContactsWindow : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ContactsBook_db;Integrated Security=True");
        DataGridViewRow row;

        public ContactsWindow()
        {
            InitializeComponent();
        }



        private void ContactsWindow_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            ContactsDGV.Rows.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Contacts_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            ContactsDGV.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ContactsDGV.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                ContactsDGV.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                ContactsDGV.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();

            }
        }

        private void ContactsDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ContactsDGV.Rows[e.RowIndex];
            NameTB.Visible = true;
            NumberTb.Visible = true;
            UpdateBtn.Visible = true;
            NameTB.Text = row.Cells[1].Value.ToString();
            NumberTb.Text = row.Cells[2].Value.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE Contacts_Tb SET Name = '{NameTB.Text}', Number = '{NumberTb.Text}' where Id = {row.Cells[0].Value.ToString()}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataLoad();
        }

        private void ContactsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            row = ContactsDGV.Rows[e.RowIndex];
            if ((sender as DataGridView).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewButtonColumn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Contacts_Tb WHERE Id = {row.Cells[0].Value}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DataLoad();
            }
        }
    }
}

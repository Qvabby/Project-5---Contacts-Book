using Project_5___Contacts_Book.RegularExpression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Project_5___Contacts_Book.Functions
{
    public partial class AddWindow : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=ContactsBook_db;Integrated Security=True");
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            string result = "+995 " + NumberTb.Text;
            if (regexes.NumberRegex.IsMatch(result) && !string.IsNullOrWhiteSpace(NameTb.Text) || regexes.NumberRegex2.IsMatch(result) && !string.IsNullOrWhiteSpace(NameTb.Text))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Contacts_Tb (Name, Number) Values ('{NameTb.Text}', '{result}')",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Contacts Added", "Success");
                NameTb.Text = "";
                NumberTb.Text = "";
                MainForm.LoadPanel(new Main(), MainForm.MP);
            }
            else if (string.IsNullOrWhiteSpace(NameTb.Text))
            {
                MessageBox.Show("Name Input is Empty", "TextBox Error");
                NameTb.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Incorrect syntax of Number", "Regex Error");
                NumberTb.BackColor = Color.Red;
            }
            
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            NameTb.BackColor = Color.White;
        }

        private void NumberTB_TextChanged(object sender, EventArgs e)
        {
            NumberTb.BackColor = Color.White;
        }
    }
}

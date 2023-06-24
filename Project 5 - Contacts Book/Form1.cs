using Project_5___Contacts_Book.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5___Contacts_Book
{
    public partial class MainForm : Form
    {
        public static Panel MP;
        public MainForm()
        {
            InitializeComponent();
            MP = MainPanel;
            LoadPanel(new Main(), MainPanel);
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddWindow f = new AddWindow();
            LoadPanel(f, MainPanel);
        }

        public static void LoadPanel(Form f, Panel p)
        {
            if (p.Controls.Count > 0)
            {
                p.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);
            f.Show();
        }

        private void ContactsBtn_Click(object sender, EventArgs e)
        {
            ContactsWindow f = new ContactsWindow();
            LoadPanel(f, MainPanel);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchWindow f = new SearchWindow();
            LoadPanel(f, MainPanel);
        }
    }
}

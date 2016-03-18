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

namespace NewbornApp
{
    public partial class ChildSelect : Form
    {
        public ChildSelect()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newChildButton_Click(object sender, EventArgs e)
        {
            Form childdetails = new ChildDetails();
            childdetails.ShowDialog();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (childListBox.SelectedIndex != -1)
            {
                Global.Globalname = childListBox.SelectedItem.ToString();
                Form mainmenu = new MainMenu();
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Please select an child from the list.");
            }
            
        }

        private void ChildSelect_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void FillListBox()
        {
            childListBox.Items.Clear();
            SqlConnection child = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=|DataDirectory|\HealthApp.mdf;Integrated Security=True");
            SqlCommand show = new SqlCommand("SELECT Name FROM Child", child);
            child.Open();
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                childListBox.Items.Add(reader[0]);
            }
            child.Close();

        }
    }
}

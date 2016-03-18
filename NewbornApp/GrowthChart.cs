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
    public partial class GrowthChart : Form
    {
        public GrowthChart()
        {
            InitializeComponent();
        }

        private void GrowthChart_Load(object sender, EventArgs e)
        {
            SqlConnection child = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=|DataDirectory|\HealthApp.mdf;Integrated Security=True");
            SqlCommand detail = new SqlCommand("SELECT * FROM Weekly WHERE Name = @name", child);
            detail.Parameters.AddWithValue("@name", Global.Globalname);
            SqlDataReader reader;
            try
            {
                child.Open();
                reader = detail.ExecuteReader();
                while(reader.Read())
                {
                 //  DateTime date = reader[0];
                   //decimal weight = reader[2];
                   //this.chart1.Series["Weight"].Points.AddXY(date,weight);
                }
                child.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}

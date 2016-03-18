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
    public partial class WeeklyChecks : Form
    {
        decimal n, m;
        public WeeklyChecks()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(Validation() == "")
            {

            }
            else
            {
                MessageBox.Show(Validation());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        public void ClearForm()
        {
            kilogramsTextBox.Clear();
            poundsTextBox.Clear();
            ouncesTextBox.Clear();
            centimetresTextBox.Clear();
            inchesTextBox.Clear();
        }

        private void kilogramsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(kilogramsTextBox.Text, out n))
            {
                kilostopounds();
            }
        }
        public void kilostopounds()
        {
            decimal kilos = decimal.Parse(kilogramsTextBox.Text);
            decimal dividor = 0.453M;
            decimal nearExact = decimal.Divide(kilos, dividor);
            decimal pounds = Math.Floor(nearExact);
            decimal ounces = Math.Round((nearExact - pounds) * 16);
            poundsTextBox.Text = pounds.ToString();
            ouncesTextBox.Text = ounces.ToString();
        }
        public void poundstokilos()
        {
            decimal pounds = decimal.Parse(poundsTextBox.Text);
            decimal ounces = decimal.Parse(ouncesTextBox.Text);
            pounds = pounds + ounces / 16;
            decimal dividor = 2.205M;
            decimal kilos = Math.Round(pounds / dividor, 2);
            kilogramsTextBox.Text = kilos.ToString();
        }
        public void centimetrestoinches()
        {
            decimal centimetres = decimal.Parse(centimetresTextBox.Text);
            decimal dividor = 0.394m;
            decimal inches = Math.Round(centimetres * dividor, 1);
            inchesTextBox.Text = inches.ToString();
        }
        public void inchestocentimetres()
        {
            decimal inches = decimal.Parse(inchesTextBox.Text);
            decimal dividor = 0.394m;
            decimal centimetres = Math.Round(inches / dividor, 1);
            centimetresTextBox.Text = centimetres.ToString();
        }

        private void poundsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(poundsTextBox.Text, out n))
            {
                if (Decimal.TryParse(ouncesTextBox.Text, out m))
                {
                    poundstokilos();
                }
            }
        }

        private void ouncesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(poundsTextBox.Text, out n))
            {
                if (Decimal.TryParse(ouncesTextBox.Text, out m))
                {
                    poundstokilos();
                }
            }
        }

        private void centimetresTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(centimetresTextBox.Text, out n))
            {
                centimetrestoinches();
            }
        }

        private void inchesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(inchesTextBox.Text, out n))
            {
                inchestocentimetres();
            }
        }
        private void AddWeekly(string Date, String Name, decimal Weight, decimal Headsize)
        {
            SqlConnection child = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=|DataDirectory|\HealthApp.mdf;Integrated Security=True");
            SqlCommand weekly = new SqlCommand("INSERT INTO Weekly(Date, Name, Weight, HeadSize) VALUES(@date, @name, @weight, @headsize", child);
            weekly.Parameters.AddWithValue("@date", Date);
            weekly.Parameters.AddWithValue("@name", Name);
            weekly.Parameters.AddWithValue("@weight", Weight);
            weekly.Parameters.AddWithValue("@headsize", Headsize);
            child.Open();
            weekly.ExecuteNonQuery();
            child.Close();
        }
        public string Validation()
        {
            string errormessage = "";
            if (!Decimal.TryParse(centimetresTextBox.Text, out n))
            {
                errormessage = errormessage + "Please enter a valid head circumference. ";
            }
            if (!Decimal.TryParse(kilogramsTextBox.Text, out n))
            {
                errormessage = errormessage + "Please enter a valid weight. ";
            }
            return errormessage;
        }
    }
}

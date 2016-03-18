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
    public partial class DailyChecks : Form
    {
        decimal n;
        public DailyChecks()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(Validation()=="")
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
            wetTextBox.Clear();
            dirtyTextBox.Clear();
            centigradeTextBox.Clear();
            farenheitTextBox.Clear();
        }

        private void centigradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(centigradeTextBox.Text, out n))
            {
                centigradetofarenheit();
            }
        }

        private void farenheitTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(farenheitTextBox.Text, out n))
            {
                farenheittocentigrade();
            }
        }
        public void centigradetofarenheit()
        {
            decimal centigrade = decimal.Parse(centigradeTextBox.Text);
            decimal farenheit = Math.Round((centigrade * 9) / 5 + 32,1);
            farenheitTextBox.Text = farenheit.ToString();
        }
        public void farenheittocentigrade()
        {
            decimal farenheit = decimal.Parse(farenheitTextBox.Text);
            decimal centigrade = Math.Round(5.0m / 9.0m * (farenheit - 32),1);
            centigradeTextBox.Text = centigrade.ToString();
        }
        private void AddDaily(string Date, string Name, decimal Temperature, int WetNappies, int DirtyNappies)
        {
            SqlConnection child = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=|DataDirectory|\HealthApp.mdf;Integrated Security=True");
            SqlCommand daily = new SqlCommand("INSERT INTO Daily(Date, Name, Temperature, WetNappies, DirtyNappies) VALUES(@date, @name, @temperature, @wetnappies, @dirtynappies", child);
            daily.Parameters.AddWithValue("@date", Date);
            daily.Parameters.AddWithValue("@name", Name);
            daily.Parameters.AddWithValue("@temperature", Temperature);
            daily.Parameters.AddWithValue("@wetnappies", WetNappies);
            daily.Parameters.AddWithValue("@dirtynappies", DirtyNappies);
            child.Open();
            daily.ExecuteNonQuery();
            child.Close();
        }

        private void DailyChecks_Load(object sender, EventArgs e)
        {

        }
        public string Validation()
        {
            string errormessage;
            errormessage = "";
            int n;
            decimal m;
            if(!int.TryParse(wetTextBox.Text, out n))
            { 
                errormessage = errormessage + "Please enter number of Wet Nappies. "; 
            }
            if(!int.TryParse(dirtyTextBox.Text, out n))
            {
                errormessage = errormessage + "Please enter number of Dirty Nappies. ";
            }
            if(!decimal.TryParse(centigradeTextBox.Text, out m))
            {
                errormessage = errormessage + "Please enter a valid Temperature. ";
            }
            return errormessage;
        }

    }
}

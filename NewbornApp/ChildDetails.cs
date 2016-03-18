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
    public partial class ChildDetails : Form
    {
        decimal n, m;
        public ChildDetails()
        {
            InitializeComponent();
        }

        private void ChildDetails_Load(object sender, EventArgs e)
        {
            dobPicker.MaxDate = DateTime.Today;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(Validation() == "")
            {
                string Feeding = "";
                if (breastRadioButton.Checked)
                {
                    Feeding = "Breast";
                }
                else if (bottleRadioButton.Checked)
                {
                    Feeding = "Bottle";
                }
                else if (bothRadioButton.Checked)
                {
                    Feeding = "Both";
                }
                AddChild(childNameTextBox.Text, genderDropdown.Text, dobPicker.Value.Date, motherNameTextBox.Text, Feeding, Decimal.Parse(kilogramsTextBox.Text), Decimal.Parse(centimetresTextBox.Text));
            }
            else
            {
                MessageBox.Show(Validation());
            }
        }
        public void ClearForm()
        {
            childNameTextBox.Clear();
            motherNameTextBox.Clear();
            kilogramsTextBox.Clear();
            poundsTextBox.Clear();
            ouncesTextBox.Clear();
            centimetresTextBox.Clear();
            inchesTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void kilogramsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(kilogramsTextBox.Text, out n))
            {
                kilostopounds();
            }
            
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
            decimal centimetres = Math.Round(inches / dividor,1);
            centimetresTextBox.Text = centimetres.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddChild(string ChildName, string Gender, DateTime DateofBirth , string MothersName, string Feeding, decimal Weight, decimal HeadSize)
        {
            SqlConnection child = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=|DataDirectory|\HealthApp.mdf;Integrated Security=True");    
            child.Open();
            SqlCommand add = new SqlCommand("INSERT INTO Child(Name, Gender, DateOfBirth, MothersName, Feeding) VALUES(@name, @gender, @dateofbirth, @mothersname, @feeding)", child);
            add.Parameters.AddWithValue("@name", ChildName);
            add.Parameters.AddWithValue("@gender", Gender);
            add.Parameters.AddWithValue("@dateofbirth", DateofBirth);
            add.Parameters.AddWithValue("@mothersname", MothersName);
            add.Parameters.AddWithValue("@feeding", Feeding);
            add.ExecuteNonQuery();
            SqlCommand weekly = new SqlCommand("INSERT INTO Weekly(Date, Name, Weight, HeadSize) VALUES(@date, @name, @weight, @headsize)", child);
            weekly.Parameters.AddWithValue("@date", DateofBirth);
            weekly.Parameters.AddWithValue("@name", ChildName);
            weekly.Parameters.AddWithValue("@weight", Weight);
            weekly.Parameters.AddWithValue("@headsize", HeadSize);
            weekly.ExecuteNonQuery();
            child.Close();
            MessageBox.Show("Child record added");
            this.Close();
        }
        public string Validation()
        {
            string errormessage;
            errormessage = "";
            if (childNameTextBox.Text == "")
            {
                errormessage = errormessage + "Please enter Childs Name. ";
            }
            if (genderDropdown.SelectedIndex == -1)
            {
                errormessage = errormessage + "Please select Childs Gender. ";
            }
            if (!Decimal.TryParse(centimetresTextBox.Text, out n))
            {
                errormessage = errormessage + "Please enter a valid head circumference. ";
            }
            if (!Decimal.TryParse(kilogramsTextBox.Text, out n))
            {
                errormessage = errormessage + "Please enter a valid weight. ";
            }
            if (!breastRadioButton.Checked && !bottleRadioButton.Checked && !bothRadioButton.Checked)
            {
                errormessage = errormessage + "Please select a feeding method.";
            }


            return errormessage;
        }
        
    }
}

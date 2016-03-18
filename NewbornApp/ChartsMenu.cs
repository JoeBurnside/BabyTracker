using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewbornApp
{
    public partial class ChartsMenu : Form
    {
        public ChartsMenu()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void growthButton_Click(object sender, EventArgs e)
        {
            Form growthchart = new GrowthChart();
            growthchart.Show();
        }
    }
}

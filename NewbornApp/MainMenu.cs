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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dailyButton_Click(object sender, EventArgs e)
        {
            Form dailychecks = new DailyChecks();
            dailychecks.Show();
        }

        private void weeklyButton_Click(object sender, EventArgs e)
        {
            Form weeklychecks = new WeeklyChecks();
            weeklychecks.Show();
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            Form chartsmenu = new ChartsMenu();
            chartsmenu.Show();
        }
    }
}

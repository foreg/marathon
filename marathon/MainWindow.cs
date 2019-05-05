using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marathon.Models;

namespace Marathon
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitPanels();
        }

        public void InitPanels()
        {
            Program.PanelsManageer.InitTop(titlePanel1);

            Program.PanelsManageer.InitCenter(startPanel1, sponsorRunner1);

            Program.PanelsManageer.InitBottom(countDownPanel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Config.EventName;
            countDownPanel1.StartCountDown();
        }
    }
}

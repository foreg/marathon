using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon.Panels
{
    public partial class StartPanel : BaseUserControl
    {
        public StartPanel()
        {
            InitializeComponent();
        }

        private void btnBecomeSponsor_Click(object sender, EventArgs e)
        {
            Program.PanelsManageer.BringToFront(centerPanel: typeof(SponsorRunner));
        }
    }
}

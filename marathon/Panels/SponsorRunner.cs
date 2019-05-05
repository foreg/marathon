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
    public partial class SponsorRunner : BaseUserControl
    {
        public SponsorRunner()
        {
            InitializeComponent();
           
        }

        public override void Init()
        {
            base.Init();
            LoadData();

        }

        void LoadData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                foreach (var u in users)
                {
                    comboBox1.Items.Add(u.Role.RoleName);
                }
            }
        }
    }
}

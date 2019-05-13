using Marathon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon.PopupForms
{
    public partial class CharityOrganizationInfo : Form
    {
        private Charity SelectedCharityOrganization { get; set; }

        public CharityOrganizationInfo(Charity selectedCharityOrganization)
        {
            InitializeComponent();
            SelectedCharityOrganization = selectedCharityOrganization;
            Init();
        }

        void Init()
        {
            pbCharityOrganizationLogo.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\CharitiesLogo\" + SelectedCharityOrganization.CharityLogo));
            pbCharityOrganizationLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCharityOrganizationName.Text = SelectedCharityOrganization.CharityName;
        }
    }
}

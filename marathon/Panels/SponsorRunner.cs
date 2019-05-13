using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marathon.PopupForms;
using Marathon.Models;

namespace Marathon.Panels
{
    public partial class SponsorRunner : BaseUserControl
    {
        private int DonationAmount { get; set; }
        private Charity SelectedCharityOrganization { get; set; }

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
            var registrations = Program.db.Registrations.ToArray();
            cmbRunner.Items.AddRange(registrations);
            cmbRunner.DisplayMember = "RunnerFullName";
            cmbRunner.SelectedIndex = 0;
            DonationAmount = 0;
            UpdateLblDonationAmount(true);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var form = new CharityOrganizationInfo(SelectedCharityOrganization);
            form.ShowDialog();
        }

        private void txbDonationAmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse((sender as TextBox).Text, out int result))
                DonationAmount = result;
            else
                DonationAmount = 0;
            UpdateLblDonationAmount();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            DonationAmount += 10;
            UpdateLblDonationAmount(true);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            DonationAmount -= 10;
            if (DonationAmount < 0)
                DonationAmount = 0;
            UpdateLblDonationAmount(true);
        }

        void UpdateLblDonationAmount(bool alsoTextbox = false)
        {
            if (alsoTextbox)
                txbDonationAmount.Text = DonationAmount.ToString();
            lblDonationAmount.Text = $"${DonationAmount}";
        }

        private void cmbRunner_SelectedIndexChanged(object sender, EventArgs e)
        {
            var registration = (Registration)(sender as ComboBox).Items[(sender as ComboBox).SelectedIndex];
            SelectedCharityOrganization = registration.Charity;
            lblCharityOrganization.Text = SelectedCharityOrganization.CharityName;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var sponsorship = new Sponsorship
                {
                    Amount = DonationAmount,
                    SponsorName = txbName.Text,
                    Registration = (Registration)cmbRunner.Items[cmbRunner.SelectedIndex]
                };
                Program.db.Sponsorships.Add(sponsorship);
                Program.db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных"); // todo сделать свой MessageBox
            }
        }

        bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txbName.Text) || string.IsNullOrEmpty(txbCardHolder.Text) || 
                string.IsNullOrEmpty(txbCardNumber.Text) || string.IsNullOrEmpty(txbCardExpiresMonth.Text) ||
                string.IsNullOrEmpty(txbCardExpiresYear.Text) || string.IsNullOrEmpty(txbCardCVC.Text))
            {
                return false;
            }

            if (txbCardNumber.Text.Length != 16)
                return false;

            if (txbCardCVC.Text.Length != 3)
                return false;

            var year = int.Parse(txbCardExpiresYear.Text);
            var month = int.Parse(txbCardExpiresMonth.Text);
            var max_date = DateTime.DaysInMonth(year, month);
            var datetime = new DateTime(year, month, max_date);
            if (datetime < DateTime.Now)
                return false;

            return true;
        }
    }
}

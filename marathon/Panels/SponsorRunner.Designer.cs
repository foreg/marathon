namespace Marathon.Panels
{
    partial class SponsorRunner
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRunner = new System.Windows.Forms.ComboBox();
            this.lblCharityOrganization = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblDonationAmount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbCardHolder = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCardNumber = new Marathon.CustomElements.NumericTextBox();
            this.txbCardExpiresMonth = new Marathon.CustomElements.NumericTextBox();
            this.txbCardExpiresYear = new Marathon.CustomElements.NumericTextBox();
            this.txbCardCVC = new Marathon.CustomElements.NumericTextBox();
            this.txbDonationAmount = new Marathon.CustomElements.NumericTextBox();
            this.SuspendLayout();
            // 
            // cmbRunner
            // 
            this.cmbRunner.FormattingEnabled = true;
            this.cmbRunner.Location = new System.Drawing.Point(131, 134);
            this.cmbRunner.Name = "cmbRunner";
            this.cmbRunner.Size = new System.Drawing.Size(236, 21);
            this.cmbRunner.TabIndex = 6;
            this.cmbRunner.SelectedIndexChanged += new System.EventHandler(this.cmbRunner_SelectedIndexChanged);
            // 
            // lblCharityOrganization
            // 
            this.lblCharityOrganization.AutoSize = true;
            this.lblCharityOrganization.Location = new System.Drawing.Point(439, 116);
            this.lblCharityOrganization.Name = "lblCharityOrganization";
            this.lblCharityOrganization.Size = new System.Drawing.Size(56, 13);
            this.lblCharityOrganization.TabIndex = 7;
            this.lblCharityOrganization.Text = "charity org";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::Marathon.Properties.Resources.info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(517, 109);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblDonationAmount
            // 
            this.lblDonationAmount.AutoSize = true;
            this.lblDonationAmount.Location = new System.Drawing.Point(463, 213);
            this.lblDonationAmount.Name = "lblDonationAmount";
            this.lblDonationAmount.Size = new System.Drawing.Size(35, 13);
            this.lblDonationAmount.TabIndex = 9;
            this.lblDonationAmount.Text = "label2";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(400, 277);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 23);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(547, 277);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 23);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(377, 343);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Заплатить";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(504, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txbCardHolder
            // 
            this.txbCardHolder.Location = new System.Drawing.Point(131, 161);
            this.txbCardHolder.Name = "txbCardHolder";
            this.txbCardHolder.Size = new System.Drawing.Size(100, 20);
            this.txbCardHolder.TabIndex = 2;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(131, 109);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 0;
            // 
            // txbCardNumber
            // 
            this.txbCardNumber.Location = new System.Drawing.Point(131, 188);
            this.txbCardNumber.Name = "txbCardNumber";
            this.txbCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txbCardNumber.TabIndex = 15;
            // 
            // txbCardExpiresMonth
            // 
            this.txbCardExpiresMonth.Location = new System.Drawing.Point(131, 213);
            this.txbCardExpiresMonth.Name = "txbCardExpiresMonth";
            this.txbCardExpiresMonth.Size = new System.Drawing.Size(51, 20);
            this.txbCardExpiresMonth.TabIndex = 16;
            // 
            // txbCardExpiresYear
            // 
            this.txbCardExpiresYear.Location = new System.Drawing.Point(188, 213);
            this.txbCardExpiresYear.Name = "txbCardExpiresYear";
            this.txbCardExpiresYear.Size = new System.Drawing.Size(64, 20);
            this.txbCardExpiresYear.TabIndex = 17;
            // 
            // txbCardCVC
            // 
            this.txbCardCVC.Location = new System.Drawing.Point(131, 239);
            this.txbCardCVC.MaxLength = 3;
            this.txbCardCVC.Name = "txbCardCVC";
            this.txbCardCVC.Size = new System.Drawing.Size(51, 20);
            this.txbCardCVC.TabIndex = 18;
            // 
            // txbDonationAmount
            // 
            this.txbDonationAmount.Location = new System.Drawing.Point(441, 279);
            this.txbDonationAmount.Name = "txbDonationAmount";
            this.txbDonationAmount.Size = new System.Drawing.Size(100, 20);
            this.txbDonationAmount.TabIndex = 19;
            this.txbDonationAmount.TextChanged += new System.EventHandler(this.txbDonationAmount_TextChanged);
            // 
            // SponsorRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbDonationAmount);
            this.Controls.Add(this.txbCardCVC);
            this.Controls.Add(this.txbCardExpiresYear);
            this.Controls.Add(this.txbCardExpiresMonth);
            this.Controls.Add(this.txbCardNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblDonationAmount);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblCharityOrganization);
            this.Controls.Add(this.cmbRunner);
            this.Controls.Add(this.txbCardHolder);
            this.Controls.Add(this.txbName);
            this.Name = "SponsorRunner";
            this.Size = new System.Drawing.Size(647, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRunner;
        private System.Windows.Forms.Label lblCharityOrganization;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblDonationAmount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbCardHolder;
        private System.Windows.Forms.TextBox txbName;
        private CustomElements.NumericTextBox txbCardNumber;
        private CustomElements.NumericTextBox txbCardExpiresMonth;
        private CustomElements.NumericTextBox txbCardExpiresYear;
        private CustomElements.NumericTextBox txbCardCVC;
        private CustomElements.NumericTextBox txbDonationAmount;
    }
}

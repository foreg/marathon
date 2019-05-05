namespace Marathon
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startPanel1 = new Marathon.Panels.StartPanel();
            this.titlePanel1 = new Marathon.Panels.TitlePanel();
            this.countDownPanel1 = new Marathon.Panels.CountDownPanel();
            this.sponsorRunner1 = new Marathon.Panels.SponsorRunner();
            this.SuspendLayout();
            // 
            // startPanel1
            // 
            this.startPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel1.Location = new System.Drawing.Point(0, 150);
            this.startPanel1.Name = "startPanel1";
            this.startPanel1.Size = new System.Drawing.Size(784, 361);
            this.startPanel1.TabIndex = 2;
            // 
            // titlePanel1
            // 
            this.titlePanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel1.Location = new System.Drawing.Point(0, 0);
            this.titlePanel1.Name = "titlePanel1";
            this.titlePanel1.Size = new System.Drawing.Size(784, 150);
            this.titlePanel1.TabIndex = 1;
            // 
            // countDownPanel1
            // 
            this.countDownPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.countDownPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.countDownPanel1.Location = new System.Drawing.Point(0, 511);
            this.countDownPanel1.Name = "countDownPanel1";
            this.countDownPanel1.Size = new System.Drawing.Size(784, 50);
            this.countDownPanel1.TabIndex = 0;
            // 
            // sponsorRunner1
            // 
            this.sponsorRunner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sponsorRunner1.Location = new System.Drawing.Point(0, 150);
            this.sponsorRunner1.Name = "sponsorRunner1";
            this.sponsorRunner1.Size = new System.Drawing.Size(784, 361);
            this.sponsorRunner1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.startPanel1);
            this.Controls.Add(this.sponsorRunner1);
            this.Controls.Add(this.titlePanel1);
            this.Controls.Add(this.countDownPanel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panels.CountDownPanel countDownPanel1;
        private Panels.TitlePanel titlePanel1;
        private Panels.StartPanel startPanel1;
        private Panels.SponsorRunner sponsorRunner1;
    }
}


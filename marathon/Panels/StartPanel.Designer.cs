namespace Marathon.Panels
{
    partial class StartPanel
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
            this.btnBecomeRunner = new System.Windows.Forms.Button();
            this.btnBecomeSponsor = new System.Windows.Forms.Button();
            this.btnAdditionalInfo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBecomeRunner
            // 
            this.btnBecomeRunner.Location = new System.Drawing.Point(254, 131);
            this.btnBecomeRunner.Name = "btnBecomeRunner";
            this.btnBecomeRunner.Size = new System.Drawing.Size(183, 39);
            this.btnBecomeRunner.TabIndex = 0;
            this.btnBecomeRunner.Text = "Я хочу стать бегуном";
            this.btnBecomeRunner.UseVisualStyleBackColor = true;
            // 
            // btnBecomeSponsor
            // 
            this.btnBecomeSponsor.Location = new System.Drawing.Point(254, 179);
            this.btnBecomeSponsor.Name = "btnBecomeSponsor";
            this.btnBecomeSponsor.Size = new System.Drawing.Size(183, 40);
            this.btnBecomeSponsor.TabIndex = 1;
            this.btnBecomeSponsor.Text = "Я хочу стать спонсором бегуна";
            this.btnBecomeSponsor.UseVisualStyleBackColor = true;
            this.btnBecomeSponsor.Click += new System.EventHandler(this.btnBecomeSponsor_Click);
            // 
            // btnAdditionalInfo
            // 
            this.btnAdditionalInfo.Location = new System.Drawing.Point(254, 227);
            this.btnAdditionalInfo.Name = "btnAdditionalInfo";
            this.btnAdditionalInfo.Size = new System.Drawing.Size(183, 39);
            this.btnAdditionalInfo.TabIndex = 2;
            this.btnAdditionalInfo.Text = "Я хоу больше узнать о событии";
            this.btnAdditionalInfo.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // StartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAdditionalInfo);
            this.Controls.Add(this.btnBecomeSponsor);
            this.Controls.Add(this.btnBecomeRunner);
            this.Name = "StartPanel";
            this.Size = new System.Drawing.Size(705, 422);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBecomeRunner;
        private System.Windows.Forms.Button btnBecomeSponsor;
        private System.Windows.Forms.Button btnAdditionalInfo;
        private System.Windows.Forms.Button button4;
    }
}

namespace Marathon.PopupForms
{
    partial class CharityOrganizationInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCharityOrganizationLogo = new System.Windows.Forms.PictureBox();
            this.lblCharityOrganizationName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharityOrganizationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCharityOrganizationLogo
            // 
            this.pbCharityOrganizationLogo.Location = new System.Drawing.Point(287, 78);
            this.pbCharityOrganizationLogo.Name = "pbCharityOrganizationLogo";
            this.pbCharityOrganizationLogo.Size = new System.Drawing.Size(168, 137);
            this.pbCharityOrganizationLogo.TabIndex = 0;
            this.pbCharityOrganizationLogo.TabStop = false;
            // 
            // lblCharityOrganizationName
            // 
            this.lblCharityOrganizationName.AutoSize = true;
            this.lblCharityOrganizationName.Location = new System.Drawing.Point(351, 236);
            this.lblCharityOrganizationName.Name = "lblCharityOrganizationName";
            this.lblCharityOrganizationName.Size = new System.Drawing.Size(35, 13);
            this.lblCharityOrganizationName.TabIndex = 1;
            this.lblCharityOrganizationName.Text = "label1";
            // 
            // CharityOrganizationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCharityOrganizationName);
            this.Controls.Add(this.pbCharityOrganizationLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharityOrganizationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CharityOrganizationInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbCharityOrganizationLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharityOrganizationLogo;
        private System.Windows.Forms.Label lblCharityOrganizationName;
    }
}
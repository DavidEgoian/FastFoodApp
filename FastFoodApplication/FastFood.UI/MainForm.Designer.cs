namespace FastFood.UI
{
    partial class MainForm
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
            signedInPinLabel = new Label();
            companyBalanceLabel = new Label();
            SuspendLayout();
            // 
            // signedInPinLabel
            // 
            signedInPinLabel.AutoSize = true;
            signedInPinLabel.Dock = DockStyle.Right;
            signedInPinLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            signedInPinLabel.Location = new Point(1074, 0);
            signedInPinLabel.Name = "signedInPinLabel";
            signedInPinLabel.Size = new Size(159, 31);
            signedInPinLabel.TabIndex = 0;
            signedInPinLabel.Text = "გამარჯობა";
            // 
            // companyBalanceLabel
            // 
            companyBalanceLabel.AutoSize = true;
            companyBalanceLabel.Dock = DockStyle.Top;
            companyBalanceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            companyBalanceLabel.Location = new Point(0, 0);
            companyBalanceLabel.Name = "companyBalanceLabel";
            companyBalanceLabel.Size = new Size(138, 31);
            companyBalanceLabel.TabIndex = 1;
            companyBalanceLabel.Text = "ბალანსი: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 489);
            Controls.Add(companyBalanceLabel);
            Controls.Add(signedInPinLabel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signedInPinLabel;
        private Label companyBalanceLabel;
    }
}
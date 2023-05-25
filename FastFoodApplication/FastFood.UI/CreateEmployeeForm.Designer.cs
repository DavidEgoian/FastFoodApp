namespace FastFood.UI
{
    partial class CreateEmployeeForm
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
            signUpBtn = new Button();
            headerLabel = new Label();
            pinValue = new TextBox();
            pinLabel = new Label();
            exitLabel = new Label();
            SuspendLayout();
            // 
            // signUpBtn
            // 
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.Dock = DockStyle.Bottom;
            signUpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.Location = new Point(0, 347);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(411, 50);
            signUpBtn.TabIndex = 3;
            signUpBtn.Text = "რეგისტრაცია";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.OrangeRed;
            headerLabel.Location = new Point(21, 36);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(378, 59);
            headerLabel.TabIndex = 22;
            headerLabel.Text = "New Employee";
            // 
            // pinValue
            // 
            pinValue.Location = new Point(12, 208);
            pinValue.Name = "pinValue";
            pinValue.Size = new Size(387, 27);
            pinValue.TabIndex = 23;
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(12, 173);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(127, 20);
            pinLabel.TabIndex = 21;
            pinLabel.Text = "პირადი ნომერი";
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitLabel.ForeColor = Color.Red;
            exitLabel.Location = new Point(380, 9);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(19, 20);
            exitLabel.TabIndex = 24;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // CreateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 397);
            Controls.Add(exitLabel);
            Controls.Add(headerLabel);
            Controls.Add(pinValue);
            Controls.Add(pinLabel);
            Controls.Add(signUpBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUpBtn;
        private Label headerLabel;
        private TextBox pinValue;
        private Label pinLabel;
        private Label exitLabel;
    }
}
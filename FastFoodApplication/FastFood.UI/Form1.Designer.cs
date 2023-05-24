namespace FastFood.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pinLabel = new Label();
            pinValue = new TextBox();
            signInBtn = new Button();
            headerLabel = new Label();
            exitLabel = new Label();
            newEmployeeLink = new LinkLabel();
            SuspendLayout();
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(12, 176);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(127, 20);
            pinLabel.TabIndex = 0;
            pinLabel.Text = "პირადი ნომერი";
            // 
            // pinValue
            // 
            pinValue.Location = new Point(12, 211);
            pinValue.Name = "pinValue";
            pinValue.Size = new Size(387, 27);
            pinValue.TabIndex = 20;
            // 
            // signInBtn
            // 
            signInBtn.Cursor = Cursors.Hand;
            signInBtn.Dock = DockStyle.Bottom;
            signInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signInBtn.Location = new Point(0, 347);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(411, 50);
            signInBtn.TabIndex = 2;
            signInBtn.Text = "ავტორიზაცია";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += signInBtn_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.OrangeRed;
            headerLabel.Location = new Point(21, 39);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(368, 59);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Fast Food App";
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitLabel.ForeColor = Color.Red;
            exitLabel.Location = new Point(381, 9);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(19, 20);
            exitLabel.TabIndex = 4;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // newEmployeeLink
            // 
            newEmployeeLink.AutoSize = true;
            newEmployeeLink.Location = new Point(209, 241);
            newEmployeeLink.Name = "newEmployeeLink";
            newEmployeeLink.Size = new Size(180, 20);
            newEmployeeLink.TabIndex = 5;
            newEmployeeLink.TabStop = true;
            newEmployeeLink.Text = "ახალი თანამშრომელი";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 397);
            Controls.Add(newEmployeeLink);
            Controls.Add(exitLabel);
            Controls.Add(headerLabel);
            Controls.Add(signInBtn);
            Controls.Add(pinValue);
            Controls.Add(pinLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pinLabel;
        private TextBox pinValue;
        private Button signInBtn;
        private Label headerLabel;
        private Label exitLabel;
        private LinkLabel newEmployeeLink;
    }
}
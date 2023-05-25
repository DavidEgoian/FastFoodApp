using FastFood.Models;
using FastFood.Service;

namespace FastFood.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void signInBtn_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var allEmployees = await GlobalConfig.DataConnection.GetAllEmployee();
                var singleEmployee = await GlobalConfig.DataConnection.GetEmployeeByPin(pinValue.Text);
                var companyBalance = await GlobalConfig.DataConnection.GetBalance();

                if (allEmployees.Any(emp => emp.Equals(singleEmployee)))
                {
                    //გადავიყვანო ახალ ფორმაზე
                    MainForm mainForm = new(singleEmployee, companyBalance);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("მომხმარებელი ვერ მოიძებმა", "არასწორი მომხმარებელი", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("შემოყვანილი პარამეტრები არასწორია", "არასწორი პარამეტრი", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FormIsValid()
        {
            return !string.IsNullOrWhiteSpace(pinValue.Text) && pinValue.Text.Length == 11;
        }

        private void newEmployeeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateEmployeeForm createEmployeeForm = new();
            createEmployeeForm.ShowDialog();
        }
    }
}
using FastFood.Models;
using FastFood.Service;

namespace FastFood.UI
{
    public partial class Form1 : Form
    {
        //var resultBalance = await GlobalConfig.DataConnection.GetBalance();
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

                if (allEmployees.Any(emp=>emp.Equals(singleEmployee)))
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
    }
}
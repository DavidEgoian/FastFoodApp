using FastFood.Models;
using FastFood.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.UI
{
    public partial class CreateEmployeeForm : Form
    {
        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void signUpBtn_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {

                var addedEmployee = await GlobalConfig.DataConnection.AddNewEmployee(new Employee { Pin = pinValue.Text});
                if (addedEmployee is null )
                {
                    MessageBox.Show("თანამშრომლის დამატება ვერ მოხერხდა", "არასწორი თანამშრომელი", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("თანამშრომელი წარმატებით დაემატა", "ახალი თანამშრომელი", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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

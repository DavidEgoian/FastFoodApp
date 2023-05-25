using FastFood.Models;
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
    public partial class MainForm : Form
    {
        private readonly Employee _signedInEmployee;
        private readonly General _general;
        public MainForm(Employee signedInEmployee, General general)
        {
            InitializeComponent();
            _signedInEmployee = signedInEmployee;
            _general = general;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            signedInPinLabel.Text += " " + _signedInEmployee.Pin;
            companyBalanceLabel.Text += _general.Balance + " ლ";
        }
    }
}

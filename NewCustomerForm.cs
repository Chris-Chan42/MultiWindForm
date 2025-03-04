using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindForm
{
    public partial class NewCustomerForm : Form
    {
        private MainForm _mainForm;
        private int CustomerCount;
        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            CustomerCount = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                CustomerID = 0,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text
            };

            _mainForm.AddCustomer(customer);
            CustomerCount++;

            ClearForm();

            Hide();
        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        public void LoadCustomer(Customer customer)
        {
            txtName.Text = customer.Name;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtEmail.Text = customer.Email;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

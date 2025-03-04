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
        private bool IsEditing;
        private int CurrentSelectionId;

        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            CustomerCount = 1;
            IsEditing = false;
            CurrentSelectionId = -1;
        }

        public void ToggleEdit(bool newState)
        {
            IsEditing = newState;   
        }

        public void CreateCustomer() 
        {
            Customer customer = new Customer
                {
                    CustomerID = CustomerCount,
                    Name = txtName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                };

                _mainForm.AddCustomer(customer);
                CustomerCount++;
        }

        private void EditCustomer()
        {
            MessageBox.Show("Form is being edited.");
            _mainForm.EditCustomer(CurrentSelectionId, new Customer
            {
                CustomerID = CurrentSelectionId,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text
            });

            CurrentSelectionId = -1;
            ToggleEdit(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditing) 
            { 
               EditCustomer();
            }
            else
            {
                CreateCustomer();
            }
            

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
            CurrentSelectionId = customer.CustomerID;
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

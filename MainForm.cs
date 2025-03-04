namespace MultiWindForm
{
    public partial class MainForm : Form
    {
        private NewCustomerForm _customerForm;
        private List<Customer> _customerList;
        public MainForm()
        {
            InitializeComponent();
            _customerForm = new NewCustomerForm(this);
            _customerList = new List<Customer>();

            _customerList.Add(new Customer
            {
                Name = "John Doe",
                PhoneNumber = "555-0369",
                Email = "christian.garcia@student.centralia.edu"
            });

           ReloadDataGrid();
        }

        private void ReloadDataGrid()
        {
            dvgCustomers.DataSource = null;
            dvgCustomers.DataSource = _customerList;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            _customerForm.ShowDialog();
        }

        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
           ReloadDataGrid();
        }
    }
}

using System;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.Utility;

namespace Accounting
{
    public partial class frmAddOrEdit : Form
    {
        public int customerId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void MessageBox(string messageBoxText)
        {
            CustomMessageBox messageBox = new CustomMessageBox();
            messageBox.lblText = messageBoxText;
            messageBox.ShowDialog();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Customers customer = new Customers()
                    {
                        FullName = txtName.Text,
                        Mobile = txtMobile.Text != "" ? txtMobile.Text : "-",
                        Email = txtEmail.Text != "" ? txtEmail.Text : "-",
                        Address = txtAddress.Text != "" ? txtAddress.Text : "-"
                    };
                    if (customerId == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customer);
                    }
                    else
                    {
                        customer.CustomerID = customerId;
                        db.CustomerRepository.UpdateCustomer(customer);
                    }
                    if(db.Save())
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox("لطفا نام شخص را وارد کنید");
            }
        }

        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customer = db.CustomerRepository.GetCustomerById(customerId);
                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                }   
            }
        }
    }
}

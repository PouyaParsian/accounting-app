using Accounting.DataLayer.Context;
using Accounting.Utility;
using System;
using System.Windows.Forms;

namespace Accounting
{
    public partial class frmEditTransaction : Form
    {
        public int transactionId = 0;
        public string customerName;
        public frmEditTransaction()
        {
            InitializeComponent();
        }
        private void MessageBox(string messageBoxText)
        {
            CustomMessageBox messageBox = new CustomMessageBox();
            messageBox.lblText = messageBoxText;
            messageBox.ShowDialog();
        }

        private void frmEditTransaction_Load(object sender, EventArgs e)
        {
            if (transactionId != 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var transaction = db.AccountingRepository.GetTransactionById(transactionId);
                    txtCustomerName.Text = customerName;
                    txtAmount.Value = decimal.Parse(transaction.Amount.Replace("تومان", "").Trim());
                    txtDate.Text = transaction.DateTime;
                    txtDescription.Text = transaction.Description;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Value = 0;
            txtDate.Text = "";
            txtDescription.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Value != 0 && txtDate.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var existingTransaction = db.AccountingRepository.GetTransactionById(transactionId);
                    existingTransaction.Amount = txtAmount.Value.ToString("N0");
                    existingTransaction.Description = txtDescription.Text != "" ? txtDescription.Text : "بدون شرح";
                    existingTransaction.DateTime = txtDate.Text;
                    db.AccountingRepository.UpdateTransaction(existingTransaction);
                    if (db.Save())
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox("اطلاعات خواسته شده را وارد کنید");
            }
        }

        private void TxtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '/' && txtDate.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }
    }
}

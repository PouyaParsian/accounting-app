using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.Utility;
using Accounding.ViewModels;

namespace Accounting
{
    public partial class mainForm : Form
    {
        #region Constants

        private static readonly Color ACTIVE_TAB_COLOR = Color.LightGray;
        private static readonly Color INACTIVE_TAB_COLOR = Color.FromArgb(239, 239, 242);
        private const string DEFAULT_COMBO_TEXT = "انتخاب کنید";
        private const string NO_DESCRIPTION_TEXT = "بدون شرح";

        #endregion

        #region Constructor

        public mainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Custom MessageBox

        private void MessageBox(string messageBoxText)
        {
            using (CustomMessageBox messageBox = new CustomMessageBox())
            {
                messageBox.lblText = messageBoxText;
                messageBox.ShowDialog();
            }
        }

        #endregion

        #region Navigation Methods

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            ShowPanel(gpCustomers, btnCustomers);
            LoadCustomersData();
        }

        private void BtnNewTransaction_Click(object sender, EventArgs e)
        {
            ShowPanel(gpTransaction, btnNewTransaction);
            LoadTransactionFormData();
        }

        private void BtnReceiveReport_Click(object sender, EventArgs e)
        {
            ShowPanel(gpReciveReport, btnReceiveReport);
            LoadReceiveReportData();
        }

        private void BtnPaymentReport_Click(object sender, EventArgs e)
        {
            ShowPanel(gpPaymentReport, btnPaymentReport);
            LoadPaymentReportData();
        }

        private void ShowPanel(GroupBox panelToShow, Button activeButton)
        {
            gpCustomers.Hide();
            gpTransaction.Hide();
            gpReciveReport.Hide();
            gpPaymentReport.Hide();

            panelToShow.Show();

            btnCustomers.BackColor = INACTIVE_TAB_COLOR;
            btnNewTransaction.BackColor = INACTIVE_TAB_COLOR;
            btnReceiveReport.BackColor = INACTIVE_TAB_COLOR;
            btnPaymentReport.BackColor = INACTIVE_TAB_COLOR;

            activeButton.BackColor = ACTIVE_TAB_COLOR;
        }

        #endregion

        #region Application Exit

        private void BtnExit_Click(object sender, EventArgs e)
        {
            using (CustomYesOrNoMessageBox messageBox = new CustomYesOrNoMessageBox())
            {
                messageBox.lblText = $"آیا از خروج خود مطمئن هستید؟";
                if (messageBox.ShowDialog() == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        #endregion

        #region Form Load

        private void MainForm_Load(object sender, EventArgs e)
        {
            gpCustomers.Hide();
            gpTransaction.Hide();
            gpReciveReport.Hide();
            gpPaymentReport.Hide();
        }

        #endregion

        #region Data Loading Methods - Optimized

        private void LoadCustomersData()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ConfigureDataGridView(dgvCustomers);
                dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void LoadTransactionFormData()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ConfigureDataGridView(dgvCustomersName);
                dgvCustomersName.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void LoadReceiveReportData()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ConfigureDataGridView(dgvRecives);
                dgvRecives.DataSource = db.AccountingRepository.GetAllTransaction("Recive");

                PopulateCustomerComboBox(cbCustomers_recive, db);
                UpdateCustomerNamesInGrid(dgvRecives, db);
            }
        }

        private void LoadPaymentReportData()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ConfigureDataGridView(dgvPayment);
                dgvPayment.DataSource = db.AccountingRepository.GetAllTransaction("Payment");

                PopulateCustomerComboBox(cbCustomers_payment, db);
                UpdateCustomerNamesInGrid(dgvPayment, db);
            }
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("IRANSansXFaNum", 9, FontStyle.Regular);
            dgv.AutoGenerateColumns = false;
        }

        private void PopulateCustomerComboBox(ComboBox comboBox, UnitOfWork db)
        {
            List<ListCustomerViewModel> customerList = new List<ListCustomerViewModel>
            {
                new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    CustomerName = DEFAULT_COMBO_TEXT
                }
            };
            customerList.AddRange(db.CustomerRepository.GetCustomersName());

            comboBox.DataSource = customerList;
            comboBox.DisplayMember = "CustomerName";
            comboBox.ValueMember = "CustomerID";
        }

        private void UpdateCustomerNamesInGrid(DataGridView dgv, UnitOfWork db)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    int customerId = int.Parse(row.Cells[1].Value.ToString());
                    row.Cells[2].Value = db.CustomerRepository.GetCustomerNameById(customerId);
                }
            }
        }

        #endregion

        #region Customer Management

        private void TxtFilterName_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomersName.DataSource = db.CustomerRepository.GetCustomerByFilter(txtFilterNames.Text);
            }
        }

        private void TxtFilterCustomers_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository.GetCustomerByFilter(txtFilterCustomers.Text);
            }
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            using (frmAddOrEdit frmAdd = new frmAddOrEdit())
            {
                if (frmAdd.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomersData();
                }
            }
        }

        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
                return;

            using (UnitOfWork db = new UnitOfWork())
            {
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                string customerName = dgvCustomers.CurrentRow.Cells[1].Value.ToString();

                using (CustomYesOrNoMessageBox messageBox = new CustomYesOrNoMessageBox())
                {
                    messageBox.lblText = $"آیا از حذف {customerName} مطمئن هستید؟";
                    if (messageBox.ShowDialog() == DialogResult.Yes)
                    {
                        db.CustomerRepository.DeleteCustomer(customerId);
                        if (db.Save())
                        {
                            LoadCustomersData();
                        }
                    }
                }
            }
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
                return;

            int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());

            using (frmAddOrEdit frmEdit = new frmAddOrEdit())
            {
                frmEdit.customerId = customerId;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomersData();
                }
            }
        }

        private void BtnRefreshCustomers_Click(object sender, EventArgs e)
        {
            txtFilterCustomers.Text = "";
            LoadCustomersData();
        }

        #endregion

        #region Transaction Management

        private void DgvCustomersName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomersName.CurrentRow != null && dgvCustomersName.CurrentRow.Cells[1].Value != null)
                {
                    txtName.Text = dgvCustomersName.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox("مشکلی پیش آمده");
            }
        }

        private void BtnRemoveTransaction_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAmount.Value = 0;
            txtDescription.Text = "";
            rbRecive.Checked = false;
            rbPay.Checked = false;
        }

        private void BtnSaveTransaction_Click(object sender, EventArgs e)
        {
            if (txtAmount.Value <= 0 || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox("لطفا مقادیر خواسته شده را وارد کنید");
                return;
            }

            if (!rbPay.Checked && !rbRecive.Checked)
            {
                MessageBox("لطفا نوع تراکنش را مشخص کنید");
                return;
            }

            using (UnitOfWork db = new UnitOfWork())
            {
                DateConverter dateConverter = new DateConverter();

                DataLayer.Accounting accounting = new DataLayer.Accounting()
                {
                    Amount = txtAmount.Value.ToString("N0"),
                    CustomerID = int.Parse(dgvCustomersName.CurrentRow.Cells[0].Value.ToString()),
                    TypeID = rbRecive.Checked ? 1 : 2,
                    DateTime = dateConverter.MiladyToShamsy(DateTime.Now),
                    Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? NO_DESCRIPTION_TEXT : txtDescription.Text
                };

                db.AccountingRepository.InsertTransaction(accounting);

                if (db.Save())
                {
                    BtnRemoveTransaction_Click(null, null);
                }
            }
        }

        #endregion

        #region Receive Report Management

        private void btnRefreshRecives_Click(object sender, EventArgs e)
        {
            LoadReceiveReportData();
        }

        private void btnRemoveRecive_Click(object sender, EventArgs e)
        {
            if (dgvRecives.CurrentRow == null)
                return;

            using (UnitOfWork db = new UnitOfWork())
            {
                int transactionId = int.Parse(dgvRecives.CurrentRow.Cells[0].Value.ToString());
                string customerName = dgvRecives.CurrentRow.Cells[2].Value.ToString();

                using (CustomYesOrNoMessageBox messageBox = new CustomYesOrNoMessageBox())
                {
                    messageBox.lblText = $"آیا از حذف {customerName} مطمئن هستید؟";
                    if (messageBox.ShowDialog() == DialogResult.Yes)
                    {
                        db.AccountingRepository.DeleteTransaction(transactionId);
                        if (db.Save())
                        {
                            LoadReceiveReportData();
                        }
                    }
                }
            }
        }

        private void btnEditRecive_Click(object sender, EventArgs e)
        {
            if (dgvRecives.CurrentRow == null)
                return;

            int transactionId = int.Parse(dgvRecives.CurrentRow.Cells[0].Value.ToString());
            string customerName = dgvRecives.CurrentRow.Cells[2].Value.ToString();

            using (frmEditTransaction frmEditTransaction = new frmEditTransaction())
            {
                frmEditTransaction.transactionId = transactionId;
                frmEditTransaction.customerName = customerName;
                if (frmEditTransaction.ShowDialog() == DialogResult.OK)
                {
                    LoadReceiveReportData();
                }
            }
        }

        private void BtnFilterRecives_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvRecives.DataSource = db.AccountingRepository.GetTransactionByFilter(
                    txtFilterRecives.Text,
                    (int)cbCustomers_recive.SelectedValue,
                    1);
                UpdateCustomerNamesInGrid(dgvRecives, db);
            }
        }

        private void BtnPrintRecives_Click(object sender, EventArgs e)
        {
            DataTable dataTable = CreateReportDataTable(dgvRecives);
            stiReport.Load(Application.StartupPath + "/reciveReport.mrt");
            stiReport.RegData("DT", dataTable);
            stiReport.Show();
        }

        #endregion

        #region Payment Report Management

        private void btnRefreshPayments_Click(object sender, EventArgs e)
        {
            LoadPaymentReportData();
        }

        private void btnRemovePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow == null)
                return;

            using (UnitOfWork db = new UnitOfWork())
            {
                int transactionId = int.Parse(dgvPayment.CurrentRow.Cells[0].Value.ToString());
                string customerName = dgvPayment.CurrentRow.Cells[2].Value.ToString();

                using (CustomYesOrNoMessageBox messageBox = new CustomYesOrNoMessageBox())
                {
                    messageBox.lblText = $"آیا از حذف {customerName} مطمئن هستید؟";
                    if (messageBox.ShowDialog() == DialogResult.Yes)
                    {
                        db.AccountingRepository.DeleteTransaction(transactionId);
                        if (db.Save())
                        {
                            LoadPaymentReportData();
                        }
                    }
                }
            }
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow == null)
                return;

            int transactionId = int.Parse(dgvPayment.CurrentRow.Cells[0].Value.ToString());
            string customerName = dgvPayment.CurrentRow.Cells[2].Value.ToString();

            using (frmEditTransaction frmEditTransaction = new frmEditTransaction())
            {
                frmEditTransaction.transactionId = transactionId;
                frmEditTransaction.customerName = customerName;
                if (frmEditTransaction.ShowDialog() == DialogResult.OK)
                {
                    LoadPaymentReportData();
                }
            }
        }

        private void BtnFilterPayments_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPayment.DataSource = db.AccountingRepository.GetTransactionByFilter(
                    txtFilterPayments.Text,
                    (int)cbCustomers_payment.SelectedValue,
                    2);
                UpdateCustomerNamesInGrid(dgvPayment, db);
            }
        }

        private void BtnPrintPayments_Click(object sender, EventArgs e)
        {
            DataTable dataTable = CreateReportDataTable(dgvPayment);
            stiReport.Load(Application.StartupPath + "/paymentReport.mrt");
            stiReport.RegData("DT", dataTable);
            stiReport.Show();
        }

        #endregion

        #region Helper Methods

        private DataTable CreateReportDataTable(DataGridView dgv)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Description");

            foreach (DataGridViewRow item in dgv.Rows)
            {
                dataTable.Rows.Add(
                    item.Cells[2].Value?.ToString() ?? "",
                    item.Cells[3].Value?.ToString() ?? "",
                    item.Cells[4].Value?.ToString() ?? "",
                    item.Cells[5].Value?.ToString() ?? ""
                );
            }

            return dataTable;
        }

        #endregion
    }
}
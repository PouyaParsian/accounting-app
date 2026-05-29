namespace Accounting
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPaymentReport = new System.Windows.Forms.Button();
            this.btnReceiveReport = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.gpTransaction = new System.Windows.Forms.GroupBox();
            this.btnRemoveTransaction = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.rbRecive = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFilterNames = new System.Windows.Forms.TextBox();
            this.dgvCustomersName = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gpCustomers = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilterCustomers = new System.Windows.Forms.TextBox();
            this.btnRefreshCustomers = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpReciveReport = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilterRecives = new System.Windows.Forms.Button();
            this.cbCustomers_recive = new System.Windows.Forms.ComboBox();
            this.txtFilterRecives = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRecives = new System.Windows.Forms.DataGridView();
            this.btnRefreshRecives = new System.Windows.Forms.Button();
            this.btnEditRecive = new System.Windows.Forms.Button();
            this.btnRemoveRecive = new System.Windows.Forms.Button();
            this.btnPrintRecives = new System.Windows.Forms.Button();
            this.gpPaymentReport = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterPayments = new System.Windows.Forms.Button();
            this.cbCustomers_payment = new System.Windows.Forms.ComboBox();
            this.txtFilterPayments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.btnRefreshPayments = new System.Windows.Forms.Button();
            this.btnEditPayment = new System.Windows.Forms.Button();
            this.btnRemovePayment = new System.Windows.Forms.Button();
            this.btnPrintPayments = new System.Windows.Forms.Button();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.ReciveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel.SuspendLayout();
            this.gpTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersName)).BeginInit();
            this.gpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gpReciveReport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecives)).BeginInit();
            this.gpPaymentReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // groupPanel
            // 
            this.groupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel.Controls.Add(this.btnExit);
            this.groupPanel.Controls.Add(this.btnPaymentReport);
            this.groupPanel.Controls.Add(this.btnReceiveReport);
            this.groupPanel.Controls.Add(this.btnNewTransaction);
            this.groupPanel.Controls.Add(this.btnCustomers);
            this.groupPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel.Location = new System.Drawing.Point(494, 0);
            this.groupPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(224, 387);
            // 
            // 
            // 
            this.groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel.Style.BackColorGradientAngle = 90;
            this.groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderBottomWidth = 1;
            this.groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderLeftWidth = 1;
            this.groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderRightWidth = 1;
            this.groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel.Style.BorderTopWidth = 1;
            this.groupPanel.Style.CornerDiameter = 4;
            this.groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Peyda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-3, 313);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnExit.Size = new System.Drawing.Size(224, 69);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "خروج از برنامه";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPaymentReport
            // 
            this.btnPaymentReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPaymentReport.FlatAppearance.BorderSize = 0;
            this.btnPaymentReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPaymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentReport.Font = new System.Drawing.Font("Peyda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPaymentReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentReport.Image")));
            this.btnPaymentReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentReport.Location = new System.Drawing.Point(-3, 234);
            this.btnPaymentReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPaymentReport.Name = "btnPaymentReport";
            this.btnPaymentReport.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnPaymentReport.Size = new System.Drawing.Size(224, 69);
            this.btnPaymentReport.TabIndex = 4;
            this.btnPaymentReport.Text = "گزارش پرداخت";
            this.btnPaymentReport.UseVisualStyleBackColor = true;
            this.btnPaymentReport.Click += new System.EventHandler(this.BtnPaymentReport_Click);
            // 
            // btnReceiveReport
            // 
            this.btnReceiveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiveReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnReceiveReport.FlatAppearance.BorderSize = 0;
            this.btnReceiveReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnReceiveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveReport.Font = new System.Drawing.Font("Peyda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReceiveReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReceiveReport.Image")));
            this.btnReceiveReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceiveReport.Location = new System.Drawing.Point(-3, 155);
            this.btnReceiveReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReceiveReport.Name = "btnReceiveReport";
            this.btnReceiveReport.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnReceiveReport.Size = new System.Drawing.Size(224, 69);
            this.btnReceiveReport.TabIndex = 3;
            this.btnReceiveReport.Text = "گزارش دریافت";
            this.btnReceiveReport.UseVisualStyleBackColor = true;
            this.btnReceiveReport.Click += new System.EventHandler(this.BtnReceiveReport_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnNewTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewTransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Font = new System.Drawing.Font("Peyda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransaction.Image")));
            this.btnNewTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTransaction.Location = new System.Drawing.Point(-3, 76);
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnNewTransaction.Size = new System.Drawing.Size(224, 69);
            this.btnNewTransaction.TabIndex = 2;
            this.btnNewTransaction.Text = "تراکنش جدید";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.BtnNewTransaction_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Peyda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(-3, -3);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnCustomers.Size = new System.Drawing.Size(224, 69);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "لیست اشخاص";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // gpTransaction
            // 
            this.gpTransaction.BackColor = System.Drawing.Color.Transparent;
            this.gpTransaction.Controls.Add(this.btnRemoveTransaction);
            this.gpTransaction.Controls.Add(this.txtDescription);
            this.gpTransaction.Controls.Add(this.label6);
            this.gpTransaction.Controls.Add(this.btnSaveTransaction);
            this.gpTransaction.Controls.Add(this.txtAmount);
            this.gpTransaction.Controls.Add(this.label5);
            this.gpTransaction.Controls.Add(this.rbPay);
            this.gpTransaction.Controls.Add(this.rbRecive);
            this.gpTransaction.Controls.Add(this.label4);
            this.gpTransaction.Controls.Add(this.label3);
            this.gpTransaction.Controls.Add(this.txtName);
            this.gpTransaction.Controls.Add(this.txtFilterNames);
            this.gpTransaction.Controls.Add(this.dgvCustomersName);
            this.gpTransaction.Controls.Add(this.label2);
            this.gpTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpTransaction.Location = new System.Drawing.Point(0, 0);
            this.gpTransaction.Name = "gpTransaction";
            this.gpTransaction.Size = new System.Drawing.Size(718, 387);
            this.gpTransaction.TabIndex = 7;
            this.gpTransaction.TabStop = false;
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveTransaction.FlatAppearance.BorderSize = 0;
            this.btnRemoveTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTransaction.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemoveTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTransaction.Image")));
            this.btnRemoveTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTransaction.Location = new System.Drawing.Point(234, 334);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnRemoveTransaction.Size = new System.Drawing.Size(120, 41);
            this.btnRemoveTransaction.TabIndex = 23;
            this.btnRemoveTransaction.Text = "پاک کردن";
            this.btnRemoveTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveTransaction.UseVisualStyleBackColor = false;
            this.btnRemoveTransaction.Click += new System.EventHandler(this.BtnRemoveTransaction_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("IRANSansXFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDescription.Location = new System.Drawing.Point(234, 189);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(248, 126);
            this.txtDescription.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "توضیحات";
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnSaveTransaction.FlatAppearance.BorderSize = 0;
            this.btnSaveTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnSaveTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnSaveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTransaction.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTransaction.Image")));
            this.btnSaveTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTransaction.Location = new System.Drawing.Point(362, 334);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.btnSaveTransaction.Size = new System.Drawing.Size(120, 41);
            this.btnSaveTransaction.TabIndex = 22;
            this.btnSaveTransaction.Text = "ثبت";
            this.btnSaveTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTransaction.UseVisualStyleBackColor = false;
            this.btnSaveTransaction.Click += new System.EventHandler(this.BtnSaveTransaction_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("IRANSansXFaNum", 11.25F);
            this.txtAmount.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtAmount.Location = new System.Drawing.Point(234, 112);
            this.txtAmount.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(145, 26);
            this.txtAmount.TabIndex = 19;
            this.txtAmount.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "* مبلغ (تومان)";
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(234, 57);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(76, 31);
            this.rbPay.TabIndex = 17;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "پرداخت";
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // rbRecive
            // 
            this.rbRecive.AutoSize = true;
            this.rbRecive.Location = new System.Drawing.Point(312, 57);
            this.rbRecive.Name = "rbRecive";
            this.rbRecive.Size = new System.Drawing.Size(75, 31);
            this.rbRecive.TabIndex = 16;
            this.rbRecive.TabStop = true;
            this.rbRecive.Text = "دریافت";
            this.rbRecive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "* نوع تراکنش";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "جستجو";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("IRANSansXFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(234, 13);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(128, 27);
            this.txtName.TabIndex = 14;
            // 
            // txtFilterNames
            // 
            this.txtFilterNames.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFilterNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterNames.Font = new System.Drawing.Font("IRANSansXFaNum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFilterNames.Location = new System.Drawing.Point(12, 348);
            this.txtFilterNames.Multiline = true;
            this.txtFilterNames.Name = "txtFilterNames";
            this.txtFilterNames.Size = new System.Drawing.Size(140, 27);
            this.txtFilterNames.TabIndex = 25;
            this.txtFilterNames.TextChanged += new System.EventHandler(this.TxtFilterName_TextChanged);
            // 
            // dgvCustomersName
            // 
            this.dgvCustomersName.AllowUserToAddRows = false;
            this.dgvCustomersName.AllowUserToDeleteRows = false;
            this.dgvCustomersName.AllowUserToResizeRows = false;
            this.dgvCustomersName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomersName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvCustomersName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomersName.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomersName.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Peyda(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomersName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Peyda(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomersName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomersName.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvCustomersName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvCustomersName.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomersName.Name = "dgvCustomersName";
            this.dgvCustomersName.ReadOnly = true;
            this.dgvCustomersName.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomersName.RowHeadersVisible = false;
            this.dgvCustomersName.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomersName.RowTemplate.ReadOnly = true;
            this.dgvCustomersName.ShowCellErrors = false;
            this.dgvCustomersName.ShowCellToolTips = false;
            this.dgvCustomersName.ShowEditingIcon = false;
            this.dgvCustomersName.ShowRowErrors = false;
            this.dgvCustomersName.Size = new System.Drawing.Size(201, 330);
            this.dgvCustomersName.TabIndex = 26;
            this.dgvCustomersName.TabStop = false;
            this.dgvCustomersName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomersName_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام اشخاص";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "* شخص مورد نظر";
            // 
            // gpCustomers
            // 
            this.gpCustomers.BackColor = System.Drawing.Color.Transparent;
            this.gpCustomers.Controls.Add(this.dgvCustomers);
            this.gpCustomers.Controls.Add(this.txtFilterCustomers);
            this.gpCustomers.Controls.Add(this.btnRefreshCustomers);
            this.gpCustomers.Controls.Add(this.btnEditCustomer);
            this.gpCustomers.Controls.Add(this.btnRemoveCustomer);
            this.gpCustomers.Controls.Add(this.btnAddCustomer);
            this.gpCustomers.Controls.Add(this.label1);
            this.gpCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpCustomers.Location = new System.Drawing.Point(0, 0);
            this.gpCustomers.Name = "gpCustomers";
            this.gpCustomers.Size = new System.Drawing.Size(718, 387);
            this.gpCustomers.TabIndex = 7;
            this.gpCustomers.TabStop = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.FullName,
            this.Mobile,
            this.Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Peyda(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvCustomers.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvCustomers.Location = new System.Drawing.Point(8, 132);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomers.RowTemplate.ReadOnly = true;
            this.dgvCustomers.ShowCellErrors = false;
            this.dgvCustomers.ShowCellToolTips = false;
            this.dgvCustomers.ShowEditingIcon = false;
            this.dgvCustomers.ShowRowErrors = false;
            this.dgvCustomers.Size = new System.Drawing.Size(480, 248);
            this.dgvCustomers.TabIndex = 12;
            this.dgvCustomers.TabStop = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerID";
            this.CustomerId.HeaderText = "CustomerID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // txtFilterCustomers
            // 
            this.txtFilterCustomers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFilterCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterCustomers.Font = new System.Drawing.Font("IRANSansXFaNum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFilterCustomers.Location = new System.Drawing.Point(8, 86);
            this.txtFilterCustomers.Multiline = true;
            this.txtFilterCustomers.Name = "txtFilterCustomers";
            this.txtFilterCustomers.Size = new System.Drawing.Size(418, 27);
            this.txtFilterCustomers.TabIndex = 11;
            this.txtFilterCustomers.TextChanged += new System.EventHandler(this.TxtFilterCustomers_TextChanged);
            // 
            // btnRefreshCustomers
            // 
            this.btnRefreshCustomers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshCustomers.FlatAppearance.BorderSize = 0;
            this.btnRefreshCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCustomers.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefreshCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCustomers.Image")));
            this.btnRefreshCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCustomers.Location = new System.Drawing.Point(8, 8);
            this.btnRefreshCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshCustomers.Name = "btnRefreshCustomers";
            this.btnRefreshCustomers.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnRefreshCustomers.Size = new System.Drawing.Size(114, 61);
            this.btnRefreshCustomers.TabIndex = 9;
            this.btnRefreshCustomers.Text = "بروزرسانی";
            this.btnRefreshCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshCustomers.UseVisualStyleBackColor = false;
            this.btnRefreshCustomers.Click += new System.EventHandler(this.BtnRefreshCustomers_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.Image")));
            this.btnEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomer.Location = new System.Drawing.Point(130, 8);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnEditCustomer.Size = new System.Drawing.Size(114, 61);
            this.btnEditCustomer.TabIndex = 8;
            this.btnEditCustomer.Text = "ویرایش";
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveCustomer.FlatAppearance.BorderSize = 0;
            this.btnRemoveCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemoveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCustomer.Image")));
            this.btnRemoveCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(252, 8);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnRemoveCustomer.Size = new System.Drawing.Size(114, 61);
            this.btnRemoveCustomer.TabIndex = 7;
            this.btnRemoveCustomer.Text = "حذف";
            this.btnRemoveCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.BtnRemoveCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(374, 8);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(114, 61);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "افزودن";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "جستجو";
            // 
            // gpReciveReport
            // 
            this.gpReciveReport.BackColor = System.Drawing.Color.Transparent;
            this.gpReciveReport.Controls.Add(this.groupBox1);
            this.gpReciveReport.Controls.Add(this.dgvRecives);
            this.gpReciveReport.Controls.Add(this.btnRefreshRecives);
            this.gpReciveReport.Controls.Add(this.btnEditRecive);
            this.gpReciveReport.Controls.Add(this.btnRemoveRecive);
            this.gpReciveReport.Controls.Add(this.btnPrintRecives);
            this.gpReciveReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpReciveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpReciveReport.Location = new System.Drawing.Point(0, 0);
            this.gpReciveReport.Name = "gpReciveReport";
            this.gpReciveReport.Size = new System.Drawing.Size(718, 387);
            this.gpReciveReport.TabIndex = 8;
            this.gpReciveReport.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnFilterRecives);
            this.groupBox1.Controls.Add(this.cbCustomers_recive);
            this.groupBox1.Controls.Add(this.txtFilterRecives);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 97);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // btnFilterRecives
            // 
            this.btnFilterRecives.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilterRecives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterRecives.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnFilterRecives.FlatAppearance.BorderSize = 0;
            this.btnFilterRecives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterRecives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterRecives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterRecives.Font = new System.Drawing.Font("Peyda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFilterRecives.Image = global::Accounting.Properties.Resources.icons8_Search_15px;
            this.btnFilterRecives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterRecives.Location = new System.Drawing.Point(12, 7);
            this.btnFilterRecives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterRecives.Name = "btnFilterRecives";
            this.btnFilterRecives.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnFilterRecives.Size = new System.Drawing.Size(78, 27);
            this.btnFilterRecives.TabIndex = 36;
            this.btnFilterRecives.Text = "اعمال";
            this.btnFilterRecives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilterRecives.UseVisualStyleBackColor = false;
            this.btnFilterRecives.Click += new System.EventHandler(this.BtnFilterRecives_Click);
            // 
            // cbCustomers_recive
            // 
            this.cbCustomers_recive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbCustomers_recive.DropDownHeight = 210;
            this.cbCustomers_recive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomers_recive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomers_recive.Font = new System.Drawing.Font("IRANSansXFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomers_recive.IntegralHeight = false;
            this.cbCustomers_recive.Location = new System.Drawing.Point(224, 46);
            this.cbCustomers_recive.Name = "cbCustomers_recive";
            this.cbCustomers_recive.Size = new System.Drawing.Size(160, 28);
            this.cbCustomers_recive.TabIndex = 33;
            // 
            // txtFilterRecives
            // 
            this.txtFilterRecives.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFilterRecives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterRecives.Font = new System.Drawing.Font("IRANSansXFaNum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFilterRecives.Location = new System.Drawing.Point(12, 47);
            this.txtFilterRecives.Multiline = true;
            this.txtFilterRecives.Name = "txtFilterRecives";
            this.txtFilterRecives.Size = new System.Drawing.Size(160, 27);
            this.txtFilterRecives.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 27);
            this.label9.TabIndex = 34;
            this.label9.Text = "فیلتر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "طرف حساب";
            // 
            // dgvRecives
            // 
            this.dgvRecives.AllowUserToAddRows = false;
            this.dgvRecives.AllowUserToDeleteRows = false;
            this.dgvRecives.AllowUserToResizeRows = false;
            this.dgvRecives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecives.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvRecives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecives.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecives.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciveID,
            this.ID,
            this.CustomName,
            this.Amount,
            this.ReciveDate,
            this.Description});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Peyda(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecives.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecives.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvRecives.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvRecives.Location = new System.Drawing.Point(8, 180);
            this.dgvRecives.Name = "dgvRecives";
            this.dgvRecives.ReadOnly = true;
            this.dgvRecives.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecives.RowHeadersVisible = false;
            this.dgvRecives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecives.RowTemplate.ReadOnly = true;
            this.dgvRecives.ShowCellErrors = false;
            this.dgvRecives.ShowCellToolTips = false;
            this.dgvRecives.ShowEditingIcon = false;
            this.dgvRecives.ShowRowErrors = false;
            this.dgvRecives.Size = new System.Drawing.Size(480, 200);
            this.dgvRecives.TabIndex = 37;
            this.dgvRecives.TabStop = false;
            // 
            // btnRefreshRecives
            // 
            this.btnRefreshRecives.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshRecives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshRecives.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshRecives.FlatAppearance.BorderSize = 0;
            this.btnRefreshRecives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshRecives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshRecives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRecives.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefreshRecives.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshRecives.Image")));
            this.btnRefreshRecives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshRecives.Location = new System.Drawing.Point(8, 8);
            this.btnRefreshRecives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshRecives.Name = "btnRefreshRecives";
            this.btnRefreshRecives.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnRefreshRecives.Size = new System.Drawing.Size(114, 61);
            this.btnRefreshRecives.TabIndex = 30;
            this.btnRefreshRecives.Text = "بروزرسانی";
            this.btnRefreshRecives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshRecives.UseVisualStyleBackColor = false;
            this.btnRefreshRecives.Click += new System.EventHandler(this.btnRefreshRecives_Click);
            // 
            // btnEditRecive
            // 
            this.btnEditRecive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditRecive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRecive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditRecive.FlatAppearance.BorderSize = 0;
            this.btnEditRecive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditRecive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditRecive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRecive.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditRecive.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRecive.Image")));
            this.btnEditRecive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRecive.Location = new System.Drawing.Point(130, 8);
            this.btnEditRecive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditRecive.Name = "btnEditRecive";
            this.btnEditRecive.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnEditRecive.Size = new System.Drawing.Size(114, 61);
            this.btnEditRecive.TabIndex = 29;
            this.btnEditRecive.Text = "ویرایش";
            this.btnEditRecive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditRecive.UseVisualStyleBackColor = false;
            this.btnEditRecive.Click += new System.EventHandler(this.btnEditRecive_Click);
            // 
            // btnRemoveRecive
            // 
            this.btnRemoveRecive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveRecive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveRecive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveRecive.FlatAppearance.BorderSize = 0;
            this.btnRemoveRecive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveRecive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemoveRecive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRecive.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemoveRecive.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveRecive.Image")));
            this.btnRemoveRecive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveRecive.Location = new System.Drawing.Point(252, 8);
            this.btnRemoveRecive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveRecive.Name = "btnRemoveRecive";
            this.btnRemoveRecive.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnRemoveRecive.Size = new System.Drawing.Size(114, 61);
            this.btnRemoveRecive.TabIndex = 28;
            this.btnRemoveRecive.Text = "حذف";
            this.btnRemoveRecive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveRecive.UseVisualStyleBackColor = false;
            this.btnRemoveRecive.Click += new System.EventHandler(this.btnRemoveRecive_Click);
            // 
            // btnPrintRecives
            // 
            this.btnPrintRecives.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrintRecives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintRecives.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPrintRecives.FlatAppearance.BorderSize = 0;
            this.btnPrintRecives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPrintRecives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPrintRecives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintRecives.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintRecives.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRecives.Image")));
            this.btnPrintRecives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintRecives.Location = new System.Drawing.Point(374, 8);
            this.btnPrintRecives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintRecives.Name = "btnPrintRecives";
            this.btnPrintRecives.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btnPrintRecives.Size = new System.Drawing.Size(114, 61);
            this.btnPrintRecives.TabIndex = 27;
            this.btnPrintRecives.Text = "چاپ";
            this.btnPrintRecives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintRecives.UseVisualStyleBackColor = false;
            this.btnPrintRecives.Click += new System.EventHandler(this.BtnPrintRecives_Click);
            // 
            // gpPaymentReport
            // 
            this.gpPaymentReport.BackColor = System.Drawing.Color.Transparent;
            this.gpPaymentReport.Controls.Add(this.groupBox2);
            this.gpPaymentReport.Controls.Add(this.dgvPayment);
            this.gpPaymentReport.Controls.Add(this.btnRefreshPayments);
            this.gpPaymentReport.Controls.Add(this.btnEditPayment);
            this.gpPaymentReport.Controls.Add(this.btnRemovePayment);
            this.gpPaymentReport.Controls.Add(this.btnPrintPayments);
            this.gpPaymentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpPaymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpPaymentReport.Location = new System.Drawing.Point(0, 0);
            this.gpPaymentReport.Name = "gpPaymentReport";
            this.gpPaymentReport.Size = new System.Drawing.Size(718, 387);
            this.gpPaymentReport.TabIndex = 9;
            this.gpPaymentReport.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.btnFilterPayments);
            this.groupBox2.Controls.Add(this.cbCustomers_payment);
            this.groupBox2.Controls.Add(this.txtFilterPayments);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(8, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 97);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // btnFilterPayments
            // 
            this.btnFilterPayments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilterPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnFilterPayments.FlatAppearance.BorderSize = 0;
            this.btnFilterPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPayments.Font = new System.Drawing.Font("Peyda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFilterPayments.Image = global::Accounting.Properties.Resources.icons8_Search_15px;
            this.btnFilterPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterPayments.Location = new System.Drawing.Point(12, 7);
            this.btnFilterPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterPayments.Name = "btnFilterPayments";
            this.btnFilterPayments.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnFilterPayments.Size = new System.Drawing.Size(78, 27);
            this.btnFilterPayments.TabIndex = 47;
            this.btnFilterPayments.Text = "اعمال";
            this.btnFilterPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilterPayments.UseVisualStyleBackColor = false;
            this.btnFilterPayments.Click += new System.EventHandler(this.BtnFilterPayments_Click);
            // 
            // cbCustomers_payment
            // 
            this.cbCustomers_payment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbCustomers_payment.DropDownHeight = 210;
            this.cbCustomers_payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomers_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomers_payment.Font = new System.Drawing.Font("IRANSansXFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomers_payment.IntegralHeight = false;
            this.cbCustomers_payment.Location = new System.Drawing.Point(224, 46);
            this.cbCustomers_payment.Name = "cbCustomers_payment";
            this.cbCustomers_payment.Size = new System.Drawing.Size(160, 28);
            this.cbCustomers_payment.TabIndex = 44;
            // 
            // txtFilterPayments
            // 
            this.txtFilterPayments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFilterPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterPayments.Font = new System.Drawing.Font("IRANSansXFaNum", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFilterPayments.Location = new System.Drawing.Point(12, 47);
            this.txtFilterPayments.Multiline = true;
            this.txtFilterPayments.Name = "txtFilterPayments";
            this.txtFilterPayments.Size = new System.Drawing.Size(160, 27);
            this.txtFilterPayments.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 27);
            this.label8.TabIndex = 45;
            this.label8.Text = "فیلتر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 27);
            this.label10.TabIndex = 43;
            this.label10.Text = "طرف حساب";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AllowUserToResizeRows = false;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.PaymentDate,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Peyda(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvPayment.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvPayment.Location = new System.Drawing.Point(8, 180);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayment.RowHeadersVisible = false;
            this.dgvPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayment.RowTemplate.ReadOnly = true;
            this.dgvPayment.ShowCellErrors = false;
            this.dgvPayment.ShowCellToolTips = false;
            this.dgvPayment.ShowEditingIcon = false;
            this.dgvPayment.ShowRowErrors = false;
            this.dgvPayment.Size = new System.Drawing.Size(480, 200);
            this.dgvPayment.TabIndex = 48;
            this.dgvPayment.TabStop = false;
            // 
            // btnRefreshPayments
            // 
            this.btnRefreshPayments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshPayments.FlatAppearance.BorderSize = 0;
            this.btnRefreshPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefreshPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPayments.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefreshPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshPayments.Image")));
            this.btnRefreshPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshPayments.Location = new System.Drawing.Point(8, 8);
            this.btnRefreshPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshPayments.Name = "btnRefreshPayments";
            this.btnRefreshPayments.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnRefreshPayments.Size = new System.Drawing.Size(114, 61);
            this.btnRefreshPayments.TabIndex = 41;
            this.btnRefreshPayments.Text = "بروزرسانی";
            this.btnRefreshPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshPayments.UseVisualStyleBackColor = false;
            this.btnRefreshPayments.Click += new System.EventHandler(this.btnRefreshPayments_Click);
            // 
            // btnEditPayment
            // 
            this.btnEditPayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditPayment.FlatAppearance.BorderSize = 0;
            this.btnEditPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnEditPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPayment.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPayment.Image")));
            this.btnEditPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPayment.Location = new System.Drawing.Point(130, 8);
            this.btnEditPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnEditPayment.Size = new System.Drawing.Size(114, 61);
            this.btnEditPayment.TabIndex = 40;
            this.btnEditPayment.Text = "ویرایش";
            this.btnEditPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditPayment.UseVisualStyleBackColor = false;
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);
            // 
            // btnRemovePayment
            // 
            this.btnRemovePayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemovePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemovePayment.FlatAppearance.BorderSize = 0;
            this.btnRemovePayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemovePayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRemovePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePayment.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemovePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePayment.Image")));
            this.btnRemovePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePayment.Location = new System.Drawing.Point(252, 8);
            this.btnRemovePayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemovePayment.Name = "btnRemovePayment";
            this.btnRemovePayment.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnRemovePayment.Size = new System.Drawing.Size(114, 61);
            this.btnRemovePayment.TabIndex = 39;
            this.btnRemovePayment.Text = "حذف";
            this.btnRemovePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePayment.UseVisualStyleBackColor = false;
            this.btnRemovePayment.Click += new System.EventHandler(this.btnRemovePayment_Click);
            // 
            // btnPrintPayments
            // 
            this.btnPrintPayments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrintPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPrintPayments.FlatAppearance.BorderSize = 0;
            this.btnPrintPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPrintPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnPrintPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPayments.Font = new System.Drawing.Font("Peyda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPayments.Image")));
            this.btnPrintPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPayments.Location = new System.Drawing.Point(374, 8);
            this.btnPrintPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintPayments.Name = "btnPrintPayments";
            this.btnPrintPayments.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btnPrintPayments.Size = new System.Drawing.Size(114, 61);
            this.btnPrintPayments.TabIndex = 38;
            this.btnPrintPayments.Text = "چاپ";
            this.btnPrintPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintPayments.UseVisualStyleBackColor = false;
            this.btnPrintPayments.Click += new System.EventHandler(this.BtnPrintPayments_Click);
            // 
            // stiReport
            // 
            this.stiReport.CookieContainer = null;
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "9561ffddf84141de98aabc20073be7b2";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = null;
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // ReciveID
            // 
            this.ReciveID.DataPropertyName = "ID";
            this.ReciveID.HeaderText = "ID";
            this.ReciveID.Name = "ReciveID";
            this.ReciveID.ReadOnly = true;
            this.ReciveID.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CustomerID";
            this.ID.HeaderText = "CustomerID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CustomName
            // 
            this.CustomName.HeaderText = "شخص";
            this.CustomName.Name = "CustomName";
            this.CustomName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ به تومان";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ReciveDate
            // 
            this.ReciveDate.DataPropertyName = "DateTime";
            this.ReciveDate.HeaderText = "تاریخ";
            this.ReciveDate.Name = "ReciveDate";
            this.ReciveDate.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // PaymentID
            // 
            this.PaymentID.DataPropertyName = "ID";
            this.PaymentID.HeaderText = "ID";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            this.PaymentID.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "شخص";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "مبلغ به تومان";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "DateTime";
            this.PaymentDate.HeaderText = "تاریخ";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(718, 387);
            this.Controls.Add(this.groupPanel);
            this.Controls.Add(this.gpPaymentReport);
            this.Controls.Add(this.gpReciveReport);
            this.Controls.Add(this.gpCustomers);
            this.Controls.Add(this.gpTransaction);
            this.Font = new System.Drawing.Font("Peyda(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupPanel.ResumeLayout(false);
            this.gpTransaction.ResumeLayout(false);
            this.gpTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersName)).EndInit();
            this.gpCustomers.ResumeLayout(false);
            this.gpCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gpReciveReport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecives)).EndInit();
            this.gpPaymentReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPaymentReport;
        private System.Windows.Forms.Button btnReceiveReport;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.GroupBox gpTransaction;
        private System.Windows.Forms.GroupBox gpCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtFilterCustomers;
        private System.Windows.Forms.Button btnRefreshCustomers;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterNames;
        private System.Windows.Forms.DataGridView dgvCustomersName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.RadioButton rbRecive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.GroupBox gpReciveReport;
        private System.Windows.Forms.DataGridView dgvRecives;
        private System.Windows.Forms.Button btnRefreshRecives;
        private System.Windows.Forms.Button btnEditRecive;
        private System.Windows.Forms.Button btnRemoveRecive;
        private System.Windows.Forms.Button btnPrintRecives;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpPaymentReport;
        private System.Windows.Forms.Button btnRefreshPayments;
        private System.Windows.Forms.Button btnEditPayment;
        private System.Windows.Forms.Button btnRemovePayment;
        private System.Windows.Forms.Button btnPrintPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.TextBox txtFilterRecives;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCustomers_recive;
        private System.Windows.Forms.Button btnFilterRecives;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilterPayments;
        private System.Windows.Forms.ComboBox cbCustomers_payment;
        private System.Windows.Forms.TextBox txtFilterPayments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}


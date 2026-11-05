namespace Bai02_LabEquipmentCheckout
{
    partial class frmLabCheckout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            sslTotal = new ToolStripStatusLabel();
            sslOverdue = new ToolStripStatusLabel();
            sslFiltered = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            pnlLeft = new Panel();
            grpInput = new GroupBox();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            dtpReturnDate = new DateTimePicker();
            chkReturned = new CheckBox();
            dtpDueDate = new DateTimePicker();
            lblDueDate = new Label();
            dtpBorrowDate = new DateTimePicker();
            lblBorrowDate = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cboEquipment = new ComboBox();
            lblEquipment = new Label();
            txtStudentName = new TextBox();
            lblStudentName = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            txtReceiptId = new TextBox();
            lblReceiptId = new Label();
            pnlButtons = new Panel();
            btnMarkReturned = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlRight = new Panel();
            grpList = new GroupBox();
            dgvReceipts = new DataGridView();
            grpFilter = new GroupBox();
            btnResetFilter = new Button();
            cboFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            errorProvider1 = new ErrorProvider(components);
            timerClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlLeft.SuspendLayout();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            pnlButtons.SuspendLayout();
            pnlRight.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv, toolStripSeparator1, menuExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(85, 24);
            menuSystem.Text = "Hệ thống";
            // 
            // menuExportCsv
            // 
            menuExportCsv.Name = "menuExportCsv";
            menuExportCsv.ShortcutKeys = Keys.Control | Keys.E;
            menuExportCsv.Size = new Size(257, 26);
            menuExportCsv.Text = "Xuất phiếu ra CSV...";
            menuExportCsv.Click += menuExportCsv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(254, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuExit.Size = new Size(257, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslTotal, sslOverdue, sslFiltered, sslClock });
            statusStrip1.Location = new Point(0, 667);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslTotal
            // 
            sslTotal.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslTotal.Name = "sslTotal";
            sslTotal.Size = new Size(140, 20);
            sslTotal.Text = "Tổng số phiếu: 0";
            // 
            // sslOverdue
            // 
            sslOverdue.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslOverdue.Name = "sslOverdue";
            sslOverdue.Size = new Size(150, 20);
            sslOverdue.Text = "Số phiếu quá hạn: 0";
            // 
            // sslFiltered
            // 
            sslFiltered.Name = "sslFiltered";
            sslFiltered.Size = new Size(631, 20);
            sslFiltered.Spring = true;
            sslFiltered.Text = "Đang hiển thị: 0 phiếu";
            sslFiltered.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sslClock
            // 
            sslClock.Name = "sslClock";
            sslClock.Size = new Size(140, 20);
            sslClock.Text = "Thời gian: 00:00:00";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(grpInput);
            pnlLeft.Controls.Add(pnlButtons);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 28);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(8);
            pnlLeft.Size = new Size(390, 639);
            pnlLeft.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(cboStatus);
            grpInput.Controls.Add(lblStatus);
            grpInput.Controls.Add(dtpReturnDate);
            grpInput.Controls.Add(chkReturned);
            grpInput.Controls.Add(dtpDueDate);
            grpInput.Controls.Add(lblDueDate);
            grpInput.Controls.Add(dtpBorrowDate);
            grpInput.Controls.Add(lblBorrowDate);
            grpInput.Controls.Add(numQuantity);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(cboEquipment);
            grpInput.Controls.Add(lblEquipment);
            grpInput.Controls.Add(txtStudentName);
            grpInput.Controls.Add(lblStudentName);
            grpInput.Controls.Add(txtStudentId);
            grpInput.Controls.Add(lblStudentId);
            grpInput.Controls.Add(txtReceiptId);
            grpInput.Controls.Add(lblReceiptId);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(8, 8);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(374, 503);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin phiếu mượn thiết bị";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(135, 435);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(220, 28);
            cboStatus.TabIndex = 17;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 438);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 20);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Tình trạng:";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpReturnDate.CustomFormat = "dd/MM/yyyy";
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.Location = new Point(135, 385);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(220, 27);
            dtpReturnDate.TabIndex = 15;
            // 
            // chkReturned
            // 
            chkReturned.AutoSize = true;
            chkReturned.Location = new Point(15, 387);
            chkReturned.Name = "chkReturned";
            chkReturned.Size = new Size(117, 24);
            chkReturned.TabIndex = 14;
            chkReturned.Text = "Ngày trả thực:";
            chkReturned.UseVisualStyleBackColor = true;
            chkReturned.CheckedChanged += chkReturned_CheckedChanged;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(135, 335);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(220, 27);
            dtpDueDate.TabIndex = 13;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(15, 338);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(65, 20);
            lblDueDate.TabIndex = 12;
            lblDueDate.Text = "Hạn trả:";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpBorrowDate.CustomFormat = "dd/MM/yyyy";
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.Location = new Point(135, 285);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(220, 27);
            dtpBorrowDate.TabIndex = 11;
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Location = new Point(15, 288);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(91, 20);
            lblBorrowDate.TabIndex = 10;
            lblBorrowDate.Text = "Ngày mượn:";
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numQuantity.Location = new Point(135, 235);
            numQuantity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(220, 27);
            numQuantity.TabIndex = 9;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 238);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // cboEquipment
            // 
            cboEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipment.FormattingEnabled = true;
            cboEquipment.Location = new Point(135, 185);
            cboEquipment.Name = "cboEquipment";
            cboEquipment.Size = new Size(220, 28);
            cboEquipment.TabIndex = 7;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(15, 188);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(84, 20);
            lblEquipment.TabIndex = 6;
            lblEquipment.Text = "Tên thiết bị:";
            // 
            // txtStudentName
            // 
            txtStudentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentName.Location = new Point(135, 135);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(220, 27);
            txtStudentName.TabIndex = 5;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(15, 138);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(100, 20);
            lblStudentName.TabIndex = 4;
            lblStudentName.Text = "Tên sinh viên:";
            // 
            // txtStudentId
            // 
            txtStudentId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentId.Location = new Point(135, 85);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(220, 27);
            txtStudentId.TabIndex = 3;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(15, 88);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(96, 20);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Mã sinh viên:";
            // 
            // txtReceiptId
            // 
            txtReceiptId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReceiptId.Location = new Point(135, 35);
            txtReceiptId.Name = "txtReceiptId";
            txtReceiptId.Size = new Size(220, 27);
            txtReceiptId.TabIndex = 1;
            // 
            // lblReceiptId
            // 
            lblReceiptId.AutoSize = true;
            lblReceiptId.Location = new Point(15, 38);
            lblReceiptId.Name = "lblReceiptId";
            lblReceiptId.Size = new Size(74, 20);
            lblReceiptId.TabIndex = 0;
            lblReceiptId.Text = "Mã phiếu:";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnMarkReturned);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(8, 511);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(374, 120);
            pnlButtons.TabIndex = 1;
            // 
            // btnMarkReturned
            // 
            btnMarkReturned.Location = new Point(10, 80);
            btnMarkReturned.Name = "btnMarkReturned";
            btnMarkReturned.Size = new Size(345, 32);
            btnMarkReturned.TabIndex = 4;
            btnMarkReturned.Text = "Đánh dấu đã trả thiết bị";
            btnMarkReturned.UseVisualStyleBackColor = true;
            btnMarkReturned.Click += btnMarkReturned_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(190, 44);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 30);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa phiếu";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(190, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm phiếu";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpList);
            pnlRight.Controls.Add(grpFilter);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(390, 28);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(8);
            pnlRight.Size = new Size(710, 639);
            pnlRight.TabIndex = 3;
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvReceipts);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(8, 98);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(8);
            grpList.Size = new Size(694, 533);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách mượn trả thiết bị thực hành (DataGridView)";
            // 
            // dgvReceipts
            // 
            dgvReceipts.AllowUserToAddRows = false;
            dgvReceipts.AllowUserToDeleteRows = false;
            dgvReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceipts.Dock = DockStyle.Fill;
            dgvReceipts.Location = new Point(8, 28);
            dgvReceipts.MultiSelect = false;
            dgvReceipts.Name = "dgvReceipts";
            dgvReceipts.ReadOnly = true;
            dgvReceipts.RowHeadersWidth = 35;
            dgvReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceipts.Size = new Size(678, 497);
            dgvReceipts.TabIndex = 0;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnResetFilter);
            grpFilter.Controls.Add(cboFilterStatus);
            grpFilter.Controls.Add(lblFilterStatus);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(lblSearch);
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Location = new Point(8, 8);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(694, 90);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Lọc phiếu mượn";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetFilter.Location = new Point(570, 48);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(110, 30);
            btnResetFilter.TabIndex = 4;
            btnResetFilter.Text = "Đặt lại lọc";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(135, 50);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(190, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(15, 53);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(107, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Lọc tình trạng:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(135, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã sinh viên hoặc tên thiết bị để tìm kiếm tức thời...";
            txtSearch.Size = new Size(545, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // frmLabCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 693);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(980, 620);
            Name = "frmLabCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2 - Quản lý mượn trả thiết bị tại phòng thực hành (Lab Equipment Checkout)";
            Load += frmLabCheckout_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlLeft.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            pnlButtons.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSystem;
        private ToolStripMenuItem menuExportCsv;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sslTotal;
        private ToolStripStatusLabel sslOverdue;
        private ToolStripStatusLabel sslFiltered;
        private ToolStripStatusLabel sslClock;
        private Panel pnlLeft;
        private GroupBox grpInput;
        private Label lblReceiptId;
        private TextBox txtReceiptId;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblEquipment;
        private ComboBox cboEquipment;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblBorrowDate;
        private DateTimePicker dtpBorrowDate;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private CheckBox chkReturned;
        private DateTimePicker dtpReturnDate;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Panel pnlButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnMarkReturned;
        private Panel pnlRight;
        private GroupBox grpFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilterStatus;
        private ComboBox cboFilterStatus;
        private Button btnResetFilter;
        private GroupBox grpList;
        private DataGridView dgvReceipts;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerClock;
    }
}

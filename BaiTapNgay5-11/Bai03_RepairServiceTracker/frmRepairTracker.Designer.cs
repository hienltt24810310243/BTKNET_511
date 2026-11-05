namespace Bai03_RepairServiceTracker
{
    partial class frmRepairTracker
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
            sslFiltered = new ToolStripStatusLabel();
            sslPendingCost = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            pnlLeft = new Panel();
            grpInput = new GroupBox();
            btnRemoveImage = new Button();
            btnChooseImage = new Button();
            picDevice = new PictureBox();
            lblImage = new Label();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            txtEstimatedCost = new TextBox();
            lblCost = new Label();
            dtpReceivedDate = new DateTimePicker();
            lblDate = new Label();
            txtFaultDescription = new TextBox();
            lblFault = new Label();
            cboDeviceType = new ComboBox();
            lblDeviceType = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            txtOrderId = new TextBox();
            lblOrderId = new Label();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlRight = new Panel();
            grpList = new GroupBox();
            dgvOrders = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)picDevice).BeginInit();
            pnlButtons.SuspendLayout();
            pnlRight.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
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
            menuStrip1.Size = new Size(1140, 28);
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
            menuExportCsv.Size = new Size(270, 26);
            menuExportCsv.Text = "Xuất danh sách ra CSV...";
            menuExportCsv.Click += menuExportCsv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuExit.Size = new Size(270, 26);
            menuExit.Text = "Thoát ứng dụng";
            menuExit.Click += menuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslFiltered, sslPendingCost, sslClock });
            statusStrip1.Location = new Point(0, 695);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1140, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslFiltered
            // 
            sslFiltered.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslFiltered.Name = "sslFiltered";
            sslFiltered.Size = new Size(160, 20);
            sslFiltered.Text = "Số đơn theo bộ lọc: 0";
            // 
            // sslPendingCost
            // 
            sslPendingCost.Name = "sslPendingCost";
            sslPendingCost.Size = new Size(821, 20);
            sslPendingCost.Spring = true;
            sslPendingCost.Text = "Tổng chi phí dự kiến chưa hoàn tất: 0 VNĐ";
            sslPendingCost.TextAlign = ContentAlignment.MiddleLeft;
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
            pnlLeft.Size = new Size(410, 667);
            pnlLeft.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnRemoveImage);
            grpInput.Controls.Add(btnChooseImage);
            grpInput.Controls.Add(picDevice);
            grpInput.Controls.Add(lblImage);
            grpInput.Controls.Add(cboStatus);
            grpInput.Controls.Add(lblStatus);
            grpInput.Controls.Add(txtEstimatedCost);
            grpInput.Controls.Add(lblCost);
            grpInput.Controls.Add(dtpReceivedDate);
            grpInput.Controls.Add(lblDate);
            grpInput.Controls.Add(txtFaultDescription);
            grpInput.Controls.Add(lblFault);
            grpInput.Controls.Add(cboDeviceType);
            grpInput.Controls.Add(lblDeviceType);
            grpInput.Controls.Add(txtPhone);
            grpInput.Controls.Add(lblPhone);
            grpInput.Controls.Add(txtCustomerName);
            grpInput.Controls.Add(lblCustomerName);
            grpInput.Controls.Add(txtOrderId);
            grpInput.Controls.Add(lblOrderId);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(8, 8);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(394, 556);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin đơn sửa chữa thiết bị";
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveImage.Location = new Point(275, 510);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(80, 30);
            btnRemoveImage.TabIndex = 19;
            btnRemoveImage.Text = "Xóa ảnh";
            btnRemoveImage.UseVisualStyleBackColor = true;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChooseImage.Location = new Point(275, 470);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(80, 30);
            btnChooseImage.TabIndex = 18;
            btnChooseImage.Text = "Chọn ảnh...";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // picDevice
            // 
            picDevice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picDevice.BorderStyle = BorderStyle.FixedSingle;
            picDevice.Location = new Point(140, 460);
            picDevice.Name = "picDevice";
            picDevice.Size = new Size(120, 85);
            picDevice.SizeMode = PictureBoxSizeMode.Zoom;
            picDevice.TabIndex = 17;
            picDevice.TabStop = false;
            // 
            // lblImage
            // 
            lblImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImage.AutoSize = true;
            lblImage.Location = new Point(15, 470);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(92, 20);
            lblImage.TabIndex = 16;
            lblImage.Text = "Ảnh thiết bị:";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(140, 415);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(225, 28);
            cboStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 418);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 20);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Trạng thái:";
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEstimatedCost.Location = new Point(140, 370);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(225, 27);
            txtEstimatedCost.TabIndex = 13;
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCost.AutoSize = true;
            lblCost.Location = new Point(15, 373);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(116, 20);
            lblCost.TabIndex = 12;
            lblCost.Text = "Chi phí dự kiến:";
            // 
            // dtpReceivedDate
            // 
            dtpReceivedDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpReceivedDate.CustomFormat = "dd/MM/yyyy";
            dtpReceivedDate.Format = DateTimePickerFormat.Custom;
            dtpReceivedDate.Location = new Point(140, 325);
            dtpReceivedDate.Name = "dtpReceivedDate";
            dtpReceivedDate.Size = new Size(225, 27);
            dtpReceivedDate.TabIndex = 11;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(15, 328);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(113, 20);
            lblDate.TabIndex = 10;
            lblDate.Text = "Ngày tiếp nhận:";
            // 
            // txtFaultDescription
            // 
            txtFaultDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFaultDescription.Location = new Point(140, 195);
            txtFaultDescription.Multiline = true;
            txtFaultDescription.Name = "txtFaultDescription";
            txtFaultDescription.ScrollBars = ScrollBars.Vertical;
            txtFaultDescription.Size = new Size(225, 115);
            txtFaultDescription.TabIndex = 9;
            // 
            // lblFault
            // 
            lblFault.AutoSize = true;
            lblFault.Location = new Point(15, 198);
            lblFault.Name = "lblFault";
            lblFault.Size = new Size(80, 20);
            lblFault.TabIndex = 8;
            lblFault.Text = "Mô tả lỗi:";
            // 
            // cboDeviceType
            // 
            cboDeviceType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeviceType.FormattingEnabled = true;
            cboDeviceType.Location = new Point(140, 150);
            cboDeviceType.Name = "cboDeviceType";
            cboDeviceType.Size = new Size(225, 28);
            cboDeviceType.TabIndex = 7;
            // 
            // lblDeviceType
            // 
            lblDeviceType.AutoSize = true;
            lblDeviceType.Location = new Point(15, 153);
            lblDeviceType.Name = "lblDeviceType";
            lblDeviceType.Size = new Size(89, 20);
            lblDeviceType.TabIndex = 6;
            lblDeviceType.Text = "Loại thiết bị:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(140, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(225, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(15, 113);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.Location = new Point(140, 70);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(225, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(15, 73);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(114, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên khách hàng:";
            // 
            // txtOrderId
            // 
            txtOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderId.Location = new Point(140, 30);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(225, 27);
            txtOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(15, 33);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(64, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Mã đơn:";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(8, 564);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(394, 95);
            pnlButtons.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(205, 52);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa đơn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(205, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm đơn mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpList);
            pnlRight.Controls.Add(grpFilter);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(410, 28);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(8);
            pnlRight.Size = new Size(730, 667);
            pnlRight.TabIndex = 3;
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvOrders);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(8, 98);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(8);
            grpList.Size = new Size(714, 561);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách đơn đăng ký dịch vụ sửa chữa (DataGridView)";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(8, 28);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 35;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(698, 525);
            dgvOrders.TabIndex = 0;
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
            grpFilter.Size = new Size(714, 90);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm tức thời & Lọc theo trạng thái";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetFilter.Location = new Point(590, 48);
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
            cboFilterStatus.Location = new Point(145, 50);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(200, 28);
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
            lblFilterStatus.Text = "Lọc trạng thái:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(145, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã đơn, tên khách hàng hoặc số điện thoại để tìm kiếm tức thời...";
            txtSearch.Size = new Size(555, 27);
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
            // frmRepairTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 721);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1000, 650);
            Name = "frmRepairTracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 3 - Quản lý đơn đăng ký dịch vụ sửa chữa (Repair Service Tracker)";
            Load += frmRepairTracker_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlLeft.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDevice).EndInit();
            pnlButtons.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
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
        private ToolStripStatusLabel sslFiltered;
        private ToolStripStatusLabel sslPendingCost;
        private ToolStripStatusLabel sslClock;
        private Panel pnlLeft;
        private GroupBox grpInput;
        private Label lblOrderId;
        private TextBox txtOrderId;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblDeviceType;
        private ComboBox cboDeviceType;
        private Label lblFault;
        private TextBox txtFaultDescription;
        private Label lblDate;
        private DateTimePicker dtpReceivedDate;
        private Label lblCost;
        private TextBox txtEstimatedCost;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblImage;
        private PictureBox picDevice;
        private Button btnChooseImage;
        private Button btnRemoveImage;
        private Panel pnlButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Panel pnlRight;
        private GroupBox grpFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilterStatus;
        private ComboBox cboFilterStatus;
        private Button btnResetFilter;
        private GroupBox grpList;
        private DataGridView dgvOrders;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerClock;
    }
}

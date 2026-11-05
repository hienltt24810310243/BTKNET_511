namespace Bai01_ClinicAppointment
{
    partial class frmClinicAppointment
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
            sslFiltered = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            tblMainLayout = new TableLayoutPanel();
            pnlLeft = new Panel();
            grpInput = new GroupBox();
            txtReason = new TextBox();
            lblReason = new Label();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            cboDoctor = new ComboBox();
            lblDoctor = new Label();
            dtpAppointmentDate = new DateTimePicker();
            lblDate = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtPatientName = new TextBox();
            lblPatientName = new Label();
            txtAppointmentId = new TextBox();
            lblAppointmentId = new Label();
            pnlButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlRight = new Panel();
            grpList = new GroupBox();
            dgvAppointments = new DataGridView();
            grpFilter = new GroupBox();
            btnResetFilter = new Button();
            dtpFilterDate = new DateTimePicker();
            chkFilterDate = new CheckBox();
            cboFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            errorProvider1 = new ErrorProvider(components);
            timerClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tblMainLayout.SuspendLayout();
            pnlLeft.SuspendLayout();
            grpInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlRight.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
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
            menuStrip1.Size = new Size(1062, 28);
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
            menuExportCsv.Size = new Size(244, 26);
            menuExportCsv.Text = "Xuất file CSV...";
            menuExportCsv.Click += menuExportCsv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(241, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuExit.Size = new Size(244, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslTotal, sslFiltered, sslClock });
            statusStrip1.Location = new Point(0, 647);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1062, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslTotal
            // 
            sslTotal.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslTotal.Name = "sslTotal";
            sslTotal.Size = new Size(150, 20);
            sslTotal.Text = "Tổng số lịch hẹn: 0";
            // 
            // sslFiltered
            // 
            sslFiltered.Name = "sslFiltered";
            sslFiltered.Size = new Size(757, 20);
            sslFiltered.Spring = true;
            sslFiltered.Text = "Đang hiển thị: 0 lịch hẹn";
            sslFiltered.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sslClock
            // 
            sslClock.Name = "sslClock";
            sslClock.Size = new Size(140, 20);
            sslClock.Text = "Thời gian: 00:00:00";
            // 
            // tblMainLayout
            // 
            tblMainLayout.ColumnCount = 2;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 370F));
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMainLayout.Controls.Add(pnlLeft, 0, 0);
            tblMainLayout.Controls.Add(pnlRight, 1, 0);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 28);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.RowCount = 1;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMainLayout.Size = new Size(1062, 619);
            tblMainLayout.TabIndex = 2;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(grpInput);
            pnlLeft.Controls.Add(pnlButtons);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(3, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(5);
            pnlLeft.Size = new Size(364, 613);
            pnlLeft.TabIndex = 0;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(txtReason);
            grpInput.Controls.Add(lblReason);
            grpInput.Controls.Add(cboStatus);
            grpInput.Controls.Add(lblStatus);
            grpInput.Controls.Add(cboDoctor);
            grpInput.Controls.Add(lblDoctor);
            grpInput.Controls.Add(dtpAppointmentDate);
            grpInput.Controls.Add(lblDate);
            grpInput.Controls.Add(txtPhone);
            grpInput.Controls.Add(lblPhone);
            grpInput.Controls.Add(txtPatientName);
            grpInput.Controls.Add(lblPatientName);
            grpInput.Controls.Add(txtAppointmentId);
            grpInput.Controls.Add(lblAppointmentId);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(5, 5);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(354, 513);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin lịch hẹn khám bệnh";
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReason.Location = new Point(125, 275);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(205, 175);
            txtReason.TabIndex = 11;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new Point(15, 278);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(81, 20);
            lblReason.TabIndex = 10;
            lblReason.Text = "Lý do khám:";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(125, 465);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(205, 28);
            cboStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 468);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboDoctor
            // 
            cboDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(125, 230);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(205, 28);
            cboDoctor.TabIndex = 9;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(15, 233);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(82, 20);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Bác sĩ khám:";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpAppointmentDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new Point(125, 180);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(205, 27);
            dtpAppointmentDate.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(15, 183);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(95, 20);
            lblDate.TabIndex = 6;
            lblDate.Text = "Ngày giờ hẹn:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(125, 130);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(15, 133);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPatientName.Location = new Point(125, 80);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(205, 27);
            txtPatientName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(15, 83);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(76, 20);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "Bệnh nhân:";
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAppointmentId.Location = new Point(125, 35);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.Size = new Size(205, 27);
            txtAppointmentId.TabIndex = 1;
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.AutoSize = true;
            lblAppointmentId.Location = new Point(15, 38);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(84, 20);
            lblAppointmentId.TabIndex = 0;
            lblAppointmentId.Text = "Mã lịch hẹn:";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(5, 518);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(354, 90);
            pnlButtons.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 48);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(180, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpList);
            pnlRight.Controls.Add(grpFilter);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(373, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(5);
            pnlRight.Size = new Size(686, 613);
            pnlRight.TabIndex = 1;
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvAppointments);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(5, 115);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(8);
            grpList.Size = new Size(676, 493);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách lịch hẹn phòng khám (DataGridView)";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(8, 28);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 35;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(660, 457);
            dgvAppointments.TabIndex = 0;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnResetFilter);
            grpFilter.Controls.Add(dtpFilterDate);
            grpFilter.Controls.Add(chkFilterDate);
            grpFilter.Controls.Add(cboFilterStatus);
            grpFilter.Controls.Add(lblFilterStatus);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(lblSearch);
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Location = new Point(5, 5);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(676, 110);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Lọc dữ liệu tức thời";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetFilter.Location = new Point(545, 68);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(120, 30);
            btnResetFilter.TabIndex = 6;
            btnResetFilter.Text = "Đặt lại lọc";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.CustomFormat = "dd/MM/yyyy";
            dtpFilterDate.Enabled = false;
            dtpFilterDate.Format = DateTimePickerFormat.Custom;
            dtpFilterDate.Location = new Point(410, 70);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(125, 27);
            dtpFilterDate.TabIndex = 5;
            dtpFilterDate.ValueChanged += FilterCriteriaChanged;
            // 
            // chkFilterDate
            // 
            chkFilterDate.AutoSize = true;
            chkFilterDate.Location = new Point(290, 72);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(116, 24);
            chkFilterDate.TabIndex = 4;
            chkFilterDate.Text = "Lọc theo ngày:";
            chkFilterDate.UseVisualStyleBackColor = true;
            chkFilterDate.CheckedChanged += chkFilterDate_CheckedChanged;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(95, 70);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(170, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += FilterCriteriaChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(15, 73);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(78, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Trạng thái:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(95, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên bệnh nhân hoặc số điện thoại để tìm kiếm tức thời...";
            txtSearch.Size = new Size(570, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 33);
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
            // frmClinicAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tblMainLayout);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(950, 600);
            Name = "frmClinicAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1 - Quản lý lịch hẹn phòng khám (Clinic Appointment Manager)";
            Load += frmClinicAppointment_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tblMainLayout.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
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
        private ToolStripStatusLabel sslFiltered;
        private ToolStripStatusLabel sslClock;
        private TableLayoutPanel tblMainLayout;
        private Panel pnlLeft;
        private GroupBox grpInput;
        private TextBox txtReason;
        private Label lblReason;
        private ComboBox cboStatus;
        private Label lblStatus;
        private ComboBox cboDoctor;
        private Label lblDoctor;
        private DateTimePicker dtpAppointmentDate;
        private Label lblDate;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtPatientName;
        private Label lblPatientName;
        private TextBox txtAppointmentId;
        private Label lblAppointmentId;
        private Panel pnlButtons;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel pnlRight;
        private GroupBox grpFilter;
        private Button btnResetFilter;
        private DateTimePicker dtpFilterDate;
        private CheckBox chkFilterDate;
        private ComboBox cboFilterStatus;
        private Label lblFilterStatus;
        private TextBox txtSearch;
        private Label lblSearch;
        private GroupBox grpList;
        private DataGridView dgvAppointments;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerClock;
    }
}

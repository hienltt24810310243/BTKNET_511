using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai02_LabEquipmentCheckout
{
    public partial class frmLabCheckout : Form
    {
        private BindingList<CheckoutReceipt> listAllReceipts = new BindingList<CheckoutReceipt>();
        private BindingList<CheckoutReceipt> listDisplayedReceipts = new BindingList<CheckoutReceipt>();
        private BindingSource bindingSource = new BindingSource();
        private int autoReceiptIdCounter = 1;

        public frmLabCheckout()
        {
            InitializeComponent();
        }

        private void frmLabCheckout_Load(object? sender, EventArgs e)
        {
            // 1. Cấu hình ComboBox Thiết bị
            cboEquipment.Items.AddRange(new object[] {
                "Dao động ký điện tử (Oscilloscope 100MHz)",
                "Máy phát xung hàm (Function Generator)",
                "Bộ nguồn đa năng DC 0-30V 5A",
                "Đồng hồ vạn năng số (Digital Multimeter)",
                "Kính hiển vi quang học độ phóng đại 1000x",
                "Kit thực hành Vi điều khiển STM32/ARM",
                "Mỏ hàn xung nhiệt tử & Trạm hàn thiếc"
            });
            cboEquipment.SelectedIndex = 0;

            // 2. Cấu hình ComboBox Tình trạng phiếu
            cboStatus.Items.AddRange(new object[] { "Đang mượn", "Đã trả", "Quá hạn" });
            cboStatus.SelectedIndex = 0;

            // 3. Cấu hình ComboBox Lọc tình trạng
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả tình trạng", "Đang mượn", "Quá hạn", "Đã trả" });
            cboFilterStatus.SelectedIndex = 0;

            // 4. Cấu hình DataGridView bằng code
            CauHinhDataGridView();

            // 5. Ràng buộc dữ liệu qua BindingSource
            bindingSource.DataSource = listDisplayedReceipts;
            dgvReceipts.DataSource = bindingSource;

            // 6. Nạp dữ liệu mẫu ban đầu
            NapDuLieuMau();

            // 7. Bắt sự kiện chọn dòng đổ dữ liệu ngược
            dgvReceipts.SelectionChanged += dgvReceipts_SelectionChanged;

            // 8. Cập nhật đồng hồ và hiển thị
            CapNhatThoiGian();
            ApDungBoLoc();
            SinhMaTuDong();
        }

        private void CauHinhDataGridView()
        {
            dgvReceipts.AutoGenerateColumns = false;
            dgvReceipts.Columns.Clear();

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.ReceiptId),
                HeaderText = "Mã phiếu",
                Width = 90
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.StudentId),
                HeaderText = "Mã SV",
                Width = 100
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.StudentName),
                HeaderText = "Họ tên sinh viên",
                Width = 160
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.Equipment),
                HeaderText = "Tên thiết bị mượn",
                Width = 220
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.Quantity),
                HeaderText = "SL",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.BorrowDate),
                HeaderText = "Ngày mượn",
                Width = 105,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.DueDate),
                HeaderText = "Hạn trả",
                Width = 105,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.ReturnDateDisplay),
                HeaderText = "Ngày trả thực tế",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CheckoutReceipt.Status),
                HeaderText = "Tình trạng",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
        }

        private void NapDuLieuMau()
        {
            DateTime today = DateTime.Today;

            // Phiếu 1: Đang mượn, còn hạn
            listAllReceipts.Add(new CheckoutReceipt("PM001", "24810310001", "Nguyễn Văn Hùng", "Dao động ký điện tử (Oscilloscope 100MHz)", 1, today.AddDays(-2), today.AddDays(3), null, "Đang mượn"));

            // Phiếu 2: Quá hạn (hạn trả 2 ngày trước, chưa trả)
            listAllReceipts.Add(new CheckoutReceipt("PM002", "24810310002", "Trần Mai Anh", "Bộ nguồn đa năng DC 0-30V 5A", 2, today.AddDays(-7), today.AddDays(-2), null, "Quá hạn"));

            // Phiếu 3: Đã trả đúng hạn
            listAllReceipts.Add(new CheckoutReceipt("PM003", "24810310003", "Lê Thanh Sơn", "Đồng hồ vạn năng số (Digital Multimeter)", 1, today.AddDays(-5), today.AddDays(-1), today.AddDays(-1), "Đã trả"));

            // Phiếu 4: Đang mượn
            listAllReceipts.Add(new CheckoutReceipt("PM004", "24810310004", "Phạm Thị Thảo", "Kính hiển vi quang học độ phóng đại 1000x", 1, today.AddDays(-1), today.AddDays(4), null, "Đang mượn"));

            // Phiếu 5: Quá hạn (hạn trả 4 ngày trước)
            listAllReceipts.Add(new CheckoutReceipt("PM005", "24810310005", "Đỗ Minh Khang", "Kit thực hành Vi điều khiển STM32/ARM", 1, today.AddDays(-10), today.AddDays(-4), null, "Quá hạn"));

            autoReceiptIdCounter = 6;

            // Kiểm tra và tự động cập nhật quá hạn
            CapNhatQuaHanTatCaPhieu();
        }

        private void CapNhatQuaHanTatCaPhieu()
        {
            foreach (var r in listAllReceipts)
            {
                r.CapNhatQuaHanTuDong();
            }
        }

        private void SinhMaTuDong()
        {
            txtReceiptId.Text = $"PM{autoReceiptIdCounter:D3}";
        }

        private void timerClock_Tick(object? sender, EventArgs e)
        {
            CapNhatThoiGian();
        }

        private void CapNhatThoiGian()
        {
            sslClock.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        private void CapNhatThongKeStatusStrip()
        {
            int total = listAllReceipts.Count;
            int overdue = listAllReceipts.Count(r => r.Status == "Quá hạn");
            int displayed = listDisplayedReceipts.Count;

            sslTotal.Text = $"Tổng số phiếu: {total}";
            sslOverdue.Text = $"Số phiếu quá hạn: {overdue}";
            sslFiltered.Text = $"Đang hiển thị: {displayed} phiếu";
        }

        private void dgvReceipts_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvReceipts.CurrentRow?.DataBoundItem is CheckoutReceipt selected)
            {
                txtReceiptId.Text = selected.ReceiptId;
                txtStudentId.Text = selected.StudentId;
                txtStudentName.Text = selected.StudentName;
                cboEquipment.SelectedItem = selected.Equipment;
                numQuantity.Value = Math.Max(numQuantity.Minimum, Math.Min(numQuantity.Maximum, selected.Quantity));
                dtpBorrowDate.Value = selected.BorrowDate;
                dtpDueDate.Value = selected.DueDate;

                if (selected.ReturnDate.HasValue)
                {
                    chkReturned.Checked = true;
                    dtpReturnDate.Value = selected.ReturnDate.Value;
                }
                else
                {
                    chkReturned.Checked = false;
                    dtpReturnDate.Value = DateTime.Today;
                }

                cboStatus.SelectedItem = selected.Status;
                errorProvider1.Clear();
            }
        }

        private void chkReturned_CheckedChanged(object? sender, EventArgs e)
        {
            dtpReturnDate.Enabled = chkReturned.Checked;
            if (chkReturned.Checked)
            {
                cboStatus.SelectedItem = "Đã trả";
            }
            else
            {
                if (dtpDueDate.Value.Date < DateTime.Today)
                {
                    cboStatus.SelectedItem = "Quá hạn";
                }
                else
                {
                    cboStatus.SelectedItem = "Đang mượn";
                }
            }
        }

        private void cboStatus_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string selected = cboStatus.SelectedItem?.ToString() ?? "";
            if (selected == "Đã trả")
            {
                if (!chkReturned.Checked)
                {
                    chkReturned.Checked = true;
                }
            }
            else
            {
                if (chkReturned.Checked)
                {
                    chkReturned.Checked = false;
                }
            }
        }

        private bool ValidateDuLieu(bool isEditing, out string receiptId, out string studentId, out string studentName, out string equipment, out int quantity, out DateTime borrowDate, out DateTime dueDate, out DateTime? returnDate, out string status)
        {
            bool hopLe = true;
            errorProvider1.Clear();

            receiptId = txtReceiptId.Text.Trim();
            studentId = txtStudentId.Text.Trim();
            studentName = txtStudentName.Text.Trim();
            equipment = cboEquipment.SelectedItem?.ToString() ?? string.Empty;
            quantity = (int)numQuantity.Value;
            borrowDate = dtpBorrowDate.Value.Date;
            dueDate = dtpDueDate.Value.Date;
            returnDate = chkReturned.Checked ? dtpReturnDate.Value.Date : null;
            status = cboStatus.SelectedItem?.ToString() ?? "Đang mượn";

            // 1. Kiểm tra Mã phiếu
            string curId = receiptId;
            if (string.IsNullOrWhiteSpace(curId))
            {
                errorProvider1.SetError(txtReceiptId, "Mã phiếu mượn không được để trống!");
                hopLe = false;
            }
            else if (!isEditing)
            {
                if (listAllReceipts.Any(r => r.ReceiptId.Equals(curId, StringComparison.OrdinalIgnoreCase)))
                {
                    errorProvider1.SetError(txtReceiptId, "Mã phiếu này đã tồn tại trong danh sách!");
                    hopLe = false;
                }
            }

            // 2. Kiểm tra Mã sinh viên
            if (string.IsNullOrWhiteSpace(studentId))
            {
                errorProvider1.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                hopLe = false;
            }

            // 3. Kiểm tra Tên sinh viên
            if (string.IsNullOrWhiteSpace(studentName))
            {
                errorProvider1.SetError(txtStudentName, "Tên sinh viên không được để trống!");
                hopLe = false;
            }

            // 4. Kiểm tra Thiết bị
            if (string.IsNullOrWhiteSpace(equipment))
            {
                errorProvider1.SetError(cboEquipment, "Vui lòng chọn thiết bị thực hành!");
                hopLe = false;
            }

            // 5. Kiểm tra Số lượng
            if (quantity <= 0)
            {
                errorProvider1.SetError(numQuantity, "Số lượng mượn phải lớn hơn 0!");
                hopLe = false;
            }

            // 6. Kiểm tra Hạn trả không trước ngày mượn
            if (dueDate < borrowDate)
            {
                errorProvider1.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn thiết bị!");
                hopLe = false;
            }

            // 7. Kiểm tra Ngày trả thực tế không trước ngày mượn
            if (returnDate.HasValue && returnDate.Value < borrowDate)
            {
                errorProvider1.SetError(dtpReturnDate, "Ngày trả thực tế không được trước ngày mượn!");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateDuLieu(false, out string receiptId, out string studentId, out string studentName, out string equipment, out int quantity, out DateTime borrowDate, out DateTime dueDate, out DateTime? returnDate, out string status))
            {
                MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ, vui lòng kiểm tra các biểu tượng cảnh báo lỗi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CheckoutReceipt newReceipt = new CheckoutReceipt(receiptId, studentId, studentName, equipment, quantity, borrowDate, dueDate, returnDate, status);
            newReceipt.CapNhatQuaHanTuDong();

            listAllReceipts.Add(newReceipt);
            autoReceiptIdCounter++;

            ApDungBoLoc();

            int idx = listDisplayedReceipts.IndexOf(newReceipt);
            if (idx >= 0)
            {
                bindingSource.Position = idx;
            }

            MessageBox.Show($"Thêm thành công phiếu mượn [{newReceipt.ReceiptId}] cho sinh viên '{newReceipt.StudentName}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvReceipts.CurrentRow?.DataBoundItem is CheckoutReceipt current)
            {
                if (!ValidateDuLieu(true, out _, out string studentId, out string studentName, out string equipment, out int quantity, out DateTime borrowDate, out DateTime dueDate, out DateTime? returnDate, out string status))
                {
                    MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ, vui lòng kiểm tra các biểu tượng cảnh báo lỗi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                current.StudentId = studentId;
                current.StudentName = studentName;
                current.Equipment = equipment;
                current.Quantity = quantity;
                current.BorrowDate = borrowDate;
                current.DueDate = dueDate;
                current.ReturnDate = returnDate;
                current.Status = status;

                current.CapNhatQuaHanTuDong();

                ApDungBoLoc();
                MessageBox.Show($"Cập nhật thành công phiếu mượn [{current.ReceiptId}]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvReceipts.CurrentRow?.DataBoundItem is CheckoutReceipt current)
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa phiếu mượn [{current.ReceiptId}] của sinh viên '{current.StudentName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    listAllReceipts.Remove(current);
                    ApDungBoLoc();
                    LamMoiForm();
                    MessageBox.Show("Đã xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Chức năng: Đánh dấu đã trả -> Cập nhật tình trạng sang "Đã trả" và ngày trả thực tế là hôm nay
        /// </summary>
        private void btnMarkReturned_Click(object? sender, EventArgs e)
        {
            if (dgvReceipts.CurrentRow?.DataBoundItem is CheckoutReceipt current)
            {
                if (current.Status == "Đã trả")
                {
                    MessageBox.Show($"Phiếu [{current.ReceiptId}] đã được đánh dấu trả trước đó vào ngày {current.ReturnDate:dd/MM/yyyy}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                current.Status = "Đã trả";
                current.ReturnDate = DateTime.Today;

                chkReturned.Checked = true;
                dtpReturnDate.Value = DateTime.Today;
                cboStatus.SelectedItem = "Đã trả";

                ApDungBoLoc();
                MessageBox.Show($"Đã xác nhận trả thiết bị cho phiếu [{current.ReceiptId}] vào ngày {DateTime.Today:dd/MM/yyyy} thành công!", "Đánh dấu đã trả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để đánh dấu đã trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            dgvReceipts.ClearSelection();
            SinhMaTuDong();
            txtStudentId.Clear();
            txtStudentName.Clear();
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;
            numQuantity.Value = 1;
            dtpBorrowDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(3);
            chkReturned.Checked = false;
            dtpReturnDate.Value = DateTime.Today;
            cboStatus.SelectedItem = "Đang mượn";
            errorProvider1.Clear();
            txtStudentId.Focus();
        }

        #region Tìm kiếm tức thời & Lọc dữ liệu

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void cboFilterStatus_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void btnResetFilter_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            ApDungBoLoc();
        }

        private void ApDungBoLoc()
        {
            CapNhatQuaHanTatCaPhieu();

            string keyword = txtSearch.Text.Trim().ToLowerInvariant();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả tình trạng";

            var filtered = listAllReceipts.Where(item =>
            {
                // 1. Tìm kiếm theo mã sinh viên hoặc tên thiết bị
                bool matchKeyword = string.IsNullOrEmpty(keyword)
                    || item.StudentId.ToLowerInvariant().Contains(keyword)
                    || item.Equipment.ToLowerInvariant().Contains(keyword);

                // 2. Lọc theo tình trạng
                bool matchStatus = (selectedStatus == "Tất cả tình trạng")
                    || item.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase);

                return matchKeyword && matchStatus;
            }).ToList();

            listDisplayedReceipts.Clear();
            foreach (var r in filtered)
            {
                listDisplayedReceipts.Add(r);
            }

            CapNhatThongKeStatusStrip();
        }

        #endregion

        #region Xuất file CSV (SaveFileDialog)

        private void menuExportCsv_Click(object? sender, EventArgs e)
        {
            if (listDisplayedReceipts.Count == 0)
            {
                MessageBox.Show("Hiện không có phiếu mượn nào đang hiển thị để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách phiếu mượn thiết bị ra tệp CSV";
                sfd.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.FileName = $"PhieuMuonThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                sfd.DefaultExt = "csv";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã phiếu,Mã sinh viên,Họ tên sinh viên,Tên thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Tình trạng");

                        foreach (var item in listDisplayedReceipts)
                        {
                            string student = item.StudentName.Contains(",") ? $"\"{item.StudentName}\"" : item.StudentName;
                            string equip = item.Equipment.Contains(",") ? $"\"{item.Equipment}\"" : item.Equipment;
                            string returnStr = item.ReturnDate.HasValue ? item.ReturnDate.Value.ToString("dd/MM/yyyy") : "";

                            sb.AppendLine($"{item.ReceiptId},{item.StudentId},{student},{equip},{item.Quantity},{item.BorrowDate:dd/MM/yyyy},{item.DueDate:dd/MM/yyyy},{returnStr},{item.Status}");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show(
                            $"Xuất dữ liệu thành công ra tệp:\n{sfd.FileName}\n\nTổng số phiếu đã xuất: {listDisplayedReceipts.Count}",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi ghi tệp CSV:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuExit_Click(object? sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát ứng dụng Quản lý mượn trả thiết bị?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion
    }
}

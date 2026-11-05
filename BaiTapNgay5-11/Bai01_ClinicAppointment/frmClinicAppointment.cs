using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai01_ClinicAppointment
{
    public partial class frmClinicAppointment : Form
    {
        private BindingList<Appointment> listAllAppointments = new BindingList<Appointment>();
        private BindingList<Appointment> listDisplayedAppointments = new BindingList<Appointment>();
        private BindingSource bindingSource = new BindingSource();
        private int autoIdCounter = 1;

        public frmClinicAppointment()
        {
            InitializeComponent();
        }

        private void frmClinicAppointment_Load(object? sender, EventArgs e)
        {
            // 1. Cấu hình ComboBox Bác sĩ
            cboDoctor.Items.AddRange(new object[] {
                "BS. Nguyễn Văn An (Nội tổng quát)",
                "BS. Trần Thị Bình (Tim mạch)",
                "BS. Lê Hoàng Cường (Tai Mũi Họng)",
                "BS. Phạm Minh Đức (Răng Hàm Mặt)",
                "BS. Vũ Thị Hồng (Nhi khoa)"
            });
            cboDoctor.SelectedIndex = 0;

            // 2. Cấu hình ComboBox Trạng thái
            cboStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboStatus.SelectedIndex = 0;

            // 3. Cấu hình ComboBox Lọc trạng thái
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả trạng thái", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            // 4. Cấu hình DataGridView bằng Code
            CauHinhDataGridView();

            // 5. Ràng buộc dữ liệu với BindingSource
            bindingSource.DataSource = listDisplayedAppointments;
            dgvAppointments.DataSource = bindingSource;

            // 6. Nạp dữ liệu mẫu ban đầu
            NapDuLieuMau();

            // 7. Bắt sự kiện chọn dòng đổ ngược dữ liệu
            dgvAppointments.SelectionChanged += dgvAppointments_SelectionChanged;

            // 8. Đồng hồ thời gian thực và cập nhật hiển thị
            CapNhatThoiGian();
            ApDungBoLoc();
            SinhMaTuDong();
        }

        private void CauHinhDataGridView()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.Columns.Clear();

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.AppointmentId),
                HeaderText = "Mã hẹn",
                Width = 90
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.PatientName),
                HeaderText = "Họ tên bệnh nhân",
                Width = 170
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.Phone),
                HeaderText = "Số điện thoại",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.AppointmentDate),
                HeaderText = "Ngày giờ hẹn",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.Doctor),
                HeaderText = "Bác sĩ khám",
                Width = 170
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.Reason),
                HeaderText = "Lý do khám",
                Width = 160
            });

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Appointment.Status),
                HeaderText = "Trạng thái",
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

            listAllAppointments.Add(new Appointment("LH001", "Nguyễn Văn Hùng", "0912345678", today.AddDays(1).AddHours(8).AddMinutes(30), "BS. Nguyễn Văn An (Nội tổng quát)", "Khám sức khỏe định kỳ", "Chờ khám"));
            listAllAppointments.Add(new Appointment("LH002", "Trần Mai Anh", "0987654321", today.AddDays(1).AddHours(9).AddMinutes(15), "BS. Trần Thị Bình (Tim mạch)", "Đau tức ngực trái khó thở", "Chờ khám"));
            listAllAppointments.Add(new Appointment("LH003", "Lê Thanh Sơn", "0905112233", today.AddDays(2).AddHours(14).AddMinutes(0), "BS. Lê Hoàng Cường (Tai Mũi Họng)", "Viêm xoang cấp, đau rát họng", "Chờ khám"));
            listAllAppointments.Add(new Appointment("LH004", "Phạm Thị Thảo", "0978998877", today.AddDays(2).AddHours(15).AddMinutes(30), "BS. Phạm Minh Đức (Răng Hàm Mặt)", "Nhổ răng khôn mọc lệch", "Đang khám"));
            listAllAppointments.Add(new Appointment("LH005", "Đỗ Minh Khang", "0934567890", today.AddDays(3).AddHours(10).AddMinutes(0), "BS. Vũ Thị Hồng (Nhi khoa)", "Sốt xuất huyết, nổi ban", "Hoàn tất"));

            autoIdCounter = 6;
        }

        private void SinhMaTuDong()
        {
            txtAppointmentId.Text = $"LH{autoIdCounter:D3}";
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
            sslTotal.Text = $"Tổng số lịch hẹn: {listAllAppointments.Count}";
            sslFiltered.Text = $"Đang hiển thị: {listDisplayedAppointments.Count} lịch hẹn";
        }

        private void dgvAppointments_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment selected)
            {
                txtAppointmentId.Text = selected.AppointmentId;
                txtPatientName.Text = selected.PatientName;
                txtPhone.Text = selected.Phone;
                dtpAppointmentDate.Value = selected.AppointmentDate;
                cboDoctor.SelectedItem = selected.Doctor;
                txtReason.Text = selected.Reason;
                cboStatus.SelectedItem = selected.Status;

                errorProvider1.Clear();
            }
        }

        private bool ValidateDuLieu(bool isEditing, out string id, out string name, out string phone, out DateTime date, out string doctor, out string reason, out string status)
        {
            bool hopLe = true;
            errorProvider1.Clear();

            id = txtAppointmentId.Text.Trim();
            name = txtPatientName.Text.Trim();
            phone = txtPhone.Text.Trim();
            date = dtpAppointmentDate.Value;
            doctor = cboDoctor.SelectedItem?.ToString() ?? string.Empty;
            reason = txtReason.Text.Trim();
            status = cboStatus.SelectedItem?.ToString() ?? "Chờ khám";

            string currentId = id;
            if (string.IsNullOrWhiteSpace(currentId))
            {
                errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn không được để trống!");
                hopLe = false;
            }
            else if (!isEditing)
            {
                // Thêm mới: mã phải là duy nhất
                if (listAllAppointments.Any(a => a.AppointmentId.Equals(currentId, StringComparison.OrdinalIgnoreCase)))
                {
                    errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn này đã tồn tại trong hệ thống!");
                    hopLe = false;
                }
            }

            // 2. Kiểm tra Họ tên bệnh nhân
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtPatientName, "Họ tên bệnh nhân không được để trống!");
                hopLe = false;
            }

            // 3. Kiểm tra Số điện thoại hợp lệ (10-11 chữ số, bắt đầu bằng 0)
            if (string.IsNullOrWhiteSpace(phone))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống!");
                hopLe = false;
            }
            else if (!Regex.IsMatch(phone, @"^(0[3|5|7|8|9])[0-9]{8}$") && !Regex.IsMatch(phone, @"^[0-9]{10,11}$"))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không hợp lệ (gồm 10-11 chữ số, ví dụ: 0912345678)!");
                hopLe = false;
            }

            // 4. Kiểm tra Ngày giờ hẹn không được nằm trong quá khứ
            if (date < DateTime.Now.AddMinutes(-5))
            {
                errorProvider1.SetError(dtpAppointmentDate, "Ngày giờ hẹn không được nằm trong quá khứ!");
                hopLe = false;
            }

            // 5. Kiểm tra Bác sĩ
            if (string.IsNullOrWhiteSpace(doctor))
            {
                errorProvider1.SetError(cboDoctor, "Vui lòng chọn bác sĩ phụ trách khám!");
                hopLe = false;
            }

            // 6. Kiểm tra Lý do khám bắt buộc
            if (string.IsNullOrWhiteSpace(reason))
            {
                errorProvider1.SetError(txtReason, "Lý do khám không được để trống!");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateDuLieu(false, out string id, out string name, out string phone, out DateTime date, out string doctor, out string reason, out string status))
            {
                MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ, vui lòng kiểm tra các biểu tượng cảnh báo lỗi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Appointment newAppointment = new Appointment(id, name, phone, date, doctor, reason, status);
            listAllAppointments.Add(newAppointment);
            autoIdCounter++;

            ApDungBoLoc();

            // Đặt con trỏ tới lịch hẹn mới
            int index = listDisplayedAppointments.IndexOf(newAppointment);
            if (index >= 0)
            {
                bindingSource.Position = index;
            }

            MessageBox.Show($"Thêm thành công lịch hẹn [{newAppointment.AppointmentId}] cho bệnh nhân '{newAppointment.PatientName}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment current)
            {
                if (!ValidateDuLieu(true, out _, out string name, out string phone, out DateTime date, out string doctor, out string reason, out string status))
                {
                    MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ, vui lòng kiểm tra các biểu tượng cảnh báo lỗi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                current.PatientName = name;
                current.Phone = phone;
                current.AppointmentDate = date;
                current.Doctor = doctor;
                current.Reason = reason;
                current.Status = status;

                ApDungBoLoc();
                MessageBox.Show($"Cập nhật thành công thông tin lịch hẹn [{current.AppointmentId}]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn từ bảng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment current)
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa lịch hẹn [{current.AppointmentId}] của bệnh nhân '{current.PatientName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    listAllAppointments.Remove(current);
                    ApDungBoLoc();
                    LamMoiForm();
                    MessageBox.Show("Đã xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            dgvAppointments.ClearSelection();
            SinhMaTuDong();
            txtPatientName.Clear();
            txtPhone.Clear();
            dtpAppointmentDate.Value = DateTime.Now.AddDays(1).Date.AddHours(8);
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            txtReason.Clear();
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            errorProvider1.Clear();
            txtPatientName.Focus();
        }

        #region Tìm kiếm tức thời & Lọc dữ liệu

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void FilterCriteriaChanged(object? sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void chkFilterDate_CheckedChanged(object? sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkFilterDate.Checked;
            ApDungBoLoc();
        }

        private void btnResetFilter_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            chkFilterDate.Checked = false;
            dtpFilterDate.Value = DateTime.Today;
            ApDungBoLoc();
        }

        private void ApDungBoLoc()
        {
            string keyword = txtSearch.Text.Trim().ToLowerInvariant();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả trạng thái";
            bool filterByDate = chkFilterDate.Checked;
            DateTime targetDate = dtpFilterDate.Value.Date;

            var filtered = listAllAppointments.Where(item =>
            {
                // 1. Tìm kiếm theo tên hoặc số điện thoại
                bool matchKeyword = string.IsNullOrEmpty(keyword)
                    || item.PatientName.ToLowerInvariant().Contains(keyword)
                    || item.Phone.Contains(keyword);

                // 2. Lọc theo trạng thái
                bool matchStatus = (selectedStatus == "Tất cả trạng thái")
                    || item.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase);

                // 3. Lọc theo ngày hẹn
                bool matchDate = !filterByDate || (item.AppointmentDate.Date == targetDate);

                return matchKeyword && matchStatus && matchDate;
            }).ToList();

            listDisplayedAppointments.Clear();
            foreach (var item in filtered)
            {
                listDisplayedAppointments.Add(item);
            }

            CapNhatThongKeStatusStrip();
        }

        #endregion

        #region Xuất file CSV (SaveFileDialog)

        private void menuExportCsv_Click(object? sender, EventArgs e)
        {
            if (listDisplayedAppointments.Count == 0)
            {
                MessageBox.Show("Hiện không có lịch hẹn nào trong danh sách để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách lịch hẹn ra tệp CSV";
                sfd.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.FileName = $"LichHenKham_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                sfd.DefaultExt = "csv";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        // Dòng tiêu đề cột
                        sb.AppendLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ khám,Lý do khám,Trạng thái");

                        foreach (var item in listDisplayedAppointments)
                        {
                            string name = item.PatientName.Contains(",") ? $"\"{item.PatientName}\"" : item.PatientName;
                            string doctor = item.Doctor.Contains(",") ? $"\"{item.Doctor}\"" : item.Doctor;
                            string reason = item.Reason.Contains(",") ? $"\"{item.Reason.Replace("\r\n", " ")}\"" : item.Reason.Replace("\r\n", " ");

                            sb.AppendLine($"{item.AppointmentId},{name},{item.Phone},{item.AppointmentDate:dd/MM/yyyy HH:mm},{doctor},{reason},{item.Status}");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show(
                            $"Xuất dữ liệu thành công ra tệp:\n{sfd.FileName}\n\nTổng số lịch hẹn đã xuất: {listDisplayedAppointments.Count}",
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
                "Bạn có chắc chắn muốn thoát ứng dụng Quản lý lịch hẹn?",
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

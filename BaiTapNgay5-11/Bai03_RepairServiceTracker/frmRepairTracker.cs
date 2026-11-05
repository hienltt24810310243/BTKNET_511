using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai03_RepairServiceTracker
{
    public partial class frmRepairTracker : Form
    {
        private List<RepairOrder> listAllOrders = new List<RepairOrder>();
        private string currentLoadedImagePath = string.Empty;

        public frmRepairTracker()
        {
            InitializeComponent();
        }

        private void frmRepairTracker_Load(object? sender, EventArgs e)
        {
            SetupComboboxes();
            SetupDataGridView();
            LoadSampleData();
            BindGrid();
            UpdateClock();
        }

        private void SetupComboboxes()
        {
            cboDeviceType.Items.Clear();
            cboDeviceType.Items.AddRange(new object[]
            {
                "Điện thoại",
                "Laptop",
                "Máy tính bảng",
                "PC / Máy bàn",
                "Màn hình",
                "Thiết bị khác"
            });
            cboDeviceType.SelectedIndex = 0;

            string[] statuses = new string[]
            {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            };

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(statuses);
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                HeaderText = "Mã đơn",
                Width = 90
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Tên khách hàng",
                Width = 140
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Số điện thoại",
                Width = 110
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeviceType",
                HeaderText = "Loại thiết bị",
                Width = 110
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FaultDescription",
                HeaderText = "Mô tả lỗi",
                Width = 160
            });

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReceivedDate",
                HeaderText = "Ngày nhận",
                Width = 100
            };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            colDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.Columns.Add(colDate);

            DataGridViewTextBoxColumn colCost = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstimatedCost",
                HeaderText = "Chi phí dự kiến (VNĐ)",
                Width = 130
            };
            colCost.DefaultCellStyle.Format = "N0";
            colCost.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrders.Columns.Add(colCost);

            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Trạng thái",
                Width = 120
            };
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.Columns.Add(colStatus);

            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
        }

        private void LoadSampleData()
        {
            listAllOrders = new List<RepairOrder>
            {
                new RepairOrder("SC001", "Trần Văn An", "0901234567", "Điện thoại", "Hỏng màn hình cảm ứng, sọc sáng", DateTime.Today.AddDays(-3), 1200000m, "Đang sửa"),
                new RepairOrder("SC002", "Lê Thị Bích", "0912345678", "Laptop", "Không lên nguồn, quạt kêu to", DateTime.Today.AddDays(-2), 850000m, "Chờ linh kiện"),
                new RepairOrder("SC003", "Phạm Quốc Cường", "0987654321", "PC / Máy bàn", "Cài lại Windows và vệ sinh tra keo tản nhiệt", DateTime.Today.AddDays(-1), 250000m, "Mới tiếp nhận"),
                new RepairOrder("SC004", "Hoàng Thu Dung", "0934567890", "Máy tính bảng", "Thay pin chai, loa ngoài rè", DateTime.Today.AddDays(-5), 650000m, "Hoàn tất"),
                new RepairOrder("SC005", "Đỗ Văn Em", "0978123456", "Màn hình", "Vỡ panel kính, không sửa được", DateTime.Today.AddDays(-4), 0m, "Đã hủy"),
                new RepairOrder("SC006", "Vũ Hoàng Giang", "0945678123", "Laptop", "Bàn phím bị liệt phím cách và Enter", DateTime.Today, 450000m, "Mới tiếp nhận")
            };
        }

        private void BindGrid()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string filterStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString()! : "Tất cả";

            var filtered = listAllOrders.Where(o =>
            {
                bool matchKeyword = string.IsNullOrEmpty(keyword)
                    || o.OrderId.ToLower().Contains(keyword)
                    || o.CustomerName.ToLower().Contains(keyword)
                    || o.Phone.ToLower().Contains(keyword);

                bool matchStatus = (filterStatus == "Tất cả" || o.Status == filterStatus);

                return matchKeyword && matchStatus;
            }).ToList();

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = filtered;

            UpdateStatusStrip(filtered);
        }

        private void UpdateStatusStrip(List<RepairOrder> filteredList)
        {
            sslFiltered.Text = $"Số đơn theo bộ lọc: {filteredList.Count}";

            decimal pendingCost = listAllOrders
                .Where(o => o.Status != "Hoàn tất" && o.Status != "Đã hủy")
                .Sum(o => o.EstimatedCost);

            sslPendingCost.Text = $"Tổng chi phí dự kiến chưa hoàn tất: {pendingCost:N0} VNĐ";
        }

        private void UpdateClock()
        {
            sslClock.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerClock_Tick(object? sender, EventArgs e)
        {
            UpdateClock();
        }

        private void dgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                RepairOrder? selected = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
                if (selected != null)
                {
                    txtOrderId.Text = selected.OrderId;
                    txtCustomerName.Text = selected.CustomerName;
                    txtPhone.Text = selected.Phone;
                    cboDeviceType.SelectedItem = selected.DeviceType;
                    txtFaultDescription.Text = selected.FaultDescription;
                    dtpReceivedDate.Value = selected.ReceivedDate;
                    txtEstimatedCost.Text = selected.EstimatedCost.ToString("G0");
                    cboStatus.SelectedItem = selected.Status;

                    currentLoadedImagePath = selected.ImagePath;
                    DisplayImageSafely(selected.ImagePath);
                }
            }
        }

        private void DisplayImageSafely(string path)
        {
            if (picDevice.Image != null)
            {
                Image oldImg = picDevice.Image;
                picDevice.Image = null;
                oldImg.Dispose();
            }

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picDevice.Image = Image.FromStream(fs);
                    }
                }
                catch
                {
                    picDevice.Image = null;
                }
            }
            else
            {
                picDevice.Image = null;
            }
        }

        private bool ValidateInput(bool isAdding, out string orderId, out string customerName, out string phone, out string deviceType, out string fault, out DateTime receivedDate, out decimal cost, out string status)
        {
            errorProvider1.Clear();
            bool isValid = true;

            orderId = txtOrderId.Text.Trim();
            customerName = txtCustomerName.Text.Trim();
            phone = txtPhone.Text.Trim();
            deviceType = cboDeviceType.SelectedItem != null ? cboDeviceType.SelectedItem.ToString()! : string.Empty;
            fault = txtFaultDescription.Text.Trim();
            receivedDate = dtpReceivedDate.Value.Date;
            cost = 0m;
            status = cboStatus.SelectedItem != null ? cboStatus.SelectedItem.ToString()! : "Mới tiếp nhận";

            if (string.IsNullOrWhiteSpace(orderId))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn không được để trống!");
                isValid = false;
            }
            else
            {
                string checkId = orderId;
                if (isAdding)
                {
                    if (listAllOrders.Any(o => o.OrderId.Equals(checkId, StringComparison.OrdinalIgnoreCase)))
                    {
                        errorProvider1.SetError(txtOrderId, "Mã đơn đã tồn tại trong hệ thống!");
                        isValid = false;
                    }
                }
                else
                {
                    if (dgvOrders.SelectedRows.Count > 0)
                    {
                        RepairOrder? current = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
                        if (current != null && !current.OrderId.Equals(checkId, StringComparison.OrdinalIgnoreCase))
                        {
                            if (listAllOrders.Any(o => o.OrderId.Equals(checkId, StringComparison.OrdinalIgnoreCase)))
                            {
                                errorProvider1.SetError(txtOrderId, "Mã đơn mới đã trùng với đơn khác!");
                                isValid = false;
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(customerName))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống!");
                isValid = false;
            }
            else if (phone.Length < 9 || !phone.All(char.IsDigit))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải từ 9 đến 11 chữ số!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(deviceType))
            {
                errorProvider1.SetError(cboDeviceType, "Vui lòng chọn loại thiết bị!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(fault))
            {
                errorProvider1.SetError(txtFaultDescription, "Vui lòng nhập mô tả lỗi thiết bị!");
                isValid = false;
            }

            string rawCost = txtEstimatedCost.Text.Trim().Replace(",", "").Replace(".", "");
            if (string.IsNullOrWhiteSpace(rawCost))
            {
                cost = 0m;
            }
            else if (!decimal.TryParse(rawCost, out cost) || cost < 0)
            {
                errorProvider1.SetError(txtEstimatedCost, "Chi phí dự kiến phải là số không âm!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(true, out string orderId, out string customerName, out string phone, out string deviceType, out string fault, out DateTime receivedDate, out decimal cost, out string status))
            {
                return;
            }

            RepairOrder newOrder = new RepairOrder(orderId, customerName, phone, deviceType, fault, receivedDate, cost, status, currentLoadedImagePath);
            listAllOrders.Add(newOrder);

            BindGrid();
            SelectRowById(orderId);
            MessageBox.Show("Thêm đơn sửa chữa mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn sửa chữa cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(false, out string orderId, out string customerName, out string phone, out string deviceType, out string fault, out DateTime receivedDate, out decimal cost, out string status))
            {
                return;
            }

            RepairOrder? selected = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
            if (selected != null)
            {
                selected.OrderId = orderId;
                selected.CustomerName = customerName;
                selected.Phone = phone;
                selected.DeviceType = deviceType;
                selected.FaultDescription = fault;
                selected.ReceivedDate = receivedDate;
                selected.EstimatedCost = cost;
                selected.Status = status;
                selected.ImagePath = currentLoadedImagePath;

                BindGrid();
                SelectRowById(orderId);
                MessageBox.Show("Cập nhật đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn sửa chữa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RepairOrder? selected = dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
            if (selected == null) return;

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa đơn sửa chữa [{selected.OrderId}] của khách hàng '{selected.CustomerName}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                listAllOrders.Remove(selected);
                BindGrid();
                ClearForm();
                MessageBox.Show("Đã xóa đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            errorProvider1.Clear();
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            cboDeviceType.SelectedIndex = 0;
            txtFaultDescription.Clear();
            dtpReceivedDate.Value = DateTime.Today;
            txtEstimatedCost.Clear();
            cboStatus.SelectedIndex = 0;
            currentLoadedImagePath = string.Empty;
            DisplayImageSafely(string.Empty);
            txtOrderId.Focus();
        }

        private void SelectRowById(string orderId)
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                RepairOrder? item = row.DataBoundItem as RepairOrder;
                if (item != null && item.OrderId == orderId)
                {
                    row.Selected = true;
                    dgvOrders.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void btnChooseImage_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh thiết bị sửa chữa";
                ofd.Filter = "Ảnh thiết bị (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentLoadedImagePath = ofd.FileName;
                    DisplayImageSafely(currentLoadedImagePath);
                }
            }
        }

        private void btnRemoveImage_Click(object? sender, EventArgs e)
        {
            currentLoadedImagePath = string.Empty;
            DisplayImageSafely(string.Empty);
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            BindGrid();
        }

        private void cboFilterStatus_SelectedIndexChanged(object? sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnResetFilter_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            BindGrid();
        }

        private void menuExportCsv_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách đơn sửa chữa ra tệp CSV";
                sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                sfd.FileName = $"DanhSachSuaChua_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var filteredList = dgvOrders.DataSource as List<RepairOrder> ?? listAllOrders;
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày nhận,Chi phí dự kiến (VNĐ),Trạng thái,Đường dẫn ảnh");

                        foreach (var order in filteredList)
                        {
                            string escapedFault = $"\"{order.FaultDescription.Replace("\"", "\"\"")}\"";
                            string escapedCustomer = $"\"{order.CustomerName.Replace("\"", "\"\"")}\"";
                            string line = $"{order.OrderId},{escapedCustomer},{order.Phone},{order.DeviceType},{escapedFault},{order.ReceivedDate:dd/MM/yyyy},{order.EstimatedCost},{order.Status},\"{order.ImagePath}\"";
                            sb.AppendLine(line);
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuExit_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}

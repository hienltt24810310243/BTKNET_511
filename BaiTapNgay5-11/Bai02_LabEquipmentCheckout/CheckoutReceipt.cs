using System;

namespace Bai02_LabEquipmentCheckout
{
    public class CheckoutReceipt
    {
        public string ReceiptId { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string Equipment { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = "Đang mượn";

        // Thuộc tính hiển thị chuỗi ngày trả thực tế trên DataGridView
        public string ReturnDateDisplay => ReturnDate.HasValue ? ReturnDate.Value.ToString("dd/MM/yyyy") : "Chưa trả";

        public CheckoutReceipt() { }

        public CheckoutReceipt(string receiptId, string studentId, string studentName, string equipment, int quantity, DateTime borrowDate, DateTime dueDate, DateTime? returnDate, string status)
        {
            ReceiptId = receiptId;
            StudentId = studentId;
            StudentName = studentName;
            Equipment = equipment;
            Quantity = quantity;
            BorrowDate = borrowDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
            Status = status;
        }

        /// <summary>
        /// Tự động cập nhật trạng thái Quá hạn nếu hạn trả trước ngày hiện tại và chưa trả
        /// </summary>
        public void CapNhatQuaHanTuDong()
        {
            if (Status != "Đã trả" && DueDate.Date < DateTime.Today)
            {
                Status = "Quá hạn";
            }
        }
    }
}

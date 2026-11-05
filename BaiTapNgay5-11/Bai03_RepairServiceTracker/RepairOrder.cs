using System;

namespace Bai03_RepairServiceTracker
{
    public class RepairOrder
    {
        public string OrderId { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty;
        public string FaultDescription { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; }
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; } = "Mới tiếp nhận";
        public string ImagePath { get; set; } = string.Empty;

        public RepairOrder() { }

        public RepairOrder(string orderId, string customerName, string phone, string deviceType, string faultDescription, DateTime receivedDate, decimal estimatedCost, string status, string imagePath = "")
        {
            OrderId = orderId;
            CustomerName = customerName;
            Phone = phone;
            DeviceType = deviceType;
            FaultDescription = faultDescription;
            ReceivedDate = receivedDate;
            EstimatedCost = estimatedCost;
            Status = status;
            ImagePath = imagePath;
        }
    }
}

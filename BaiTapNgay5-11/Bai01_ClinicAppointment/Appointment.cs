using System;

namespace Bai01_ClinicAppointment
{
    public class Appointment
    {
        public string AppointmentId { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; }
        public string Doctor { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = "Chờ khám";

        public Appointment() { }

        public Appointment(string id, string name, string phone, DateTime date, string doctor, string reason, string status)
        {
            AppointmentId = id;
            PatientName = name;
            Phone = phone;
            AppointmentDate = date;
            Doctor = doctor;
            Reason = reason;
            Status = status;
        }
    }
}

namespace NhsSystem.Domain.Entities;

public class Appointment
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid PatientId { get; private set; }
    public Guid ClinicianId { get; private set; }
    public DateTime AppointmentDate { get; private set; }
    public string Status { get; private set; } = "Booked"; // Booked, Cancelled, Completed

    private Appointment() { }

    public Appointment(Guid patientId, Guid clinicianId, DateTime appointmentDate)
    {
        PatientId = patientId;
        ClinicianId = clinicianId;
        AppointmentDate = appointmentDate;
    }

    public void Cancel()
    {
        Status = "Cancelled";
    }
}
namespace NhsSystem.Application.DTOs;

public record AppointmentDto(Guid Id, Guid PatientId, Guid ClinicianId, DateTime AppointmentDate, string Status);
public record CreateAppointmentDto(Guid PatientId, Guid ClinicianId, DateTime AppointmentDate);
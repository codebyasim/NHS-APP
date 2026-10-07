namespace NhsSystem.Application.DTOs;

public record ClinicianDto(Guid Id, string StaffId, string Name, string Specialty);
public record CreateClinicianDto(string StaffId, string Name, string Specialty);
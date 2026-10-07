namespace NhsSystem.Application.DTOs;

public record PatientDto(Guid Id, string NhsNumber, string FirstName, string LastName, DateTime DateOfBirth);
public record CreatePatientDto(string NhsNumber, string FirstName, string LastName, DateTime DateOfBirth);
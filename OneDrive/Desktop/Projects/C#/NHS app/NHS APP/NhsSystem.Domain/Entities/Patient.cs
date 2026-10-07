namespace NhsSystem.Domain.Entities;

public class Patient
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string NhsNumber { get; private set; } = string.Empty;
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public DateTime DateOfBirth { get; private set; }

    private Patient() { } // Required for EF Core

    public Patient(string nhsNumber, string firstName, string lastName, DateTime dateOfBirth)
    {
        NhsNumber = nhsNumber;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}
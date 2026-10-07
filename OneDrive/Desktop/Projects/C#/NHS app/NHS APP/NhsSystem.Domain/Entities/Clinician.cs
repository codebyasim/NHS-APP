namespace NhsSystem.Domain.Entities;

public class Clinician
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string StaffId { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string Specialty { get; private set; } = string.Empty;

    private Clinician() { }

    public Clinician(string staffId, string name, string specialty)
    {
        StaffId = staffId;
        Name = name;
        Specialty = specialty;
    }
}
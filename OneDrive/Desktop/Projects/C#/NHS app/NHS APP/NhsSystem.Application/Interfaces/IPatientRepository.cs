using NhsSystem.Domain.Entities;

namespace NhsSystem.Application.Interfaces;

public interface IPatientRepository : IRepository<Patient>
{
    Task<Patient?> GetByNhsNumberAsync(string nhsNumber);
}
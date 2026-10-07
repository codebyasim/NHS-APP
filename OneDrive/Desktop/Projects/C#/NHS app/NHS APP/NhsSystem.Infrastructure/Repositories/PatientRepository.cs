using Microsoft.EntityFrameworkCore;
using NhsSystem.Application.Interfaces;
using NhsSystem.Domain.Entities;
using NhsSystem.Infrastructure.Data;

namespace NhsSystem.Infrastructure.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly NhsDbContext _context;

    public PatientRepository(NhsDbContext context)
    {
        _context = context;
    }

    public async Task<Patient?> GetByIdAsync(Guid id) => await _context.Patients.FindAsync(id);

    public async Task<IEnumerable<Patient>> GetAllAsync() => await _context.Patients.ToListAsync();

    public async Task AddAsync(Patient entity)
    {
        await _context.Patients.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Patient entity)
    {
        _context.Patients.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Patient entity)
    {
        _context.Patients.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Patient?> GetByNhsNumberAsync(string nhsNumber)
    {
        return await _context.Patients.FirstOrDefaultAsync(p => p.NhsNumber == nhsNumber);
    }
}
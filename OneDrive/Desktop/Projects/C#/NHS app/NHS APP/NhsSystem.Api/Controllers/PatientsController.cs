using Microsoft.AspNetCore.Mvc;
using NhsSystem.Application.Interfaces;
using NhsSystem.Domain.Entities;

namespace NhsSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;

        public PatientsController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetAll()
        {
            var patients = await _patientRepository.GetAllAsync();
            return Ok(patients);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Patient patient)
        {
            await _patientRepository.AddAsync(patient);
            return CreatedAtAction(nameof(GetAll), new { id = patient.Id }, patient);
        }
    }
}
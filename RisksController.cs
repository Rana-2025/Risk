
using Microsoft.AspNetCore.Mvc;
using RiskManagementAPI.Models;

namespace RiskManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RisksController : ControllerBase
    {
        private static readonly List<Risk> Risks = new();

        [HttpGet]
        public IActionResult GetAllRisks() => Ok(Risks);

        [HttpPost]
        public IActionResult CreateRisk([FromBody] Risk risk)
        {
            risk.Id = Risks.Count + 1;
            risk.CreatedAt = DateTime.UtcNow;
            Risks.Add(risk);
            return Ok(risk);
        }
    }
}

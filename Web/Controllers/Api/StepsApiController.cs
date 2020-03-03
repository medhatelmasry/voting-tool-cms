using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Web.Models.Domain;

namespace Web.Controllers.Api
{
    [Route("api/[Controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("PlanVotePolicy")]
    public class StepsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private int _runningElectionID;

        public StepsController(ApplicationDbContext context)
        {
            _context = context;
            _runningElectionID = _context.StateSingleton.Find(State.STATE_ID).RunningElectionID;
        }

        // GET: api/StepsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Step>>> GetSteps()
        {
            return await _context.Steps.Where(s => s.ElectionId == _runningElectionID).ToListAsync();
        }

        // GET: api/StepsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Step>> GetStep(int id)
        {
            var runningElectionID = _context.StateSingleton.First().RunningElectionID;
            var steps = await _context.Steps.Where(s => s.ElectionId == runningElectionID && s.StepNumber == id).ToListAsync();

            var step = steps.First();

            if (step == null)
            {
                return NotFound();
            }

            return step;
        }

        private bool StepExists(int id)
        {
            return _context.Steps.Any(e => e.ID == id);
        }
    }
}

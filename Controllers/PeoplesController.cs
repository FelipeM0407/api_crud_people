using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeoplesController : ControllerBase
    {
        private readonly Context _context;

        public PeoplesController(Context context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<People>>> GetAllAsync()
        {
            return await _context.Peoples.ToListAsync();
        }

        [HttpGet("{peopleId}")]
        public async Task<ActionResult<People>> GetPeopleByIdAsync(int peopleId)
        {
            People? people = await _context.Peoples.FindAsync(peopleId);

            if (people == null)
            {
                return NotFound();
            }

            return people;

        }

        [HttpPost]
        public async Task<ActionResult<People>> SavePeopleAsync(People people)
        {
            await _context.Peoples.AddAsync(people);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePeopleAsync(People people)
        {
            _context.Peoples.Update(people);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{peopleId}")]
        public async Task<ActionResult> RemovePeopleAsync(int peopleId)
        {
            People? people = await _context.Peoples.FindAsync(peopleId);
            if(people == null)
                return NotFound();

            _context.Remove(people);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QA_app_1.Models.PostModels;
using QA_app_1.data;

namespace QA_app_1.Controllers
{
    [Produces("application/json")]
    [Route("api/Classroom")]
    public class ClassroomController : Controller
    {
        private readonly ApplicationDBcontext _context;

        public ClassroomController(ApplicationDBcontext context)
        {
            _context = context;
        }

        // GET: api/Classroom
        [HttpGet]
        public IEnumerable<ClassroomModel> GetClassroomModel()
        {
            return _context.ClassroomModel;
        }

        // GET: api/Classroom/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClassroomModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var classroomModel = await _context.ClassroomModel.SingleOrDefaultAsync(m => m.classroomId == id);

            if (classroomModel == null)
            {
                return NotFound();
            }

            return Ok(classroomModel);
        }

        // PUT: api/Classroom/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassroomModel([FromRoute] int id, [FromBody] ClassroomModel classroomModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classroomModel.classroomId)
            {
                return BadRequest();
            }

            _context.Entry(classroomModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassroomModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Classroom
        [HttpPost]
        public async Task<IActionResult> PostClassroomModel([FromBody] ClassroomModel classroomModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClassroomModel.Add(classroomModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassroomModel", new { id = classroomModel.classroomId }, classroomModel);
        }

        // DELETE: api/Classroom/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassroomModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var classroomModel = await _context.ClassroomModel.SingleOrDefaultAsync(m => m.classroomId == id);
            if (classroomModel == null)
            {
                return NotFound();
            }

            _context.ClassroomModel.Remove(classroomModel);
            await _context.SaveChangesAsync();

            return Ok(classroomModel);
        }

        private bool ClassroomModelExists(int id)
        {
            return _context.ClassroomModel.Any(e => e.classroomId == id);
        }
    }
}
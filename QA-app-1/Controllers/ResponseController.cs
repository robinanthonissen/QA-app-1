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
    [Route("api/Response")]
    public class ResponseController : Controller
    {
        private readonly ApplicationDBcontext _context;

        public ResponseController(ApplicationDBcontext context)
        {
            _context = context;
        }

        // GET: api/Response
        [HttpGet]
        public IEnumerable<ResponseModel> GetResponseModel()
        {
            return _context.ResponseModel;
        }

        // GET: api/Response/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetResponseModel([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var responseModel = await _context.ResponseModel.SingleOrDefaultAsync(m => m.responseType == id);

            if (responseModel == null)
            {
                return NotFound();
            }

            return Ok(responseModel);
        }

        // PUT: api/Response/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResponseModel([FromRoute] string id, [FromBody] ResponseModel responseModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != responseModel.responseType)
            {
                return BadRequest();
            }

            _context.Entry(responseModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponseModelExists(id))
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

        // POST: api/Response
        [HttpPost]
        public async Task<IActionResult> PostResponseModel([FromBody] ResponseModel responseModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ResponseModel.Add(responseModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResponseModel", new { id = responseModel.responseType }, responseModel);
        }

        // DELETE: api/Response/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResponseModel([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var responseModel = await _context.ResponseModel.SingleOrDefaultAsync(m => m.responseType == id);
            if (responseModel == null)
            {
                return NotFound();
            }

            _context.ResponseModel.Remove(responseModel);
            await _context.SaveChangesAsync();

            return Ok(responseModel);
        }

        private bool ResponseModelExists(string id)
        {
            return _context.ResponseModel.Any(e => e.responseType == id);
        }
    }
}
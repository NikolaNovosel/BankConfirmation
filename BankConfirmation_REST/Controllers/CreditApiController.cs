using BankConfirmation_DTO;
using BankConfirmations_BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankConfirmation_REST.Controllers
{
    [Route("api/credit")]
    [ApiController]
    public class CreditApiController : ControllerBase
    {
        // GET: api/<CreditApiController>
        [HttpGet]
        public IActionResult Get()
        {
            CreditBll creditBll = new();
            return Ok(creditBll.GetAll());
        }

        // GET api/<CreditApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CreditBll creditBll = new();
            return Ok(creditBll.GetById(id));
        }

        // POST api/<CreditApiController>
        [HttpPost]
        public IActionResult Post(Credit credit)
        {
            CreditBll creditBll = new();
            try
            {
                creditBll.Insert(credit);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Error");
            }
            return Ok(CreatedAtAction(nameof(Get), new { id = credit.Id }, credit));
        }

        // PUT api/<CreditApiController>/5
        [HttpPut]
        public IActionResult Put(Credit credit)
        {
            CreditBll creditBll = new();
            try
            {
                creditBll.Update(credit);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest,"Error");
            }
            return CreatedAtAction(nameof(Get), new { id = credit.Id}, credit);
        }

        // DELETE api/<CreditApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CreditBll creditBll = new();
            creditBll.Delete(id);
            return NoContent();
        }
    }
}

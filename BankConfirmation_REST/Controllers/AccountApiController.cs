using BankConfirmation_DTO;
using BankConfirmations_BLL;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace BankConfirmation_REST.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountApiController : ControllerBase
    {
        // GET: api/<AccountApiController>
        [HttpGet]
        public IActionResult Get()
        {
            AccountBll accountBll = new();
            return Ok(accountBll.GetAll());
        }

        // GET api/<AccountApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AccountBll accountBll = new();
            return Ok(accountBll.GetById(id));
        }

        // POST api/<AccountApiController>
        [HttpPost]
        public IActionResult Post(Account account)
        {
            AccountBll accountBll = new();
            try
            {
                accountBll.Insert(account);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error");
            }
            return CreatedAtAction(nameof(Get), new { id = account.Id }, account);
        }

        // PUT api/<AccountApiController>/5
        [HttpPut]
        public IActionResult Put(Account account)
        {
            AccountBll accountBll = new();
            try
            {
                accountBll.Update(account);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error");
            }
            return CreatedAtAction(nameof(Get), new { id = account.Id }, account);
        }

        // DELETE api/<AccountApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AccountBll accountBll = new();
            accountBll.Delete(id);
            return NoContent();
        }
    }
}

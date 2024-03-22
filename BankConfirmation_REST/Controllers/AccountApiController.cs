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
            return Ok(AccountBll.GetAll());
        }

        // GET api/<AccountApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = AccountBll.GetById(id);
            return Ok(result);
        }

        // POST api/<AccountApiController>
        [HttpPost]
        public IActionResult Post(Account account)
        {
            AccountBll.Insert(account);
            return CreatedAtAction(nameof(Get), new { id = account.Id }, account);

        }

        // PUT api/<AccountApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Account account)
        {
            if (id != account.Id)
            {
                return BadRequest("account Id missmatch");
            }

            try
            {
                AccountBll.Update(account);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error");
            }

            return NoContent();
        }

        // DELETE api/<AccountApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = AccountBll.GetById(id);

            if (result==null)
            {
                NotFound();
            }
            AccountBll.Delete(id);
            return NoContent();
        }
    }
}

using BankConfirmation_DTO;
using BankConfirmations_BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankConfirmation_REST.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientApiController : ControllerBase
    {
        // GET: api/<ClientApiController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ClientBll.GetAll());
        }

        // GET api/<ClientApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = ClientBll.GetById(id);
            return Ok(result);
        }

        // POST api/<ClientApiController>
        [HttpPost]
        public IActionResult Post(Client client)
        {
            ClientBll.Insert(client);
            return CreatedAtAction(nameof(Get), new { id = client.Id }, client);
        }

        // PUT api/<ClientApiController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Client client)
        {
            if (id != client.Id)
            {
                return BadRequest("client Id missmatch");
            }

            try
            {
                ClientBll.Update(client);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error");
            }

            return NoContent();
        }

        // DELETE api/<ClientApiController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = ClientBll.GetById(id);
            if (result == null)
            {
                NotFound();
            }
            return NoContent();
        }
    }
}

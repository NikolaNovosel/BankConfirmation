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
            ClientBll clientBll = new();
            return Ok(clientBll.GetAll());
        }

        // GET api/<ClientApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ClientBll clientBll = new();
            return Ok(clientBll.GetById(id));
        }

        // POST api/<ClientApiController>
        [HttpPost]
        public IActionResult Post(Client client)
        {
            ClientBll clientBll = new();
            try
            {
                clientBll.Insert(client);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Error");   
            }
            return CreatedAtAction(nameof(Get), new { id = client.Id }, client);
        }

        // PUT api/<ClientApiController>/5
        [HttpPut]
        public ActionResult Put(Client client)
        {
            ClientBll clientBll = new();
            try
            {
                clientBll.Update(client);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error");
            }
            return CreatedAtAction(nameof(Get), new { id=client.Id }, client);
        }

        // DELETE api/<ClientApiController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ClientBll clientBll = new();
            clientBll.Delete(id);
            return NoContent();
        }
    }
}

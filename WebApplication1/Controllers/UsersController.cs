using LabMediatorLibrary.Application.Commands;
using LabMediatorLibrary.Application.Queries;
using LabMediatorLibrary.Domain.Interfaces.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> Get()
        {
           return Ok(await _mediator.Send(new GetUsersQuery()));
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            var user = await _mediator.Send(new GetUserByIdQuery { Id = id });
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] AddUserDTO addUserDTO)
        {
            try
            {
            var user  = await _mediator.Send(new AddUserCommand { User = addUserDTO });
               return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

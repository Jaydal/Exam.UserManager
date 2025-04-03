using Exam.UserManager.Service;
using Microsoft.AspNetCore.Mvc;

namespace Exam.UserManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserQueryService _userQueryService;
        private readonly IUserWriteService _userWriteService;
        public UserController(IUserQueryService userQueryService, IUserWriteService userWriteService)
        {
            _userQueryService = userQueryService;
            _userWriteService = userWriteService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                //TODO: Item 4: Implement the logic to get user by id
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var users = _userQueryService.GetAll();
                return Ok(users);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserDTO userDto)
        {
            try
            {
                //TODO: Item 5: Implement the logic to add user
                var userId = "assign value";
                return CreatedAtAction(nameof(Get), new { id = userId }, userDto);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UserDTO userDto)
        {
            try
            {
                userDto.Id = id;
                //TODO Item 6: Implement the logic to update user
                //var result = _userWriteService
                //if (result)
                //{
                //    return NoContent();
                //}
                return NotFound();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //TODO Item 7: Implement the logic to delete user
                //var result = _userWriteService
                //if (result)
                //{
                //    return NoContent();
                //}
                return NotFound();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

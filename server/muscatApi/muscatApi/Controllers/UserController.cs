using Microsoft.AspNetCore.Mvc;
using muscatApi.Models;
using muscatApi.Services;


namespace muscatApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<MyUser> GetAll()
        {
            return _userService.GetAll();
        }

        // GET controller/5
        [HttpGet("{id}")]
        public ActionResult<MyUser> GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user is not null)
            {
                return user;
            }
            else
            {
                return NotFound();
            }
        }

        // POST <UserController>
        [HttpPost]
        public IActionResult Create(MyUser newUser)
        {
            var user = _userService.Create(newUser);
            return CreatedAtAction(nameof(GetById), new { Id = user!.Id }, user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // 회원정보 변경 - 아직 비워둔다
            // id/pw 바꾸기 기능과 함께 구현
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userService.GetById(id);

            if(user is not null)
            {
                _userService.DeleteById(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}

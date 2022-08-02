using Library.API.DTO;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;


namespace Library.API.Controllers
{
    /*
     * Generate users:
     * json-generator.com
     
     [
        '{{repeat(125)}}',
        {
            firstname: '{{firstName()}} ',
            lastname: ' {{surname()}}',
            DateOfBirth: '{{date(new Date(2014, 0, 1), new Date(), "YYYY-MM-ddThh:mm:ss")}}',
            email: '{{email()}}'    
        }
    ]
     */

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServices _services;
        public UserController(IServices services)
        {
            _services = services;
        }

        [HttpGet("list")]
        public List<UserDTO> List()
        {
            return _services.UserList();
        }

        [HttpGet("find")]
        public List<UserDTO> Find(string search)
        {
            return _services.FindUser(search);
        }

        [HttpPost("saveuser")]
        public void SaveUser(List<UserDTO> userList)
        {
            _services.SaveUser(userList);             
        }

    }
}

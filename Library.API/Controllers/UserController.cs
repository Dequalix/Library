using Library.API.DTO;
using Library.API.Models;
using Library.API.Repositories;
using Microsoft.AspNetCore.Http;
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
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet("list")]
        public List<UserDTO> List()
        {
            return this._userRepository.List().Select((user) => Mapper.ToUserDto(user)).ToList();
        }

        [HttpGet("find")]
        public List<UserDTO> Find(string name)
        {
            return this._userRepository.FindUserByName(name).Select((user) => Mapper.ToUserDto(user)).ToList();
        }

        [HttpGet("findadres")]
        public List<UserDTO> FindOnAdres(string adres)
        {
            return this._userRepository.FindUserByAdres(adres).Select((user) => Mapper.ToUserDto(user)).ToList();
        }

        [HttpPost("saveuser")]
        public void SaveUser(List<UserDTO> userList)
        {
            userList.ForEach(user => this._userRepository.SaveUser(Mapper.ToUser(user)));            
        }

    }
}

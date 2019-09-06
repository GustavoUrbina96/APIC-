using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;
using WebApplication8.Repositories;

namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _userService.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUsers")]
        public UserModel Get(int id) => _userService.GetUserById(id);

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]UserModel newUser) => _userService.AddUser(newUser);

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]UserModel User)
        {
            _userService.UpdateUser(id, User);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}

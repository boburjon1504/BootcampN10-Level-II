﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Models;
using OnlineMarket.Services;

namespace OnlineMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        [HttpGet("{id:Guid}")]
        public async Task<IEnumerable<User>> GetUsers() =>
            await _userService.GetAsync();
        [HttpPost]
        public async Task<User> Create(User user)
        {
            var newUser = await _userService.CreateAsync(user);

            return newUser;
        }
        [HttpDelete]
        public async Task<User> Delete(Guid id)=>
            await _userService.DeleteAsync(id);

    }
}

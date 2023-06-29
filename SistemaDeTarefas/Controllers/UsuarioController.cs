using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Data.Dto;
using SistemaDeTarefas.Data.Dtos;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repository.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsuarioController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ReadUserDto>>> SearchAllUsers()
        {
            List<UserMd> usuarios = await _userRepository.SearchAllUsers();
            return Ok(usuarios);
        }

        [HttpGet("id")]
        public async Task<ActionResult<ReadUserDto>> SearchUserById(int id)
        {
            UserMd? usuario = await _userRepository.SearchUserById(id);

            if (usuario == null) return NotFound();

            ReadUserDto userReturn = new ReadUserDto()
            {
                Id = usuario.Id,
                Name = usuario.Name,
                Email = usuario.Email
            };

            return userReturn;
        }

        [HttpPost]
        public async Task<ReadUserDto> AddUser(CreateUserDto userDto)
        {
            UserMd usuario = new UserMd()
            {
                Name = userDto.Name,
                Email = userDto.Email
            };

            await _userRepository.AddUser(usuario);

            ReadUserDto userReturn = new ReadUserDto()
            {
                Id = usuario.Id,
                Name = usuario.Name,
                Email = usuario.Email
            };

            return userReturn;
        }

        [HttpPut("id")]
        public async Task<ReadUserDto> UpdateUserById(UpdateUserDto user, int id)
        {
            UserMd usuario = new UserMd()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };

            await _userRepository.UpdateUserById(usuario, id);

            ReadUserDto userReturn = new ReadUserDto()
            {
                Id = usuario.Id,
                Name = usuario.Name,
                Email = usuario.Email
            };

            return userReturn;
        }

        [HttpDelete("id")]
        public async Task<bool> DropUser(int id)
        {
            bool usuario = await _userRepository.DropUser(id);
            return usuario;
        }
    }
}

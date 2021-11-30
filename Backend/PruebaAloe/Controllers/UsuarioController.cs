using Microsoft.AspNetCore.Mvc;
using PruebaAloe.core;
using PruebaAloe.DTO;
using PruebaAloe.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaAloe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService) {
            _usuarioService = usuarioService;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<Usuario>> Get()
        {
            return await _usuarioService.GetAll();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<Usuario> Post([FromBody] UsuarioDTO usuario)
        {
            var newUsuario = new Usuario()
            {
                Nombres=usuario.Nombres,
                Apellidos=usuario.Apellidos,
                FechaNacimiento=usuario.FechaNacimiento,
                Cargo=usuario.Cargo,
                Cedula=usuario.Cedula,
                Genero=char.Parse(usuario.Genero),
            };
            int departamento = 0,supervisor=0;
            int.TryParse(usuario.Departamento,out departamento);
            int.TryParse(usuario.Supervisor, out supervisor);
            return await _usuarioService.Create(newUsuario,departamento,supervisor);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

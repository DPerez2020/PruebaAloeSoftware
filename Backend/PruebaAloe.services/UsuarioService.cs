using PruebaAloe.core;
using PruebaAloe.data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.services
{
    public class UsuarioService:IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IDepartamentoService _departamentoService;
        public UsuarioService(IUsuarioRepositorio usuarioRepositorio,IDepartamentoService departamentoService) {
            _usuarioRepositorio = usuarioRepositorio;
            _departamentoService = departamentoService;
        }

        public async Task<Usuario> Create(Usuario usuario,int idDepartamento,int idSupervisor)
        {
            if (idSupervisor!=0)
            {
                usuario.SupervisorInmediato = await _usuarioRepositorio.Get(idSupervisor);
            }
            if (idDepartamento!=0)
            {
                usuario.Departamento = await _departamentoService.Get(idDepartamento);
            }
            return await _usuarioRepositorio.Create(usuario);
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await _usuarioRepositorio.GetAllUsers();
        }
    }
    public interface IUsuarioService {
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> Create(Usuario usuario, int idDepartamento, int idSupervisor);
    }

}

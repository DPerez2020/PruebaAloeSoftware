using Microsoft.EntityFrameworkCore;
using PruebaAloe.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.data.Repositorios
{
    public class UsuarioRepositorio : GenericRepositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly ApplicationDBContext applicationDbContext;
        public UsuarioRepositorio(ApplicationDBContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsers()
        {
            return await _applicationDbContext.Usuario.Include(x => x.Departamento).ToListAsync();
        }
    }
    public interface IUsuarioRepositorio : IGenericRepository<Usuario> {
        Task<IEnumerable<Usuario>> GetAllUsers();
    }
}

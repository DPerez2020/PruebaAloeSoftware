using PruebaAloe.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.data.Repositorios
{
    public class DepartamentoRepositorio : GenericRepositorio<Departamento>, IDepartamentoRepositorio
    {
        public DepartamentoRepositorio(ApplicationDBContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
    public interface IDepartamentoRepositorio : IGenericRepository<Departamento> { }
}

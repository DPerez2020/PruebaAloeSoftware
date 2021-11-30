using PruebaAloe.core;
using PruebaAloe.data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAloe.services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepositorio _departamentoRepositorio;
        public DepartamentoService(IDepartamentoRepositorio departamentoRepositorio) {
            _departamentoRepositorio = departamentoRepositorio;
        }

        public async Task<Departamento> Get(int id)
        {
            return await _departamentoRepositorio.Get(id);
        }

        public async Task<IEnumerable<Departamento>> GetAll()
        {
            return await _departamentoRepositorio.GetAll();
        }
    }
    public interface IDepartamentoService {
        Task<IEnumerable<Departamento>> GetAll();
        Task<Departamento> Get(int id);
    }
}

using SistemaDeTarefa.Data;
using SistemaDeTarefa.Models;
using SistemaDeTarefa.Repositorios.Interfaces;

namespace SistemaDeTarefa.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaDeTarefasDBContext _dbContext;
        public UsuarioRepositorio(SistemaDeTarefasDBContext sistemaDeTarefasDBContext)
        {
            _dbContext = sistemaDeTarefasDBContext;
        }

        public Task<UsuarioModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        
    }
}

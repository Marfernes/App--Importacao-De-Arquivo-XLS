using ImportarArquivoService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImportarArquivoService.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity BuscarPorId(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

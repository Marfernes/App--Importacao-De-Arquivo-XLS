using ImportarArquivoXLS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImportarArquivoXLS.Infra.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity BuscarPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

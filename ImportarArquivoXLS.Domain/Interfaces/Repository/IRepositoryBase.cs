using System;
using System.Collections.Generic;
using System.Text;

namespace ImportarArquivoXLS.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        TEntity BuscarPorId(Guid Id);
        IEnumerable<TEntity> BuscarTodos();
    }
}

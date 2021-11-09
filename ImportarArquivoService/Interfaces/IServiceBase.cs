using System;
using System.Collections.Generic;
using System.Text;

namespace ImportarArquivoService.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity:class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(TEntity entity);
        TEntity BuscarPorId(Guid ID);
        IEnumerable<TEntity> BuscarTodos();
    }
}

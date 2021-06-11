using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPagarReceber.WindowsForm
{
    public interface IRepositorio<TEntity>
    {
        TEntity BuscarPorId(Guid id);
        List<TEntity> BuscarTodos();

        Guid Adicionar(TEntity entidade);

        void Atualizar(TEntity entidade);

        List<TEntity> Buscar(string texto, string filtro);

        Decimal ObterBalanco();
    }
}

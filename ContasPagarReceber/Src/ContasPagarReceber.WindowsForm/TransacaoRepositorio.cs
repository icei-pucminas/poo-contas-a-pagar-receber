using System;
using System.Collections.Generic;

namespace ContasPagarReceber.WindowsForm
{
    class TransacaoRepositorio : IRepositorio<Transacao>
    {
        private readonly List<Transacao> TranscaoList = new();

        public TransacaoRepositorio()
        {
            this.TranscaoList.Add(new Transacao
            {
                DataVencimento = DateTime.Now.AddDays(1),
                Descricao = "Pagamento teste",
                Identificador = Guid.NewGuid(),
                Tipo = TipoTransacao.DESPESA,
                Valor = 150
            }); ;
        }

        public Guid Adicionar(Transacao entidade)
        {
            Guid identificador = Guid.NewGuid();
            entidade.Identificador = identificador;
            this.TranscaoList.Add(entidade);
            return identificador;
        }

        public void Atualizar(Transacao entidade)
        {
            throw new NotImplementedException();
        }

        public List<Transacao> Buscar(string texto)
        {
            return this.TranscaoList;
        }

        public Transacao BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Transacao> BuscarTodos()
        {
            return this.TranscaoList;
        }
        public decimal ObterBalanco()
        {
            decimal despesas = 0;
            decimal receitas = 0;

            this.TranscaoList.ForEach((transacao) =>
            {
                _ = transacao.Tipo == TipoTransacao.DESPESA ? despesas += transacao.Valor : receitas += transacao.Valor;
            });
            return receitas - despesas;
        }
    }
}

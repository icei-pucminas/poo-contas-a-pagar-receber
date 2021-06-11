using System;
using System.Collections.Generic;
using System.Linq;

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
            });
            this.TranscaoList.Add(new Transacao
            {
                DataVencimento = DateTime.Now.AddDays(2),
                Descricao = "Salário",
                Identificador = Guid.NewGuid(),
                Tipo = TipoTransacao.RECEITA,
                Valor = 300
            });
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

        public List<Transacao> Buscar(string texto, string filtro)
        {
            if (texto == "") return this.BuscarTodos();
            
            return this.TranscaoList.FindAll((transacao) =>
            {
                // Busca o valor a partir da propriedade passada eg. objeto[filtro]
                System.Reflection.PropertyInfo prop = typeof(Transacao).GetProperty(filtro);
                string valorProp = prop.GetValue(transacao).ToString();

                return texto == valorProp.ToLower();
            });
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

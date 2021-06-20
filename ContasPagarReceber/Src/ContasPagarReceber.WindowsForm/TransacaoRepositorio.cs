using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ContasPagarReceber.WindowsForm
{
    class TransacaoRepositorio : IRepositorio<Transacao>
    {
        private readonly XmlSerializer XmlSerializer = new(typeof(List<Transacao>));
        private readonly string ArquivoTransacao = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Transacoes.xml");
        private readonly List<Transacao> TranscaoList = new();

        public TransacaoRepositorio()
        {
            if (File.Exists(ArquivoTransacao))
            {
                TextReader Reader = new StreamReader(ArquivoTransacao);
                TranscaoList = (List<Transacao>)XmlSerializer.Deserialize(Reader);
                Reader.Close();
                Reader.Dispose();
            }
        }

        private void Salvar()
        {
            File.Delete(ArquivoTransacao);
            TextWriter Writer = new StreamWriter(ArquivoTransacao);
            XmlSerializer.Serialize(Writer, TranscaoList);
            Writer.Flush();
            Writer.Close();
            Writer.Dispose();
        }

        public Guid Adicionar(Transacao entidade)
        {
            Guid identificador = Guid.NewGuid();
            entidade.Identificador = identificador;
            TranscaoList.Add(entidade);

            this.Salvar();

            return identificador;
        }

        public void Apagar(string y)
        {
            this.TranscaoList.Remove(this.TranscaoList.Find(x => x.Identificador.ToString().Contains(y)));

            this.Salvar();
        }

        public void Atualizar(Transacao entidade)
        {
            this.TranscaoList[this.TranscaoList.IndexOf(entidade)] = entidade;
            this.Salvar();
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
            return TranscaoList.Where(t => t.Identificador.Equals(id)).FirstOrDefault();
        }

        public List<Transacao> BuscarTodos()
        {
            return TranscaoList;
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

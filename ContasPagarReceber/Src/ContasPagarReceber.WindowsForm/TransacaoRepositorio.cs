using System;
using System.Collections.Generic;
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

        public void Atualizar(Transacao entidade)
        {
            this.TranscaoList[this.TranscaoList.IndexOf(entidade)] = entidade;
            this.Salvar();
        }

        public List<Transacao> Buscar(string texto)
        {
            return TranscaoList.Where(t => t.Descricao.Contains(texto)).ToList();
        }

        public Transacao BuscarPorId(Guid id)
        {
            return TranscaoList.Where(t => t.Identificador.Equals(id)).FirstOrDefault();
        }

        public List<Transacao> BuscarTodos()
        {
            return TranscaoList;
        }
    }
}

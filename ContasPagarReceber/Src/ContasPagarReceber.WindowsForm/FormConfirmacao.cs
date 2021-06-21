using System;
using System.Windows.Forms;

namespace ContasPagarReceber.WindowsForm
{
   
    public partial class FormConfirmacao : Form
    {
        public class DataSelecionadaArgs
        {
            public Guid TransacaoId { get; set; }
            public DateTime DataPagamento { get; set; }
        }

        public event EventHandler<DataSelecionadaArgs> DataSelecionada;
        private readonly Guid transacaoId;
        public FormConfirmacao(Guid transacaoId)
        {
            this.transacaoId = transacaoId;
            InitializeComponent();
        }

        protected virtual void OnDataSelecionada(DateTime data)
        {
            DataSelecionada?.Invoke(this, new DataSelecionadaArgs
            { 
                DataPagamento = data,
                TransacaoId = transacaoId
            });

            this.Close();
            this.Dispose();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            OnDataSelecionada(dtpPagamento.Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

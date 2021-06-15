using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContasPagarReceber.WindowsForm
{
    public partial class FormContas : Form
    {
        public IRepositorio<Transacao> repositorio;
        
        public FormContas(IRepositorio<Transacao> repositorio)
        {
            this.repositorio = repositorio;
            InitializeComponent();
        }

        private void atualizarBalanco()
        {
            decimal balanco = repositorio.ObterBalanco();
            labelBalancoTotal.Text = "R$ " + balanco;
            if (balanco < 0)
            {
                labelBalancoTotal.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                labelBalancoTotal.ForeColor = Color.FromArgb(0, 255, 26);
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormContas_Load(object sender, EventArgs e)
        {
            gridTransacoes.DataSource = repositorio.BuscarTodos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            repositorio.Adicionar(new Transacao
            {
                DataVencimento = DateTime.Now.AddDays(1),
                Descricao = "Pagamento teste",
                Identificador = Guid.NewGuid(),
                Tipo = TipoTransacao.DESPESA,
                Valor = 150
            });

            gridTransacoes.Refresh();
        }

	    private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void labelBalancoTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonBalanco_Click(object sender, EventArgs e)
        {
            atualizarBalanco();
        }
    }
}

using System;
using System.Drawing;
using System.Reflection;
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

        
        private void atualizaGrid()
        {
            gridTransacoes.DataSource = null;
            gridTransacoes.DataSource = repositorio.BuscarTodos();
            this.atualizarBalanco();
            gridTransacoes.Update();
            gridTransacoes.Refresh();
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
            string filtro = comboFiltros.SelectedItem.ToString();
            string textoBusca = searchText.Text;
            gridTransacoes.DataSource = repositorio.Buscar(textoBusca, filtro);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormContas_Load(object sender, EventArgs e)
        {
            gridTransacoes.DataSource = repositorio.BuscarTodos();
            criaFiltros();
            atualizarBalanco();
        }
        private void criaFiltros()
        {
            // Itera por cada propriedade da classe Transação e o insere na listagem de filtros 
            PropertyInfo[] propriedades = typeof(Transacao).GetProperties();
            foreach(PropertyInfo propriedade in propriedades)
            {
                int indexFiltro = comboFiltros.Items.Count;
                comboFiltros.Items.Insert(indexFiltro, propriedade.Name);
            }
            comboFiltros.SelectedIndex = 0;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormNovaConta formNova = new FormNovaConta(this.repositorio);
            formNova.ShowDialog();
            atualizaGrid();
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
        private void gridTransacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Transacao transacao = repositorio.BuscarTodos()[e.RowIndex];
                FormConfirmacao formConfirmacao = new(transacao.Identificador);
                formConfirmacao.DataSelecionada += FormConfirmacao_DataSelecionada1;
                formConfirmacao.ShowDialog();
            }
        }

        private void FormConfirmacao_DataSelecionada1(object sender, FormConfirmacao.DataSelecionadaArgs e)
        {
            Transacao transacao = repositorio.BuscarPorId(e.TransacaoId);
            transacao.DataPagamento = e.DataPagamento;
            repositorio.Atualizar(transacao);

            atualizaGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = gridTransacoes.SelectedCells[0].Value.ToString();

            var confirmResult = MessageBox.Show("Tem certeza que deseja apagar este item?",
                                     "Confirmação!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.repositorio.Apagar(ID);
                atualizaGrid();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            repositorio.Salvar();
            MessageBox.Show("Suas alterações foram salvas com sucesso.","Confirmação");
        }      

        private void gridTransacoes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            repositorio.Salvar();
        }
    }
}

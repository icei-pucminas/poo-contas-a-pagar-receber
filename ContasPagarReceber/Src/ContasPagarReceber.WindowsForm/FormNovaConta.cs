using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasPagarReceber.WindowsForm
{
    public partial class FormNovaConta : Form
    {

        public IRepositorio<Transacao> repositorio;
        public FormNovaConta(IRepositorio<Transacao> repositorio)
        {
            this.repositorio = repositorio;
            InitializeComponent();
        }
        private void FormNovaConta_Load(object sender, EventArgs e)
        {
            criaTipos();
            
        }
        private void criaTipos()
        {
            int index = c_box_tipo.Items.Count;
            c_box_tipo.Items.Insert(index, "Despesa");
            c_box_tipo.Items.Insert(index, "Receita");
            c_box_tipo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void t_box_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_box_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void t_box_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_box_desc.Clear();
            t_box_valor.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transacao transacao = new Transacao();
            transacao.DataPagamento = dateTimePickerPagamento.Value;
            transacao.DataVencimento = dateTimePickerVencimento.Value;
            transacao.Descricao = t_box_desc.Text;
            transacao.Tipo = (TipoTransacao)c_box_tipo.SelectedIndex;
            transacao.Valor = decimal.Parse(t_box_valor.Text);
            this.repositorio.Adicionar(transacao);
            Close();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

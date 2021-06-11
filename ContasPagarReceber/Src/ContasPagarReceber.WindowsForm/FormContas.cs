﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasPagarReceber.WindowsForm
{

    public partial class FormContas : Form
    {
        public IRepositorio<Transacao> repositorio = new TransacaoRepositorio();

        public FormContas()
        {
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
        private void Form1_Load(object sender, EventArgs e)
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

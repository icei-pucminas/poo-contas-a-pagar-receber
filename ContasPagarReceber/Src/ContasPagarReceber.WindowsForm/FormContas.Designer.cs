﻿
namespace ContasPagarReceber.WindowsForm
{
    partial class FormContas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridTransacoes = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTransacoes
            // 
            this.gridTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransacoes.Location = new System.Drawing.Point(12, 116);
            this.gridTransacoes.Name = "gridTransacoes";
            this.gridTransacoes.RowTemplate.Height = 25;
            this.gridTransacoes.Size = new System.Drawing.Size(780, 534);
            this.gridTransacoes.TabIndex = 0;
            this.gridTransacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(12, 87);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(338, 23);
            this.searchText.TabIndex = 1;
            this.searchText.Text = "s";
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(356, 87);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 69);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(188, 15);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Buscar Transação por Identificador";
            this.searchLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(717, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FormContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 662);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.gridTransacoes);
            this.Name = "FormContas";
            this.Text = "Contas a Pagar e Receber";
            this.Load += new System.EventHandler(this.FormContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTransacoes;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button btnAdicionar;
    }
}


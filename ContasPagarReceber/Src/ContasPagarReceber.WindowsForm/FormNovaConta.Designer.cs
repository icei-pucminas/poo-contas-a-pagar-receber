
namespace ContasPagarReceber.WindowsForm
{
    partial class FormNovaConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.t_box_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_box_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_box_valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePickerVencimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // t_box_desc
            // 
            this.t_box_desc.Location = new System.Drawing.Point(257, 27);
            this.t_box_desc.Name = "t_box_desc";
            this.t_box_desc.Size = new System.Drawing.Size(343, 23);
            this.t_box_desc.TabIndex = 3;
            this.t_box_desc.TextChanged += new System.EventHandler(this.t_box_desc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // c_box_tipo
            // 
            this.c_box_tipo.FormattingEnabled = true;
            this.c_box_tipo.Location = new System.Drawing.Point(12, 69);
            this.c_box_tipo.Name = "c_box_tipo";
            this.c_box_tipo.Size = new System.Drawing.Size(134, 23);
            this.c_box_tipo.TabIndex = 4;
            this.c_box_tipo.SelectedIndexChanged += new System.EventHandler(this.c_box_tipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // t_box_valor
            // 
            this.t_box_valor.Location = new System.Drawing.Point(152, 69);
            this.t_box_valor.Name = "t_box_valor";
            this.t_box_valor.Size = new System.Drawing.Size(183, 23);
            this.t_box_valor.TabIndex = 6;
            this.t_box_valor.TextChanged += new System.EventHandler(this.t_box_valor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // dateTimePickerPagamento
            // 
            this.dateTimePickerPagamento.Location = new System.Drawing.Point(10, 27);
            this.dateTimePickerPagamento.Name = "dateTimePickerPagamento";
            this.dateTimePickerPagamento.Size = new System.Drawing.Size(241, 23);
            this.dateTimePickerPagamento.TabIndex = 8;
            this.dateTimePickerPagamento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerVencimento
            // 
            this.dateTimePickerVencimento.Location = new System.Drawing.Point(356, 69);
            this.dateTimePickerVencimento.Name = "dateTimePickerVencimento";
            this.dateTimePickerVencimento.Size = new System.Drawing.Size(241, 23);
            this.dateTimePickerVencimento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Vencimento";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Brown;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(513, 115);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 33);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormNovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 193);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerVencimento);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_box_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_box_tipo);
            this.Controls.Add(this.t_box_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovaConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta";
            this.Load += new System.EventHandler(this.FormNovaConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_box_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c_box_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_box_valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerPagamento;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
    }
}
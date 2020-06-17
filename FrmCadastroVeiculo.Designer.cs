namespace aula_09_06
{
    partial class FrmCadastroVeiculo
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mskAno = new System.Windows.Forms.MaskedTextBox();
            this.txbFechar = new System.Windows.Forms.Button();
            this.txbExcluir = new System.Windows.Forms.Button();
            this.txbAlterar = new System.Windows.Forms.Button();
            this.txbIncluir = new System.Windows.Forms.Button();
            this.txbFabricante = new System.Windows.Forms.TextBox();
            this.txbCodveiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(332, 231);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // mskAno
            // 
            this.mskAno.Location = new System.Drawing.Point(15, 143);
            this.mskAno.Mask = "9999/9999";
            this.mskAno.Name = "mskAno";
            this.mskAno.Size = new System.Drawing.Size(193, 20);
            this.mskAno.TabIndex = 27;
            // 
            // txbFechar
            // 
            this.txbFechar.Location = new System.Drawing.Point(479, 231);
            this.txbFechar.Name = "txbFechar";
            this.txbFechar.Size = new System.Drawing.Size(75, 23);
            this.txbFechar.TabIndex = 25;
            this.txbFechar.Text = "Fechar";
            this.txbFechar.UseVisualStyleBackColor = true;
            // 
            // txbExcluir
            // 
            this.txbExcluir.Location = new System.Drawing.Point(239, 231);
            this.txbExcluir.Name = "txbExcluir";
            this.txbExcluir.Size = new System.Drawing.Size(75, 23);
            this.txbExcluir.TabIndex = 24;
            this.txbExcluir.Text = "Excluir";
            this.txbExcluir.UseVisualStyleBackColor = true;
            // 
            // txbAlterar
            // 
            this.txbAlterar.Location = new System.Drawing.Point(137, 231);
            this.txbAlterar.Name = "txbAlterar";
            this.txbAlterar.Size = new System.Drawing.Size(75, 23);
            this.txbAlterar.TabIndex = 23;
            this.txbAlterar.Text = "Alterar";
            this.txbAlterar.UseVisualStyleBackColor = true;
            // 
            // txbIncluir
            // 
            this.txbIncluir.Location = new System.Drawing.Point(32, 231);
            this.txbIncluir.Name = "txbIncluir";
            this.txbIncluir.Size = new System.Drawing.Size(75, 23);
            this.txbIncluir.TabIndex = 22;
            this.txbIncluir.Text = "Incluir";
            this.txbIncluir.UseVisualStyleBackColor = true;
            this.txbIncluir.Click += new System.EventHandler(this.txbIncluir_Click);
            // 
            // txbFabricante
            // 
            this.txbFabricante.Location = new System.Drawing.Point(202, 59);
            this.txbFabricante.Name = "txbFabricante";
            this.txbFabricante.Size = new System.Drawing.Size(97, 20);
            this.txbFabricante.TabIndex = 21;
            this.txbFabricante.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbCodveiculo
            // 
            this.txbCodveiculo.Location = new System.Drawing.Point(15, 59);
            this.txbCodveiculo.Name = "txbCodveiculo";
            this.txbCodveiculo.Size = new System.Drawing.Size(124, 20);
            this.txbCodveiculo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(389, 59);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(97, 20);
            this.txbModelo.TabIndex = 29;
            // 
            // FrmCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 294);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mskAno);
            this.Controls.Add(this.txbFechar);
            this.Controls.Add(this.txbExcluir);
            this.Controls.Add(this.txbAlterar);
            this.Controls.Add(this.txbIncluir);
            this.Controls.Add(this.txbFabricante);
            this.Controls.Add(this.txbCodveiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroVeiculo";
            this.Text = "Cadastro de Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox mskAno;
        private System.Windows.Forms.Button txbFechar;
        private System.Windows.Forms.Button txbExcluir;
        private System.Windows.Forms.Button txbAlterar;
        private System.Windows.Forms.Button txbIncluir;
        private System.Windows.Forms.TextBox txbFabricante;
        private System.Windows.Forms.TextBox txbCodveiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbModelo;
    }
}
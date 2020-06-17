namespace aula_09_06
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbIncluir = new System.Windows.Forms.Button();
            this.txbAlterar = new System.Windows.Forms.Button();
            this.txbExcluir = new System.Windows.Forms.Button();
            this.txbFechar = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskDt = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome Completo";
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(12, 46);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(124, 20);
            this.txbCod.TabIndex = 4;
            this.txbCod.TextChanged += new System.EventHandler(this.txbCod_TextChanged);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(12, 122);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(482, 20);
            this.txbNome.TabIndex = 7;
            // 
            // txbIncluir
            // 
            this.txbIncluir.Location = new System.Drawing.Point(30, 172);
            this.txbIncluir.Name = "txbIncluir";
            this.txbIncluir.Size = new System.Drawing.Size(75, 23);
            this.txbIncluir.TabIndex = 8;
            this.txbIncluir.Text = "Incluir";
            this.txbIncluir.UseVisualStyleBackColor = true;
            this.txbIncluir.Click += new System.EventHandler(this.txbIncluir_Click);
            // 
            // txbAlterar
            // 
            this.txbAlterar.Location = new System.Drawing.Point(135, 172);
            this.txbAlterar.Name = "txbAlterar";
            this.txbAlterar.Size = new System.Drawing.Size(75, 23);
            this.txbAlterar.TabIndex = 9;
            this.txbAlterar.Text = "Alterar";
            this.txbAlterar.UseVisualStyleBackColor = true;
            // 
            // txbExcluir
            // 
            this.txbExcluir.Location = new System.Drawing.Point(237, 172);
            this.txbExcluir.Name = "txbExcluir";
            this.txbExcluir.Size = new System.Drawing.Size(75, 23);
            this.txbExcluir.TabIndex = 10;
            this.txbExcluir.Text = "Excluir";
            this.txbExcluir.UseVisualStyleBackColor = true;
            this.txbExcluir.Click += new System.EventHandler(this.txbExcluir_Click);
            // 
            // txbFechar
            // 
            this.txbFechar.Location = new System.Drawing.Point(621, 181);
            this.txbFechar.Name = "txbFechar";
            this.txbFechar.Size = new System.Drawing.Size(75, 23);
            this.txbFechar.TabIndex = 11;
            this.txbFechar.Text = "Fechar";
            this.txbFechar.UseVisualStyleBackColor = true;
            this.txbFechar.Click += new System.EventHandler(this.txbFechar_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(199, 46);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(225, 20);
            this.mskCPF.TabIndex = 13;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // mskDt
            // 
            this.mskDt.Location = new System.Drawing.Point(480, 46);
            this.mskDt.Mask = "99/99/9999";
            this.mskDt.Name = "mskDt";
            this.mskDt.Size = new System.Drawing.Size(193, 20);
            this.mskDt.TabIndex = 14;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(330, 172);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 214);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mskDt);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txbFechar);
            this.Controls.Add(this.txbExcluir);
            this.Controls.Add(this.txbAlterar);
            this.Controls.Add(this.txbIncluir);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button txbIncluir;
        private System.Windows.Forms.Button txbAlterar;
        private System.Windows.Forms.Button txbExcluir;
        private System.Windows.Forms.Button txbFechar;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskDt;
        private System.Windows.Forms.Button btnConsultar;
    }
}
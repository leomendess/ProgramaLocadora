using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_09_06
{
    public partial class FrmPrincipal : Form
    {
       public FrmPrincipal()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form2 frm2 = new Form2();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroVeiculo FrmCadastroVeiculo = new FrmCadastroVeiculo();
            FrmCadastroVeiculo.MdiParent = this;
            FrmCadastroVeiculo.Show();

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

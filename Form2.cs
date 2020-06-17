using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_09_06
{
    public partial class Form2 : Form
    {
        private object conexão;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            //txtCodigo sempre será desabilitado
            txbCod.Enabled = false;
            //altera a propriedade Enabled dos controles para true, habilitando o controle
            txbNome.Enabled = true;
            mskCPF.Enabled = true;
            mskDt.Enabled = true;
        }
        private void desabilitar()
        {
            //txtCodigo sempre será desabilitado
            txbCod.Enabled = false;

            //altera a propriedade Enabled dos controles para ficarem desabilitados
            txbNome.Enabled = false;
            mskCPF.Enabled = false;
            mskDt.Enabled = false;
        }
        private void limparControles()
        {
            //desabilita o TextBox
            txbCod.Enabled = false;

            //limpa os textos dos TextBox e MaskedTextBox
            txbNome.Clear();
            txbCod.Clear();
            mskCPF.Clear();
            mskDt.Clear();
            //coloca o foco no mskCPF
            mskCPF.Focus();
        }

        //Função para validar os campos de entrada.
        //retorna True ou False
        private bool validaDados()
        {
            //verificar se mskCPF está preenchido, se não estiver preenchido
            if (string.IsNullOrEmpty(mskCPF.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o mskCPF
                mskCPF.Clear();

                //coloca o cursor no mskCPF
                mskCPF.Focus();

                //retorna falso
                return false;
            }

            //verifica se o que foi digitado em data de nascimento é uma data válida 
            DateTime auxData; //variável auxiliar
                              //se não for uma data válida ou se não digitar nenhuma data
            if (!(DateTime.TryParse(mskDt.Text, out auxData)))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o mskDtNasc
                mskDt.Clear();

                //coloca o cursor no mskDtNasc
                mskDt.Focus();

                //retorna falso
                return false;
            }

            //verifica se o txtNome está preenchido, Se for nulo ou vazio retorna falso
            if (string.IsNullOrEmpty(txbNome.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o txtNome
                txbNome.Clear();

                //coloca o cursor no txtNome
                txbNome.Focus();

                //retorna falso
                return false;
            }

            //se todas as validações passaram no teste, retorna verdadeiro
            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            habilitar();
        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIncluir_Click(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(txbCod.Text))
            {
                //se txtCodigo não estiver vazio, significa que já foi consultado um cliente.
                // a instrução a seguir captura se foi clicado o botão Yes (SIM) como resposta da pergunta.
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    limparControles();
                return;   //encerra a sub-rotina
            }

            // antes de incluir é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento para incluir no banco de dados

            if (validaDados() == false)
            {
                return;  //interrompe a sub-rotina
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = aula_09_06.conexão.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "INSERT INTO cliente(nome,data_nasc,cpf) VALUES(@nome,@data_nasc,@cpf)";

            //Tratamento de exceções
            try
            {
                //abre a conexão com o banco de dados
                conCliente.Open();

                //cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txbNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDt.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));

                //executa o commando
                //ExecuteNonQuery envia instruções para o banco de dados que estão em cmd
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                limparControles();
            }
            catch (Exception ex)  // se houve alguma exceção dentro do bloco try
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally  // independente se houve exceção ou não o bloco try é sempre executado
            {
                //se conexão não for nula, fecha conexão
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }

        }

        private void txbExcluir_Click(object sender, EventArgs e)
        {

            //veririfica se tem o código do cliente no txtCodigo
            if (string.IsNullOrEmpty(txbCod.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //solicita confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //declaração da variável para guardar as instruções SQL
                string sqlQuery;

                //cria conexão chamando o método getConnection da classe Conexao
                SqlConnection conCliente = getConnection();

                //cria a instrução sql, parametrizada
                sqlQuery = "DELETE FROM cliente WHERE id_cliente=@id_cliente";

                //Tratamento de exceções
                try
                {
                    conCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                    //define, adiciona os parametros
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txbCod.Text)));

                    //executa o commando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpa os campos para nova entrada de dados
                    limparControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (conCliente != null)
                    {
                        conCliente.Close();
                    }
                }
            }
        }

        private SqlConnection getConnection()
        {
            throw new NotImplementedException();
        }

        private void txbFechar_Click(object sender, EventArgs e)
        
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário de frmConsultaCliente, passando como parâmetro uma referência deste form
            Form3 frm3 = new consultar(this);

            // Define quem é o pai dessa janela
            frm3.MdiParent = this.MdiParent;

            // Exibe o formulário
            frm3.Show();
        }

    }
}
 
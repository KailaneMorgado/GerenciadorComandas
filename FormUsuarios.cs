using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorComandas

    
{ public partial class FormUsuarios : Form
    {
        
        //Objetos globais
        Model.Usuario usuario;

        //construtor
        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
            
        }
        public void AtualizarDgv()
        {
            //Mostrar as informações do bd no datagridview:
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Length <5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length <7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbSenhaCadastro.Text.Length <6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();

                //Salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txbNomeCadastro.Text;
                usuarioCadastro.Email = txbEmailCadastro.Text;
                usuarioCadastro.Senha = txbSenhaCadastro.Text;

                //Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!","Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    AtualizarDgv();

                    //Apagar os campos de cadastro (após cadastrar):
                    txbNomeCadastro.Clear();
                    txbEmailCadastro.Clear();
                    txbSenhaCadastro.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar usuário", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }
    }
}

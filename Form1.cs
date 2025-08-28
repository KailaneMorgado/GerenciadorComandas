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
{
    public partial class fmTelaInicial : Form
    {
        public fmTelaInicial()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Verificar se a pessoa digitou o email e a senha:
            if (txbEmail.Text.Length < 6) //o .length eu vejo quantas letras tem no text box
            {
                MessageBox.Show("Digite um e-mail válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4) 
            {
                MessageBox.Show("Digite uma senha válida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                //Colocar os valores dos campos nos atributos do usuario:
                usuario.Email =txbEmail.Text;
                usuario.Senha =txbSenha.Text;
            }
        }
    }
}

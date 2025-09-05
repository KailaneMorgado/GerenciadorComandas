using GerenciadorComandas.Model;
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
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;

        int IdSelecionado = 0; //Armazenar o ID do produto selecionado para apagar

        public FormProdutos(Model.Usuario usuario)
        {   //construtor
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriasCmb();
            AtualizarDgv();
        }

        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();

            //Tabela p/ receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadastrar.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Length < 2) //se o nome for invalido
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoCadastro.Text == "") //se o preço for invalido
            {
                MessageBox.Show("Nenhum valor adicionado ao preço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaCadastrar.SelectedIndex == -1) //se a categoria for invalida
            {
                MessageBox.Show("Selecione uma opção na categoria!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer o cadastro...
                Model.Produto produtoCadastro = new Model.Produto();

                //Salvar os valores dos campos nos atributos do obj:
                produtoCadastro.Nome = txbNomeCadastro.Text;
                produtoCadastro.Preco = double.Parse(txbPrecoCadastro.Text);
                produtoCadastro.IdRespCadastro = usuario.Id;

                //Para a ID categoria vamos retirar somente o numero do cmb
                produtoCadastro.IdCategoria = int.Parse(cmbCategoriaCadastrar.SelectedItem.ToString().Split(' ')[0]);

                //Executar o INSERT:
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    AtualizarDgv();

                    //Apagar os campos de cadastro (após cadastrar):
                    txbNomeCadastro.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastrar.SelectedIndex = -1; // ficar vazio após cadastrar, com nada selecionado.
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar produto", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void AtualizarDgv()
        {
            //Declarando a variavel pra atualizar o dgv
            Model.Produto produto = new Model.Produto();

            //Mostrar as informações do bd no datagridview:
            dgvProdutos.DataSource = produto.Listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            //Colocar os valores das células nos txb's de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            //Armazenar o ID de quem foi selecionado:
             IdSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            //Ativar o grbEditar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            //Ajustes no grbApagar:
            lblSelecioneApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value.ToString()}";

            //Ativar o grbApagar:
            grbApagar.Enabled = true;
        } 

        public void ResetarCampos()
        {
            //Atualizar o dgv:
            AtualizarDgv();

            //Limpar campos de edição:
            //Apagar os campos de cadastro (após cadastrar):
            txbNomeCadastro.Clear();
            txbPrecoCadastro.Clear();
            cmbCategoriaCadastrar.SelectedIndex = -1; // ficar vazio após cadastrar, com nada selecionado.

            //Retornar o idSelecionado para 0
            IdSelecionado = 0;

            //Retornar o texto padrão do "apagar":
            lblSelecioneApagar.Text = "Selecione o usuário que deseja apagar";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 2) //se o nome for invalido
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoEditar.Text == "") //se o preço for invalido
            {
                MessageBox.Show("Nenhum valor adicionado ao preço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaEditar.SelectedIndex == -1) //se a categoria for invalida
            {
                MessageBox.Show("Selecione uma opção na categoria!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Prosseguir com a edição:
                Model.Produto produtoEditar = new Model.Produto();
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = double.Parse(txbPrecoEditar.Text);
                produtoEditar.IdRespCadastro = usuario.Id;
                produtoEditar.IdCategoria = int.Parse(cmbCategoriaEditar.SelectedItem.ToString().Split(' ')[0]);
                produtoEditar.Id = IdSelecionado;

                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Produto modificado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar produto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                //Prosseguir com a exclusão
                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = IdSelecionado;

                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir produto", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

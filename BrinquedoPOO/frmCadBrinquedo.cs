using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedoPOO
{
    public partial class frmCadBrinquedo : Form
    {
        BrinquedoExecucao brinquedoExec = 
            new BrinquedoExecucao();
        public frmCadBrinquedo()
        {
            InitializeComponent();
        }

        private void AtualizarListBox()
        {
            lstBrinquedos.DataSource = null;
            lstBrinquedos.DataSource =
                brinquedoExec.Listar();
            lstBrinquedos.DisplayMember =
                "CodBarrasDescCatFab";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fabricante fabricante = new Fabricante();
            Produto produto = new Produto();    
            Brinquedo brinquedo = new Brinquedo();

            fabricante.CNPJ = txCNPJ.Text;
            fabricante.Nome = txtNome.Text;

            produto.CodBarras = txtCodBarras.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.Fabricante = fabricante;

            brinquedo.Categoria = txtCategoria.Text;
            brinquedo.IdadeMin = int.Parse(txtIdadeMin.Text);
            brinquedo.Produto = produto;

            brinquedoExec.Adicionar(brinquedo);

            AtualizarListBox();

            txCNPJ.Clear();
            txtNome.Clear();
            txtCodBarras.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtCategoria.Clear();
            txtIdadeMin.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Brinquedo brinquedoSelecionado =
                lstBrinquedos.SelectedItem as Brinquedo;

            //Aqui uma validação de confirmação
            brinquedoExec.Remover(brinquedoSelecionado);

            AtualizarListBox();
        }
    }
}

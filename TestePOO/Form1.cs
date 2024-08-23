using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePOO
{
    public partial class Form1 : Form
    {
        //Criamos a classe Pessoa
        public class Pessoa
        {
            //Definos os atributos
            //O atributo é divido em 4 partes
            //Nivel de Acesso: Public ou Private
            //Tipo de Dado: Int, String, ...
            //O Nome: Nome, CPF, Altura...
            //Modificadore: Get/Set
            public string Nome { get; set; }
            //O VS possui o atalho PROP
            public string CPF { get; set; }
            public DateTime DtNascimento { get; set; }

            //vamos criar um construtor, para definir
            //o valor padrão de cada atributo
            public Pessoa()
            {
                Nome = "Desconhecido";
                CPF = "00000000000";
                DtNascimento = DateTime.Now;
            }

            public string CPFNome 
            {
                get
                {
                    return CPF + " - " +
                            Nome.ToUpper();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        Pessoa pessoaBKP = new Pessoa();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa instancia = new Pessoa();
            instancia.Nome = txtNome.Text;
            instancia.CPF = txtCPF.Text;
            instancia.DtNascimento = 
                dtpDtNascimento.Value;

            pessoaBKP = instancia;

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            txtVisNome.Text = pessoaBKP.Nome;
            txtVisCPF.Text = pessoaBKP.CPF;
            txtVisDtNascimento.Text =
                pessoaBKP.DtNascimento.
                ToShortDateString();

            lblCPFNome.Text = pessoaBKP.CPFNome;
        }
    }
}

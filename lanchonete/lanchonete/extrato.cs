using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanchonete
{
    public partial class extrato : Form
    {
        private object totalpedido;

        public extrato(string nome, string telefone, decimal totalpedido, string listaitens,string avaliacao)
        {
            InitializeComponent();


            lbl_nome.Text = nome;

            lbl_tel.Text = telefone;

            lbl_listaprodutos.Text = listaitens;


            lbl_nota.Text = avaliacao;


            lbl_total.Text = totalpedido.ToString("C2");


         









        }

        private void extrato_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_listaprodutos_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace lanchonete
{
    public partial class Form1 : Form
    {
        string nome;
        string telefone;
        private decimal valor;


        string itensescolhido = " "; 


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
            checkedListBox2.Visible = false;
            lb_lanches.Visible = false;
            lb_adicionais.Visible = false;
            checkedListBox3.Visible = false;
            lb_bebidas.Visible = false;
            lb_doce.Visible = false;
            checkedListBox4.Visible = false;
            lbl_nome.Visible = false;
            txt_nome.Visible = false;
            lbl_telefone.Visible = false;
            txt_telefone.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
        }

        private void lANCHESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;
            lb_lanches.Visible = true;
        }

        private void aDICIONAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedListBox2.Visible = true;
            lb_adicionais.Visible = true;
        }

        private void bEBIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedListBox3.Visible = true;
            lb_bebidas.Visible = true;

        }

        private void sOBREMESASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedListBox4.Visible = true;
            lb_doce.Visible = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = checkedListBox1.ToString();
            string[] dados = item.Split("|");
            string nome = dados[0];
            decimal preco = Convert.ToDecimal(dados[1]);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = checkedListBox2.ToString();
            string[] dados = item.Split("|");
            string nome = dados[0];
            decimal preco = Convert.ToDecimal(dados[1]);
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = checkedListBox3.ToString();
            string[] dados = item.Split("|");
            string nome = dados[0];
            decimal preco = Convert.ToDecimal(dados[1]);
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = checkedListBox4.ToString();
            string[] dados = item.Split("|");
            string nome = dados[0];
            decimal preco = Convert.ToDecimal(dados[1]);
        }



        private void btn_registrar_Click(object sender, EventArgs e)
        {
            lbl_nome.Visible = true;
            txt_nome.Visible = true;
            lbl_telefone.Visible = true;
            txt_telefone.Visible = true;



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_extrato_Click(object sender, EventArgs e)
        {
            nome = txt_nome.Text;
            telefone = txt_telefone.Text;

            decimal totalGeral = 0;

            CheckedListBox[] todasAsListas = { checkedListBox1, checkedListBox2, checkedListBox3, checkedListBox4 };

            // 4. "Para cada" lista, vamos olhar os itens marcados
            foreach (var lista in todasAsListas)
            {
                foreach (var item in lista.CheckedItems)
                {
                    // Transforma o item selecionado em texto (Ex: "Hambúrguer|15,50")
                    string textoDoItem = item.ToString();
                    string[] partes = textoDoItem.Split('|');

                    if (partes.Length > 1)
                    {

                        totalGeral += Convert.ToDecimal(partes[1]);

                        itensescolhido += partes[0] + "\n";










                    }
                    
                }
            }

            string nota = "Sem nota";
            if (comboBox1.SelectedItem != null)
            {
                nota = comboBox1.SelectedItem.ToString();
            }

            extrato telaextrato = new extrato(nome, telefone, totalGeral,itensescolhido,nota);
            telaextrato.Show();
        }

        private void avaliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
      
}






















































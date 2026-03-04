namespace lanchonete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            lANCHESToolStripMenuItem = new ToolStripMenuItem();
            aDICIONAISToolStripMenuItem = new ToolStripMenuItem();
            bEBIDASToolStripMenuItem = new ToolStripMenuItem();
            sOBREMESASToolStripMenuItem = new ToolStripMenuItem();
            avaliarToolStripMenuItem = new ToolStripMenuItem();
            checkedListBox1 = new CheckedListBox();
            lb_lanches = new Label();
            lb_adicionais = new Label();
            checkedListBox2 = new CheckedListBox();
            lb_bebidas = new Label();
            checkedListBox3 = new CheckedListBox();
            lb_doce = new Label();
            checkedListBox4 = new CheckedListBox();
            btn_registrar = new Button();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            lbl_telefone = new Label();
            txt_telefone = new TextBox();
            btn_extrato = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lANCHESToolStripMenuItem, aDICIONAISToolStripMenuItem, bEBIDASToolStripMenuItem, sOBREMESASToolStripMenuItem, avaliarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1192, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // lANCHESToolStripMenuItem
            // 
            lANCHESToolStripMenuItem.Name = "lANCHESToolStripMenuItem";
            lANCHESToolStripMenuItem.Size = new Size(71, 20);
            lANCHESToolStripMenuItem.Text = "LANCHES";
            lANCHESToolStripMenuItem.Click += lANCHESToolStripMenuItem_Click;
            // 
            // aDICIONAISToolStripMenuItem
            // 
            aDICIONAISToolStripMenuItem.Name = "aDICIONAISToolStripMenuItem";
            aDICIONAISToolStripMenuItem.Size = new Size(84, 20);
            aDICIONAISToolStripMenuItem.Text = "ADICIONAIS";
            aDICIONAISToolStripMenuItem.Click += aDICIONAISToolStripMenuItem_Click;
            // 
            // bEBIDASToolStripMenuItem
            // 
            bEBIDASToolStripMenuItem.Name = "bEBIDASToolStripMenuItem";
            bEBIDASToolStripMenuItem.Size = new Size(64, 20);
            bEBIDASToolStripMenuItem.Text = "BEBIDAS";
            bEBIDASToolStripMenuItem.Click += bEBIDASToolStripMenuItem_Click;
            // 
            // sOBREMESASToolStripMenuItem
            // 
            sOBREMESASToolStripMenuItem.Name = "sOBREMESASToolStripMenuItem";
            sOBREMESASToolStripMenuItem.Size = new Size(91, 20);
            sOBREMESASToolStripMenuItem.Text = "SOBREMESAS";
            sOBREMESASToolStripMenuItem.Click += sOBREMESASToolStripMenuItem_Click;
            // 
            // avaliarToolStripMenuItem
            // 
            avaliarToolStripMenuItem.Name = "avaliarToolStripMenuItem";
            avaliarToolStripMenuItem.Size = new Size(55, 20);
            avaliarToolStripMenuItem.Text = "Avaliar";
            avaliarToolStripMenuItem.Click += avaliarToolStripMenuItem_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Menu;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pastel Carne|7,00", "Pastel Frango|7,00", "Pastel Queijo|7,00", "Pastel Bacon|8,00", "X-Tudão|20,00", "X-Churrasco|30,00", "X-Egg|20,00", "X-Casa|50,00", "Pizza Peperone|60,00", "Pizza Brocolis|55,00", "Pizza Camarao|70,00", "Pizza Portuguesa|100,00", "Pizza Strogonof|75,00", "Pizza Doritos|80,00" });
            checkedListBox1.Location = new Point(302, 99);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(161, 256);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lb_lanches
            // 
            lb_lanches.AutoSize = true;
            lb_lanches.BackColor = Color.White;
            lb_lanches.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_lanches.ForeColor = SystemColors.InfoText;
            lb_lanches.Location = new Point(313, 64);
            lb_lanches.Name = "lb_lanches";
            lb_lanches.Size = new Size(141, 32);
            lb_lanches.TabIndex = 2;
            lb_lanches.Text = "LANCHES";
            // 
            // lb_adicionais
            // 
            lb_adicionais.AutoSize = true;
            lb_adicionais.BackColor = Color.White;
            lb_adicionais.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_adicionais.ForeColor = SystemColors.InfoText;
            lb_adicionais.Location = new Point(482, 64);
            lb_adicionais.Name = "lb_adicionais";
            lb_adicionais.Size = new Size(182, 32);
            lb_adicionais.TabIndex = 3;
            lb_adicionais.Text = "ADICIONAIS";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Queijo|3,00", "Presunto|3,50", "Ovo|2,50", "Calabresa|4,50", "Milho|2,00", "Ervilha|2,00", "Catupiry|4,00", "Cheddar|4,00", "Bacon Extra|5,00", "Carne|6,00", "Frango|5,50", "Tomate|2,00", "Alface|1,50", "Batata Palha|3,00" });
            checkedListBox2.Location = new Point(482, 99);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(182, 256);
            checkedListBox2.TabIndex = 4;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // lb_bebidas
            // 
            lb_bebidas.AutoSize = true;
            lb_bebidas.BackColor = Color.White;
            lb_bebidas.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_bebidas.ForeColor = SystemColors.InfoText;
            lb_bebidas.Location = new Point(719, 64);
            lb_bebidas.Name = "lb_bebidas";
            lb_bebidas.Size = new Size(137, 32);
            lb_bebidas.TabIndex = 5;
            lb_bebidas.Text = "BEBIDAS";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Coca-Cola Lata|5,00", "Guaraná Lata|5,00", "Fanta Lata|5,00", "Sprite Lata|5,00", "Coca-Cola 2L|12,00", "Guaraná 2L|12,00", "Refrigerante Lata|5,00", "Água Mineral|3,00", "Água com Gás|4,00", "Suco Laranja|6,00", "Suco Uva|6,00", "Suco Maracujá|6,00", "Chá Gelado|5,00", "Energético Lata|9,00" });
            checkedListBox3.Location = new Point(719, 99);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(178, 256);
            checkedListBox3.TabIndex = 6;
            checkedListBox3.SelectedIndexChanged += checkedListBox3_SelectedIndexChanged;
            // 
            // lb_doce
            // 
            lb_doce.AutoSize = true;
            lb_doce.BackColor = Color.White;
            lb_doce.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_doce.ForeColor = SystemColors.InfoText;
            lb_doce.Location = new Point(960, 64);
            lb_doce.Name = "lb_doce";
            lb_doce.Size = new Size(110, 32);
            lb_doce.TabIndex = 7;
            lb_doce.Text = "DOCES";
            // 
            // checkedListBox4
            // 
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "Brigadeiro|3,00", "Beijinho|3,00", "Pudim|6,00", "Mousse Chocolate|7,00", "Mousse Maracujá|7,00", "Torta de Limão|9,00", "Torta de Chocolate|9,00", "Brownie|8,00", "Churros|6,00", "Petit Gateau|12,00", "Sorvete 1 Bola|5,00", "Sorvete 2 Bolas|8,00", "Açaí 300ml|10,00", "Açaí 500ml|14,00" });
            checkedListBox4.Location = new Point(932, 99);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(185, 256);
            checkedListBox4.TabIndex = 8;
            checkedListBox4.SelectedIndexChanged += checkedListBox4_SelectedIndexChanged;
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.Black;
            btn_registrar.FlatAppearance.BorderSize = 0;
            btn_registrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.Transparent;
            btn_registrar.Location = new Point(24, 64);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(126, 29);
            btn_registrar.TabIndex = 10;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(12, 121);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(84, 32);
            lbl_nome.TabIndex = 11;
            lbl_nome.Text = "NOME";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(12, 170);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(257, 23);
            txt_nome.TabIndex = 12;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_telefone.Location = new Point(12, 240);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(122, 32);
            lbl_telefone.TabIndex = 13;
            lbl_telefone.Text = "TELEFONE";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(12, 275);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(257, 23);
            txt_telefone.TabIndex = 14;
            // 
            // btn_extrato
            // 
            btn_extrato.Location = new Point(1005, 439);
            btn_extrato.Name = "btn_extrato";
            btn_extrato.Size = new Size(187, 54);
            btn_extrato.TabIndex = 15;
            btn_extrato.Text = "IR EXTRATO";
            btn_extrato.UseVisualStyleBackColor = true;
            btn_extrato.Click += btn_extrato_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RUIM", "MAIS OU MENOS", "BOM ", "OTIMO", "EXELENTE" });
            comboBox1.Location = new Point(620, 394);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 376);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 17;
            label1.Text = "Avaliar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1192, 505);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btn_extrato);
            Controls.Add(txt_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(btn_registrar);
            Controls.Add(checkedListBox4);
            Controls.Add(lb_doce);
            Controls.Add(checkedListBox3);
            Controls.Add(lb_bebidas);
            Controls.Add(checkedListBox2);
            Controls.Add(lb_adicionais);
            Controls.Add(lb_lanches);
            Controls.Add(checkedListBox1);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lANCHESToolStripMenuItem;
        private ToolStripMenuItem aDICIONAISToolStripMenuItem;
        private ToolStripMenuItem bEBIDASToolStripMenuItem;
        private ToolStripMenuItem sOBREMESASToolStripMenuItem;
        private CheckedListBox checkedListBox1;
        private Label lb_lanches;
        private Label lb_adicionais;
        private CheckedListBox checkedListBox2;
        private Label lb_bebidas;
        private CheckedListBox checkedListBox3;
        private Label lb_doce;
        private CheckedListBox checkedListBox4;
        private Button btn_registrar;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Label lbl_telefone;
        private TextBox txt_telefone;
        private Button btn_extrato;
        private ToolStripMenuItem avaliarToolStripMenuItem;
        private ComboBox comboBox1;
        private Label label1;
    }
}

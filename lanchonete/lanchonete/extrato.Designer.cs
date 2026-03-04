namespace lanchonete
{
    partial class extrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(extrato));
            lbl_nome = new Label();
            lbl_tel = new Label();
            lbl_listaprodutos = new Label();
            lbl_total = new Label();
            lbl_nota = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(28, 186);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(63, 25);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "label1";
            // 
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tel.ForeColor = Color.White;
            lbl_tel.Location = new Point(28, 250);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new Size(63, 25);
            lbl_tel.TabIndex = 1;
            lbl_tel.Text = "label1";
            // 
            // lbl_listaprodutos
            // 
            lbl_listaprodutos.AutoSize = true;
            lbl_listaprodutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_listaprodutos.ForeColor = Color.White;
            lbl_listaprodutos.Location = new Point(28, 313);
            lbl_listaprodutos.Name = "lbl_listaprodutos";
            lbl_listaprodutos.Size = new Size(63, 25);
            lbl_listaprodutos.TabIndex = 2;
            lbl_listaprodutos.Text = "label1";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_total.ForeColor = Color.White;
            lbl_total.Location = new Point(459, 492);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(63, 25);
            lbl_total.TabIndex = 3;
            lbl_total.Text = "label1";
            // 
            // lbl_nota
            // 
            lbl_nota.AutoSize = true;
            lbl_nota.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nota.ForeColor = Color.White;
            lbl_nota.Location = new Point(28, 463);
            lbl_nota.Name = "lbl_nota";
            lbl_nota.Size = new Size(63, 25);
            lbl_nota.TabIndex = 4;
            lbl_nota.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 408);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 5;
            label1.Text = "AVALIAÇÃO";
            // 
            // extrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 561);
            Controls.Add(label1);
            Controls.Add(lbl_nota);
            Controls.Add(lbl_total);
            Controls.Add(lbl_listaprodutos);
            Controls.Add(lbl_tel);
            Controls.Add(lbl_nome);
            DoubleBuffered = true;
            Name = "extrato";
            Text = "extrato";
            Load += extrato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_tel;
        private Label lbl_listaprodutos;
        private Label lbl_total;
        private Label lbl_nota;
        private Label label1;
    }
}
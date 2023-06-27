namespace Locadora.View
{
    partial class janelaFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenFilme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.txtProdFilme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstreiaFilme = new System.Windows.Forms.TextBox();
            this.btnCadastrarFilme = new System.Windows.Forms.Button();
            this.btnVoltarFilme = new System.Windows.Forms.Button();
            this.lblStatusFilme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Filme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produtora do Filme";
            // 
            // cbGenFilme
            // 
            this.cbGenFilme.FormattingEnabled = true;
            this.cbGenFilme.Items.AddRange(new object[] {
            "Romance",
            "Ação",
            "Suspense",
            "Terror",
            "Comédia",
            "Fantasia",
            "Outro"});
            this.cbGenFilme.Location = new System.Drawing.Point(177, 58);
            this.cbGenFilme.Name = "cbGenFilme";
            this.cbGenFilme.Size = new System.Drawing.Size(121, 23);
            this.cbGenFilme.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gênero do Filme";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(35, 58);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(100, 23);
            this.txtNomeFilme.TabIndex = 4;
            // 
            // txtProdFilme
            // 
            this.txtProdFilme.Location = new System.Drawing.Point(35, 126);
            this.txtProdFilme.Name = "txtProdFilme";
            this.txtProdFilme.Size = new System.Drawing.Size(100, 23);
            this.txtProdFilme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estreia do Filme";
            // 
            // txtEstreiaFilme
            // 
            this.txtEstreiaFilme.Location = new System.Drawing.Point(184, 126);
            this.txtEstreiaFilme.Name = "txtEstreiaFilme";
            this.txtEstreiaFilme.Size = new System.Drawing.Size(114, 23);
            this.txtEstreiaFilme.TabIndex = 7;
            // 
            // btnCadastrarFilme
            // 
            this.btnCadastrarFilme.Location = new System.Drawing.Point(177, 193);
            this.btnCadastrarFilme.Name = "btnCadastrarFilme";
            this.btnCadastrarFilme.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarFilme.TabIndex = 8;
            this.btnCadastrarFilme.Text = "Cadastrar";
            this.btnCadastrarFilme.UseVisualStyleBackColor = true;
            // 
            // btnVoltarFilme
            // 
            this.btnVoltarFilme.Location = new System.Drawing.Point(69, 193);
            this.btnVoltarFilme.Name = "btnVoltarFilme";
            this.btnVoltarFilme.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFilme.TabIndex = 9;
            this.btnVoltarFilme.Text = "Voltar";
            this.btnVoltarFilme.UseVisualStyleBackColor = true;
            this.btnVoltarFilme.Click += new System.EventHandler(this.btnVoltarFilme_Click);
            // 
            // lblStatusFilme
            // 
            this.lblStatusFilme.AutoSize = true;
            this.lblStatusFilme.Location = new System.Drawing.Point(121, 235);
            this.lblStatusFilme.Name = "lblStatusFilme";
            this.lblStatusFilme.Size = new System.Drawing.Size(0, 15);
            this.lblStatusFilme.TabIndex = 10;
            // 
            // janelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 264);
            this.Controls.Add(this.lblStatusFilme);
            this.Controls.Add(this.btnVoltarFilme);
            this.Controls.Add(this.btnCadastrarFilme);
            this.Controls.Add(this.txtEstreiaFilme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdFilme);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGenFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "janelaFilme";
            this.ShowIcon = false;
            this.Text = "Cadastrar Filme >>>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbGenFilme;
        private Label label3;
        private TextBox txtNomeFilme;
        private TextBox txtProdFilme;
        private Label label4;
        private TextBox txtEstreiaFilme;
        private Button btnCadastrarFilme;
        private Button btnVoltarFilme;
        private Label lblStatusFilme;
    }
}
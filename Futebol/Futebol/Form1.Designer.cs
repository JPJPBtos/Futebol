namespace Futebol
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.btnRecuperado = new System.Windows.Forms.Button();
            this.btnRetiraJogo = new System.Windows.Forms.Button();
            this.btnMachucado = new System.Windows.Forms.Button();
            this.btnAdicionaJogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lstConfirmados = new System.Windows.Forms.ListBox();
            this.lstMachucados = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimparListaJogadores = new System.Windows.Forms.Button();
            this.btnLimparMachucado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Location = new System.Drawing.Point(157, 28);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(75, 23);
            this.btnAdiciona.TabIndex = 0;
            this.btnAdiciona.Text = "Adiciona";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnRecuperado
            // 
            this.btnRecuperado.Location = new System.Drawing.Point(254, 294);
            this.btnRecuperado.Name = "btnRecuperado";
            this.btnRecuperado.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperado.TabIndex = 1;
            this.btnRecuperado.Text = "<";
            this.btnRecuperado.UseVisualStyleBackColor = true;
            this.btnRecuperado.Click += new System.EventHandler(this.btnRecuperado_Click);
            // 
            // btnRetiraJogo
            // 
            this.btnRetiraJogo.Location = new System.Drawing.Point(254, 124);
            this.btnRetiraJogo.Name = "btnRetiraJogo";
            this.btnRetiraJogo.Size = new System.Drawing.Size(75, 23);
            this.btnRetiraJogo.TabIndex = 2;
            this.btnRetiraJogo.Text = "<";
            this.btnRetiraJogo.UseVisualStyleBackColor = true;
            this.btnRetiraJogo.Click += new System.EventHandler(this.btnRetiraJogo_Click);
            // 
            // btnMachucado
            // 
            this.btnMachucado.Location = new System.Drawing.Point(254, 248);
            this.btnMachucado.Name = "btnMachucado";
            this.btnMachucado.Size = new System.Drawing.Size(75, 23);
            this.btnMachucado.TabIndex = 3;
            this.btnMachucado.Text = ">";
            this.btnMachucado.UseVisualStyleBackColor = true;
            this.btnMachucado.Click += new System.EventHandler(this.btnMachucado_Click);
            // 
            // btnAdicionaJogo
            // 
            this.btnAdicionaJogo.Location = new System.Drawing.Point(254, 95);
            this.btnAdicionaJogo.Name = "btnAdicionaJogo";
            this.btnAdicionaJogo.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionaJogo.TabIndex = 4;
            this.btnAdicionaJogo.Text = ">";
            this.btnAdicionaJogo.UseVisualStyleBackColor = true;
            this.btnAdicionaJogo.Click += new System.EventHandler(this.btnAdicionaJogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jogadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Machucados";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(12, 73);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(220, 368);
            this.lstJogadores.TabIndex = 9;
            this.lstJogadores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstJogadores_MouseDoubleClick);
            // 
            // lstConfirmados
            // 
            this.lstConfirmados.FormattingEnabled = true;
            this.lstConfirmados.Location = new System.Drawing.Point(391, 79);
            this.lstConfirmados.Name = "lstConfirmados";
            this.lstConfirmados.Size = new System.Drawing.Size(169, 121);
            this.lstConfirmados.TabIndex = 10;
            // 
            // lstMachucados
            // 
            this.lstMachucados.FormattingEnabled = true;
            this.lstMachucados.Location = new System.Drawing.Point(391, 259);
            this.lstMachucados.Name = "lstMachucados";
            this.lstMachucados.Size = new System.Drawing.Size(169, 134);
            this.lstMachucados.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 20);
            this.txtNome.TabIndex = 12;
            // 
            // btnLimparListaJogadores
            // 
            this.btnLimparListaJogadores.Location = new System.Drawing.Point(12, 455);
            this.btnLimparListaJogadores.Name = "btnLimparListaJogadores";
            this.btnLimparListaJogadores.Size = new System.Drawing.Size(75, 23);
            this.btnLimparListaJogadores.TabIndex = 13;
            this.btnLimparListaJogadores.Text = "Limpar Lista";
            this.btnLimparListaJogadores.UseVisualStyleBackColor = true;
            this.btnLimparListaJogadores.Click += new System.EventHandler(this.btnLimparListaJogadores_Click);
            // 
            // btnLimparMachucado
            // 
            this.btnLimparMachucado.Location = new System.Drawing.Point(391, 399);
            this.btnLimparMachucado.Name = "btnLimparMachucado";
            this.btnLimparMachucado.Size = new System.Drawing.Size(117, 23);
            this.btnLimparMachucado.TabIndex = 14;
            this.btnLimparMachucado.Text = "Limpar Machucados";
            this.btnLimparMachucado.UseVisualStyleBackColor = true;
            this.btnLimparMachucado.Click += new System.EventHandler(this.btnLimparMachucado_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdiciona;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnLimparMachucado);
            this.Controls.Add(this.btnLimparListaJogadores);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lstMachucados);
            this.Controls.Add(this.lstConfirmados);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionaJogo);
            this.Controls.Add(this.btnMachucado);
            this.Controls.Add(this.btnRetiraJogo);
            this.Controls.Add(this.btnRecuperado);
            this.Controls.Add(this.btnAdiciona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Button btnRecuperado;
        private System.Windows.Forms.Button btnRetiraJogo;
        private System.Windows.Forms.Button btnMachucado;
        private System.Windows.Forms.Button btnAdicionaJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.ListBox lstConfirmados;
        private System.Windows.Forms.ListBox lstMachucados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimparListaJogadores;
        private System.Windows.Forms.Button btnLimparMachucado;
    }
}


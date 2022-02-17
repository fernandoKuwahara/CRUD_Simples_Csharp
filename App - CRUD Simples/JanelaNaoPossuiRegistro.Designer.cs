
namespace App___CRUD_Simples
{
    partial class JanelaNaoPossuiRegistro
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
            this.txtNomeDeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailDeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaDoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crie Sua Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome De Usuário:";
            // 
            // txtNomeDeUsuario
            // 
            this.txtNomeDeUsuario.Location = new System.Drawing.Point(101, 148);
            this.txtNomeDeUsuario.Name = "txtNomeDeUsuario";
            this.txtNomeDeUsuario.Size = new System.Drawing.Size(275, 23);
            this.txtNomeDeUsuario.TabIndex = 2;
            this.txtNomeDeUsuario.TextChanged += new System.EventHandler(this.txtNomeDeUsuario_TextChanged);
            // 
            // txtEmailDeUsuario
            // 
            this.txtEmailDeUsuario.Location = new System.Drawing.Point(101, 213);
            this.txtEmailDeUsuario.Name = "txtEmailDeUsuario";
            this.txtEmailDeUsuario.Size = new System.Drawing.Size(275, 23);
            this.txtEmailDeUsuario.TabIndex = 3;
            // 
            // txtSenhaDoUsuario
            // 
            this.txtSenhaDoUsuario.Location = new System.Drawing.Point(101, 276);
            this.txtSenhaDoUsuario.Name = "txtSenhaDoUsuario";
            this.txtSenhaDoUsuario.PasswordChar = '*';
            this.txtSenhaDoUsuario.Size = new System.Drawing.Size(275, 23);
            this.txtSenhaDoUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Do Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(101, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha Do Usuário:";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Enabled = false;
            this.btnCriarConta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCriarConta.Location = new System.Drawing.Point(101, 334);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(275, 48);
            this.btnCriarConta.TabIndex = 7;
            this.btnCriarConta.Text = "CRIAR CONTA";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(344, 420);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 39);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // JanelaNaoPossuiRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 471);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaDoUsuario);
            this.Controls.Add(this.txtEmailDeUsuario);
            this.Controls.Add(this.txtNomeDeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JanelaNaoPossuiRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App - CRUD Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaNaoPossuiRegistro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDeUsuario;
        private System.Windows.Forms.TextBox txtEmailDeUsuario;
        private System.Windows.Forms.TextBox txtSenhaDoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnVoltar;
    }
}
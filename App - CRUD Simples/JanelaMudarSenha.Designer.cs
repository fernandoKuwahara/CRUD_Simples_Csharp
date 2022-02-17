
namespace App___CRUD_Simples
{
    partial class JanelaMudarSenha
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
            this.txtEmailDoUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenhaNova = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMudarSenha = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mudar Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Do Usuário:";
            // 
            // txtEmailDoUsuario
            // 
            this.txtEmailDoUsuario.Location = new System.Drawing.Point(102, 144);
            this.txtEmailDoUsuario.Name = "txtEmailDoUsuario";
            this.txtEmailDoUsuario.Size = new System.Drawing.Size(275, 23);
            this.txtEmailDoUsuario.TabIndex = 2;
            this.txtEmailDoUsuario.TextChanged += new System.EventHandler(this.txtEmailDoUsuario_TextChanged);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(102, 208);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '*';
            this.txtSenhaNova.Size = new System.Drawing.Size(275, 23);
            this.txtSenhaNova.TabIndex = 3;
            // 
            // txtConfirmarSenhaNova
            // 
            this.txtConfirmarSenhaNova.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmarSenhaNova.Location = new System.Drawing.Point(102, 278);
            this.txtConfirmarSenhaNova.Name = "txtConfirmarSenhaNova";
            this.txtConfirmarSenhaNova.PasswordChar = '*';
            this.txtConfirmarSenhaNova.Size = new System.Drawing.Size(275, 23);
            this.txtConfirmarSenhaNova.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha Nova:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(102, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar Nova Senha:";
            // 
            // btnMudarSenha
            // 
            this.btnMudarSenha.Enabled = false;
            this.btnMudarSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMudarSenha.Location = new System.Drawing.Point(102, 332);
            this.btnMudarSenha.Name = "btnMudarSenha";
            this.btnMudarSenha.Size = new System.Drawing.Size(275, 42);
            this.btnMudarSenha.TabIndex = 7;
            this.btnMudarSenha.Text = "MUDAR SENHA";
            this.btnMudarSenha.UseVisualStyleBackColor = true;
            this.btnMudarSenha.Click += new System.EventHandler(this.btnMudarSenha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(343, 419);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 40);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // JanelaMudarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 471);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMudarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmarSenhaNova);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.txtEmailDoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JanelaMudarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App - CRUD Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaMudarSenha_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailDoUsuario;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.TextBox txtConfirmarSenhaNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMudarSenha;
        private System.Windows.Forms.Button btnVoltar;
    }
}
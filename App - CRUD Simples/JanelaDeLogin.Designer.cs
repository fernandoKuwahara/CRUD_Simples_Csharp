
namespace App___CRUD_Simples
{
    partial class JanelaDeLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFazerLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEsqueceuSuaSenha = new System.Windows.Forms.LinkLabel();
            this.lblAindaNaoPossuiRegistro = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Janela De Login:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(121, 249);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(239, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(121, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // btnFazerLogin
            // 
            this.btnFazerLogin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFazerLogin.Location = new System.Drawing.Point(121, 309);
            this.btnFazerLogin.Name = "btnFazerLogin";
            this.btnFazerLogin.Size = new System.Drawing.Size(239, 40);
            this.btnFazerLogin.TabIndex = 5;
            this.btnFazerLogin.Text = "ENTRAR";
            this.btnFazerLogin.UseVisualStyleBackColor = true;
            this.btnFazerLogin.Click += new System.EventHandler(this.btnFazerLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(121, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esqueceu Sua Senha?";
            // 
            // lblEsqueceuSuaSenha
            // 
            this.lblEsqueceuSuaSenha.AutoSize = true;
            this.lblEsqueceuSuaSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEsqueceuSuaSenha.Location = new System.Drawing.Point(282, 377);
            this.lblEsqueceuSuaSenha.Name = "lblEsqueceuSuaSenha";
            this.lblEsqueceuSuaSenha.Size = new System.Drawing.Size(87, 19);
            this.lblEsqueceuSuaSenha.TabIndex = 7;
            this.lblEsqueceuSuaSenha.TabStop = true;
            this.lblEsqueceuSuaSenha.Text = "Clique Aqui";
            this.lblEsqueceuSuaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceuSuaSenha_LinkClicked);
            // 
            // lblAindaNaoPossuiRegistro
            // 
            this.lblAindaNaoPossuiRegistro.AutoSize = true;
            this.lblAindaNaoPossuiRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAindaNaoPossuiRegistro.Location = new System.Drawing.Point(300, 418);
            this.lblAindaNaoPossuiRegistro.Name = "lblAindaNaoPossuiRegistro";
            this.lblAindaNaoPossuiRegistro.Size = new System.Drawing.Size(87, 19);
            this.lblAindaNaoPossuiRegistro.TabIndex = 9;
            this.lblAindaNaoPossuiRegistro.TabStop = true;
            this.lblAindaNaoPossuiRegistro.Text = "Clique Aqui";
            this.lblAindaNaoPossuiRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAindaNaoPossuiRegistro_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(99, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ainda Não Possui Registro?";
            // 
            // JanelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 471);
            this.Controls.Add(this.lblAindaNaoPossuiRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEsqueceuSuaSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFazerLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "JanelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App - CRUD Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaDeLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFazerLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblEsqueceuSuaSenha;
        private System.Windows.Forms.LinkLabel lblAindaNaoPossuiRegistro;
        private System.Windows.Forms.Label label5;
    }
}


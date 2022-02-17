
namespace App___CRUD_Simples
{
    partial class JanelaDeletarConta
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
            this.lblNumeroDeConfirmacao = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnConfirmarNumero = new System.Windows.Forms.Button();
            this.txtNumeroDeConfirmacao = new System.Windows.Forms.TextBox();
            this.btnDeletarConta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deletar Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tem Certeza Mesmo Que Deseja Deletar Sua Conta?";
            // 
            // lblNumeroDeConfirmacao
            // 
            this.lblNumeroDeConfirmacao.AutoSize = true;
            this.lblNumeroDeConfirmacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDeConfirmacao.Location = new System.Drawing.Point(342, 234);
            this.lblNumeroDeConfirmacao.Name = "lblNumeroDeConfirmacao";
            this.lblNumeroDeConfirmacao.Size = new System.Drawing.Size(0, 19);
            this.lblNumeroDeConfirmacao.TabIndex = 3;
            // 
            // btnSim
            // 
            this.btnSim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSim.Location = new System.Drawing.Point(57, 172);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(166, 41);
            this.btnSim.TabIndex = 4;
            this.btnSim.Text = "SIM";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNao.Location = new System.Drawing.Point(250, 172);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(166, 41);
            this.btnNao.TabIndex = 5;
            this.btnNao.Text = "NÃO";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnConfirmarNumero
            // 
            this.btnConfirmarNumero.Enabled = false;
            this.btnConfirmarNumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarNumero.Location = new System.Drawing.Point(250, 272);
            this.btnConfirmarNumero.Name = "btnConfirmarNumero";
            this.btnConfirmarNumero.Size = new System.Drawing.Size(166, 41);
            this.btnConfirmarNumero.TabIndex = 6;
            this.btnConfirmarNumero.Text = "Confirmar";
            this.btnConfirmarNumero.UseVisualStyleBackColor = true;
            this.btnConfirmarNumero.Click += new System.EventHandler(this.btnConfirmarNumero_Click);
            // 
            // txtNumeroDeConfirmacao
            // 
            this.txtNumeroDeConfirmacao.Enabled = false;
            this.txtNumeroDeConfirmacao.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroDeConfirmacao.Location = new System.Drawing.Point(57, 272);
            this.txtNumeroDeConfirmacao.MaxLength = 3;
            this.txtNumeroDeConfirmacao.Multiline = true;
            this.txtNumeroDeConfirmacao.Name = "txtNumeroDeConfirmacao";
            this.txtNumeroDeConfirmacao.Size = new System.Drawing.Size(166, 41);
            this.txtNumeroDeConfirmacao.TabIndex = 7;
            this.txtNumeroDeConfirmacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroDeConfirmacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDeConfirmacao_KeyPress);
            // 
            // btnDeletarConta
            // 
            this.btnDeletarConta.Enabled = false;
            this.btnDeletarConta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarConta.Location = new System.Drawing.Point(57, 366);
            this.btnDeletarConta.Name = "btnDeletarConta";
            this.btnDeletarConta.Size = new System.Drawing.Size(359, 41);
            this.btnDeletarConta.TabIndex = 8;
            this.btnDeletarConta.Text = "DELETAR CONTA";
            this.btnDeletarConta.UseVisualStyleBackColor = true;
            this.btnDeletarConta.Click += new System.EventHandler(this.btnDeletarConta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digite O Número Que Aparece A seguir:";
            // 
            // JanelaDeletarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeletarConta);
            this.Controls.Add(this.txtNumeroDeConfirmacao);
            this.Controls.Add(this.btnConfirmarNumero);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblNumeroDeConfirmacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JanelaDeletarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App - CRUD Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaDeletarConta_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroDeConfirmacao;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnConfirmarNumero;
        private System.Windows.Forms.TextBox txtNumeroDeConfirmacao;
        private System.Windows.Forms.Button btnDeletarConta;
        private System.Windows.Forms.Label label3;
    }
}
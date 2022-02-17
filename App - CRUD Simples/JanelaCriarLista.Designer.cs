
namespace App___CRUD_Simples
{
    partial class Form1
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
            this.txtNomeDoItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidadeDoItem = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoDoItem = new System.Windows.Forms.TextBox();
            this.lstSacolaDeItens = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnColocarNaLista = new System.Windows.Forms.Button();
            this.btnEsvaziarLista = new System.Windows.Forms.Button();
            this.btnFinalizarLista = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQuantidadeDeItens = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrecoFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeDoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crie Sua Lista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Do Item:";
            // 
            // txtNomeDoItem
            // 
            this.txtNomeDoItem.Location = new System.Drawing.Point(40, 129);
            this.txtNomeDoItem.Name = "txtNomeDoItem";
            this.txtNomeDoItem.Size = new System.Drawing.Size(385, 23);
            this.txtNomeDoItem.TabIndex = 2;
            this.txtNomeDoItem.TextChanged += new System.EventHandler(this.txtNomeDoItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade Do Item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço Do Item:";
            // 
            // txtQuantidadeDoItem
            // 
            this.txtQuantidadeDoItem.Enabled = false;
            this.txtQuantidadeDoItem.Location = new System.Drawing.Point(40, 195);
            this.txtQuantidadeDoItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidadeDoItem.Name = "txtQuantidadeDoItem";
            this.txtQuantidadeDoItem.Size = new System.Drawing.Size(160, 23);
            this.txtQuantidadeDoItem.TabIndex = 5;
            this.txtQuantidadeDoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeDoItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(220, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "R$";
            // 
            // txtPrecoDoItem
            // 
            this.txtPrecoDoItem.Enabled = false;
            this.txtPrecoDoItem.Location = new System.Drawing.Point(252, 194);
            this.txtPrecoDoItem.Name = "txtPrecoDoItem";
            this.txtPrecoDoItem.Size = new System.Drawing.Size(173, 23);
            this.txtPrecoDoItem.TabIndex = 7;
            this.txtPrecoDoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoDoItem_KeyPress);
            // 
            // lstSacolaDeItens
            // 
            this.lstSacolaDeItens.FormattingEnabled = true;
            this.lstSacolaDeItens.ItemHeight = 15;
            this.lstSacolaDeItens.Location = new System.Drawing.Point(40, 254);
            this.lstSacolaDeItens.Name = "lstSacolaDeItens";
            this.lstSacolaDeItens.Size = new System.Drawing.Size(160, 184);
            this.lstSacolaDeItens.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seus Itens:";
            // 
            // btnColocarNaLista
            // 
            this.btnColocarNaLista.Enabled = false;
            this.btnColocarNaLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColocarNaLista.Location = new System.Drawing.Point(243, 244);
            this.btnColocarNaLista.Name = "btnColocarNaLista";
            this.btnColocarNaLista.Size = new System.Drawing.Size(182, 36);
            this.btnColocarNaLista.TabIndex = 10;
            this.btnColocarNaLista.Text = "Colocar Na Lista";
            this.btnColocarNaLista.UseVisualStyleBackColor = true;
            this.btnColocarNaLista.Click += new System.EventHandler(this.btnColocarNaLista_Click);
            // 
            // btnEsvaziarLista
            // 
            this.btnEsvaziarLista.Enabled = false;
            this.btnEsvaziarLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEsvaziarLista.Location = new System.Drawing.Point(243, 286);
            this.btnEsvaziarLista.Name = "btnEsvaziarLista";
            this.btnEsvaziarLista.Size = new System.Drawing.Size(182, 36);
            this.btnEsvaziarLista.TabIndex = 11;
            this.btnEsvaziarLista.Text = "Esvaziar Lista";
            this.btnEsvaziarLista.UseVisualStyleBackColor = true;
            this.btnEsvaziarLista.Click += new System.EventHandler(this.btnEsvaziarLista_Click);
            // 
            // btnFinalizarLista
            // 
            this.btnFinalizarLista.Enabled = false;
            this.btnFinalizarLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarLista.Location = new System.Drawing.Point(243, 328);
            this.btnFinalizarLista.Name = "btnFinalizarLista";
            this.btnFinalizarLista.Size = new System.Drawing.Size(182, 36);
            this.btnFinalizarLista.TabIndex = 12;
            this.btnFinalizarLista.Text = "Finalizar Lista";
            this.btnFinalizarLista.UseVisualStyleBackColor = true;
            this.btnFinalizarLista.Click += new System.EventHandler(this.btnFinalizarLista_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(243, 370);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(182, 36);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(243, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Qunatidade De Itens:";
            // 
            // lblQuantidadeDeItens
            // 
            this.lblQuantidadeDeItens.AutoSize = true;
            this.lblQuantidadeDeItens.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeDeItens.Location = new System.Drawing.Point(401, 419);
            this.lblQuantidadeDeItens.Name = "lblQuantidadeDeItens";
            this.lblQuantidadeDeItens.Size = new System.Drawing.Size(17, 19);
            this.lblQuantidadeDeItens.TabIndex = 15;
            this.lblQuantidadeDeItens.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(243, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Preço Final:  R$";
            // 
            // lblPrecoFinal
            // 
            this.lblPrecoFinal.AutoSize = true;
            this.lblPrecoFinal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoFinal.Location = new System.Drawing.Point(362, 438);
            this.lblPrecoFinal.Name = "lblPrecoFinal";
            this.lblPrecoFinal.Size = new System.Drawing.Size(45, 19);
            this.lblPrecoFinal.TabIndex = 16;
            this.lblPrecoFinal.Text = "00,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 471);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPrecoFinal);
            this.Controls.Add(this.lblQuantidadeDeItens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFinalizarLista);
            this.Controls.Add(this.btnEsvaziarLista);
            this.Controls.Add(this.btnColocarNaLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSacolaDeItens);
            this.Controls.Add(this.txtPrecoDoItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantidadeDoItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeDoItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App - CRUD Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeDoItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtQuantidadeDoItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoDoItem;
        private System.Windows.Forms.ListBox lstSacolaDeItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnColocarNaLista;
        private System.Windows.Forms.Button btnEsvaziarLista;
        private System.Windows.Forms.Button btnFinalizarLista;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuantidadeDeItens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrecoFinal;
    }
}
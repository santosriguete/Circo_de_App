namespace CircodeAPP
{
    partial class FrmBuscaCEP
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
            this.lblnovoCEP = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblnovoEndereço = new System.Windows.Forms.Label();
            this.lblendereço = new System.Windows.Forms.Label();
            this.lblnovocomplemento = new System.Windows.Forms.Label();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.lblnovobairro = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblNovaCidde = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblNovaUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnovoCEP
            // 
            this.lblnovoCEP.AutoSize = true;
            this.lblnovoCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovoCEP.Location = new System.Drawing.Point(12, 9);
            this.lblnovoCEP.Name = "lblnovoCEP";
            this.lblnovoCEP.Size = new System.Drawing.Size(88, 13);
            this.lblnovoCEP.TabIndex = 0;
            this.lblnovoCEP.Text = "Digite um CEP";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(229, 25);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(12, 25);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(176, 20);
            this.textCEP.TabIndex = 2;
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(326, 25);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblnovoEndereço
            // 
            this.lblnovoEndereço.AutoSize = true;
            this.lblnovoEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovoEndereço.Location = new System.Drawing.Point(9, 73);
            this.lblnovoEndereço.Name = "lblnovoEndereço";
            this.lblnovoEndereço.Size = new System.Drawing.Size(61, 13);
            this.lblnovoEndereço.TabIndex = 4;
            this.lblnovoEndereço.Text = "Endereço";
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Location = new System.Drawing.Point(9, 96);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(0, 13);
            this.lblendereço.TabIndex = 5;
            // 
            // lblnovocomplemento
            // 
            this.lblnovocomplemento.AutoSize = true;
            this.lblnovocomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovocomplemento.Location = new System.Drawing.Point(319, 73);
            this.lblnovocomplemento.Name = "lblnovocomplemento";
            this.lblnovocomplemento.Size = new System.Drawing.Size(82, 13);
            this.lblnovocomplemento.TabIndex = 6;
            this.lblnovocomplemento.Text = "Complemento";
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Location = new System.Drawing.Point(323, 96);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(0, 13);
            this.lblcomplemento.TabIndex = 7;
            // 
            // lblnovobairro
            // 
            this.lblnovobairro.AutoSize = true;
            this.lblnovobairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovobairro.Location = new System.Drawing.Point(9, 136);
            this.lblnovobairro.Name = "lblnovobairro";
            this.lblnovobairro.Size = new System.Drawing.Size(40, 13);
            this.lblnovobairro.TabIndex = 8;
            this.lblnovobairro.Text = "Bairro";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(12, 162);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(0, 13);
            this.lblbairro.TabIndex = 9;
            // 
            // lblNovaCidde
            // 
            this.lblNovaCidde.AutoSize = true;
            this.lblNovaCidde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaCidde.Location = new System.Drawing.Point(14, 215);
            this.lblNovaCidde.Name = "lblNovaCidde";
            this.lblNovaCidde.Size = new System.Drawing.Size(46, 13);
            this.lblNovaCidde.TabIndex = 10;
            this.lblNovaCidde.Text = "Cidade";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(14, 241);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(0, 13);
            this.lblCidade.TabIndex = 11;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(319, 241);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(0, 13);
            this.lblUF.TabIndex = 13;
            // 
            // lblNovaUF
            // 
            this.lblNovaUF.AutoSize = true;
            this.lblNovaUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaUF.Location = new System.Drawing.Point(319, 215);
            this.lblNovaUF.Name = "lblNovaUF";
            this.lblNovaUF.Size = new System.Drawing.Size(23, 13);
            this.lblNovaUF.TabIndex = 12;
            this.lblNovaUF.Text = "UF";
            // 
            // FrmBuscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblNovaUF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNovaCidde);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblnovobairro);
            this.Controls.Add(this.lblcomplemento);
            this.Controls.Add(this.lblnovocomplemento);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.lblnovoEndereço);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.textCEP);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.lblnovoCEP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscaCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnovoCEP;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblnovoEndereço;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.Label lblnovocomplemento;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label lblnovobairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblNovaCidde;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblNovaUF;
    }
}
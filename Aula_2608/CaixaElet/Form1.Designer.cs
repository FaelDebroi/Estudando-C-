namespace CaixaElet
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblDois = new System.Windows.Forms.Label();
            this.lblCinco = new System.Windows.Forms.Label();
            this.lblDez = new System.Windows.Forms.Label();
            this.lblVinte = new System.Windows.Forms.Label();
            this.lblCinq = new System.Windows.Forms.Label();
            this.lblCem = new System.Windows.Forms.Label();
            this.picCem = new System.Windows.Forms.PictureBox();
            this.picCinq = new System.Windows.Forms.PictureBox();
            this.picVinte = new System.Windows.Forms.PictureBox();
            this.picDez = new System.Windows.Forms.PictureBox();
            this.picCinco = new System.Windows.Forms.PictureBox();
            this.picDois = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDois)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(80, 23);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 17);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(141, 20);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 1;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(259, 19);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblDois
            // 
            this.lblDois.AutoSize = true;
            this.lblDois.Location = new System.Drawing.Point(59, 143);
            this.lblDois.Name = "lblDois";
            this.lblDois.Size = new System.Drawing.Size(12, 17);
            this.lblDois.TabIndex = 9;
            this.lblDois.Text = " ";
            // 
            // lblCinco
            // 
            this.lblCinco.AutoSize = true;
            this.lblCinco.Location = new System.Drawing.Point(195, 143);
            this.lblCinco.Name = "lblCinco";
            this.lblCinco.Size = new System.Drawing.Size(12, 17);
            this.lblCinco.TabIndex = 10;
            this.lblCinco.Text = " ";
            // 
            // lblDez
            // 
            this.lblDez.AutoSize = true;
            this.lblDez.Location = new System.Drawing.Point(308, 143);
            this.lblDez.Name = "lblDez";
            this.lblDez.Size = new System.Drawing.Size(12, 17);
            this.lblDez.TabIndex = 11;
            this.lblDez.Text = " ";
            // 
            // lblVinte
            // 
            this.lblVinte.AutoSize = true;
            this.lblVinte.Location = new System.Drawing.Point(59, 252);
            this.lblVinte.Name = "lblVinte";
            this.lblVinte.Size = new System.Drawing.Size(12, 17);
            this.lblVinte.TabIndex = 12;
            this.lblVinte.Text = " ";
            // 
            // lblCinq
            // 
            this.lblCinq.AutoSize = true;
            this.lblCinq.Location = new System.Drawing.Point(195, 252);
            this.lblCinq.Name = "lblCinq";
            this.lblCinq.Size = new System.Drawing.Size(12, 17);
            this.lblCinq.TabIndex = 13;
            this.lblCinq.Text = " ";
            // 
            // lblCem
            // 
            this.lblCem.AutoSize = true;
            this.lblCem.Location = new System.Drawing.Point(308, 252);
            this.lblCem.Name = "lblCem";
            this.lblCem.Size = new System.Drawing.Size(12, 17);
            this.lblCem.TabIndex = 14;
            this.lblCem.Text = " ";
            // 
            // picCem
            // 
            this.picCem.Image = global::CaixaElet.Properties.Resources._100reais;
            this.picCem.Location = new System.Drawing.Point(284, 182);
            this.picCem.Name = "picCem";
            this.picCem.Size = new System.Drawing.Size(100, 50);
            this.picCem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCem.TabIndex = 8;
            this.picCem.TabStop = false;
            // 
            // picCinq
            // 
            this.picCinq.Image = global::CaixaElet.Properties.Resources._50reais;
            this.picCinq.Location = new System.Drawing.Point(162, 182);
            this.picCinq.Name = "picCinq";
            this.picCinq.Size = new System.Drawing.Size(100, 50);
            this.picCinq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCinq.TabIndex = 7;
            this.picCinq.TabStop = false;
            // 
            // picVinte
            // 
            this.picVinte.Image = global::CaixaElet.Properties.Resources._20reais;
            this.picVinte.Location = new System.Drawing.Point(35, 182);
            this.picVinte.Name = "picVinte";
            this.picVinte.Size = new System.Drawing.Size(100, 50);
            this.picVinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVinte.TabIndex = 6;
            this.picVinte.TabStop = false;
            // 
            // picDez
            // 
            this.picDez.Image = global::CaixaElet.Properties.Resources._10reais;
            this.picDez.Location = new System.Drawing.Point(284, 79);
            this.picDez.Name = "picDez";
            this.picDez.Size = new System.Drawing.Size(100, 50);
            this.picDez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDez.TabIndex = 5;
            this.picDez.TabStop = false;
            // 
            // picCinco
            // 
            this.picCinco.Image = global::CaixaElet.Properties.Resources._5reais;
            this.picCinco.Location = new System.Drawing.Point(162, 79);
            this.picCinco.Name = "picCinco";
            this.picCinco.Size = new System.Drawing.Size(100, 50);
            this.picCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCinco.TabIndex = 4;
            this.picCinco.TabStop = false;
            // 
            // picDois
            // 
            this.picDois.Image = ((System.Drawing.Image)(resources.GetObject("picDois.Image")));
            this.picDois.Location = new System.Drawing.Point(35, 79);
            this.picDois.Name = "picDois";
            this.picDois.Size = new System.Drawing.Size(100, 50);
            this.picDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDois.TabIndex = 3;
            this.picDois.TabStop = false;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 315);
            this.Controls.Add(this.lblCem);
            this.Controls.Add(this.lblCinq);
            this.Controls.Add(this.lblVinte);
            this.Controls.Add(this.lblDez);
            this.Controls.Add(this.lblCinco);
            this.Controls.Add(this.lblDois);
            this.Controls.Add(this.picCem);
            this.Controls.Add(this.picCinq);
            this.Controls.Add(this.picVinte);
            this.Controls.Add(this.picDez);
            this.Controls.Add(this.picCinco);
            this.Controls.Add(this.picDois);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCaixa";
            this.Text = "Caixa Eletronico";
            ((System.ComponentModel.ISupportInitialize)(this.picCem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.PictureBox picDois;
        private System.Windows.Forms.PictureBox picCinco;
        private System.Windows.Forms.PictureBox picDez;
        private System.Windows.Forms.PictureBox picVinte;
        private System.Windows.Forms.PictureBox picCinq;
        private System.Windows.Forms.PictureBox picCem;
        private System.Windows.Forms.Label lblDois;
        private System.Windows.Forms.Label lblCinco;
        private System.Windows.Forms.Label lblDez;
        private System.Windows.Forms.Label lblVinte;
        private System.Windows.Forms.Label lblCinq;
        private System.Windows.Forms.Label lblCem;
    }
}


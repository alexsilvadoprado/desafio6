namespace Desafio6
{
    partial class frmDesafio6
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
            this.lblArquivo = new System.Windows.Forms.Label();
            this.txbCaminho = new System.Windows.Forms.TextBox();
            this.btnPickXml = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cmbPreco = new System.Windows.Forms.ComboBox();
            this.lsvCarros = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(13, 13);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(46, 13);
            this.lblArquivo.TabIndex = 0;
            this.lblArquivo.Text = "Arquivo:";
            // 
            // txbCaminho
            // 
            this.txbCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCaminho.Location = new System.Drawing.Point(65, 10);
            this.txbCaminho.Name = "txbCaminho";
            this.txbCaminho.ReadOnly = true;
            this.txbCaminho.Size = new System.Drawing.Size(708, 20);
            this.txbCaminho.TabIndex = 1;
            // 
            // btnPickXml
            // 
            this.btnPickXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickXml.Location = new System.Drawing.Point(779, 8);
            this.btnPickXml.Name = "btnPickXml";
            this.btnPickXml.Size = new System.Drawing.Size(36, 23);
            this.btnPickXml.TabIndex = 2;
            this.btnPickXml.Text = "...";
            this.btnPickXml.UseVisualStyleBackColor = true;
            this.btnPickXml.Click += new System.EventHandler(this.btnPickXml_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(65, 37);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(299, 21);
            this.cmbMarca.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(64, 68);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(300, 21);
            this.cmbModelo.TabIndex = 6;
            // 
            // lblAno
            // 
            this.lblAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(440, 40);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Ano:";
            // 
            // cmbAno
            // 
            this.cmbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(484, 37);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(331, 21);
            this.cmbAno.TabIndex = 8;
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(440, 71);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço:";
            // 
            // cmbPreco
            // 
            this.cmbPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreco.FormattingEnabled = true;
            this.cmbPreco.Location = new System.Drawing.Point(484, 68);
            this.cmbPreco.Name = "cmbPreco";
            this.cmbPreco.Size = new System.Drawing.Size(331, 21);
            this.cmbPreco.TabIndex = 10;
            // 
            // lsvCarros
            // 
            this.lsvCarros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnMarca,
            this.columnModelo,
            this.columnAno,
            this.columnPreco});
            this.lsvCarros.Location = new System.Drawing.Point(12, 95);
            this.lsvCarros.Name = "lsvCarros";
            this.lsvCarros.Size = new System.Drawing.Size(803, 332);
            this.lsvCarros.TabIndex = 11;
            this.lsvCarros.UseCompatibleStateImageBehavior = false;
            this.lsvCarros.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columnMarca
            // 
            this.columnMarca.Text = "Marca";
            this.columnMarca.Width = 205;
            // 
            // columnModelo
            // 
            this.columnModelo.Text = "Modelo";
            this.columnModelo.Width = 278;
            // 
            // columnAno
            // 
            this.columnAno.Text = "Ano";
            this.columnAno.Width = 93;
            // 
            // columnPreco
            // 
            this.columnPreco.Text = "Preço";
            this.columnPreco.Width = 165;
            // 
            // frmDesafio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 439);
            this.Controls.Add(this.lsvCarros);
            this.Controls.Add(this.cmbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnPickXml);
            this.Controls.Add(this.txbCaminho);
            this.Controls.Add(this.lblArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDesafio6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Fácil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.TextBox txbCaminho;
        private System.Windows.Forms.Button btnPickXml;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox cmbPreco;
        private System.Windows.Forms.ListView lsvCarros;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnMarca;
        private System.Windows.Forms.ColumnHeader columnModelo;
        private System.Windows.Forms.ColumnHeader columnAno;
        private System.Windows.Forms.ColumnHeader columnPreco;
    }
}


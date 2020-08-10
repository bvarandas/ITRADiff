namespace FormITRADIF
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
            this.openFileDialogItraMacro = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxMacro = new System.Windows.Forms.GroupBox();
            this.lblItraMacroCarregado = new System.Windows.Forms.Label();
            this.btnCarregarItraMacro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItraSistemaCarregado = new System.Windows.Forms.Label();
            this.btnCarregarItraSistema = new System.Windows.Forms.Button();
            this.openFileDialogItraSistema = new System.Windows.Forms.OpenFileDialog();
            this.gridItraDiferentes = new System.Windows.Forms.DataGridView();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridItraIguais = new System.Windows.Forms.DataGridView();
            this.btnCompararItras = new System.Windows.Forms.Button();
            this.groupBoxMacro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItraDiferentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItraIguais)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogItraMacro
            // 
            this.openFileDialogItraMacro.FileName = "openFileDialogItraMacro";
            // 
            // groupBoxMacro
            // 
            this.groupBoxMacro.Controls.Add(this.lblItraMacroCarregado);
            this.groupBoxMacro.Controls.Add(this.btnCarregarItraMacro);
            this.groupBoxMacro.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMacro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMacro.Name = "groupBoxMacro";
            this.groupBoxMacro.Size = new System.Drawing.Size(335, 122);
            this.groupBoxMacro.TabIndex = 0;
            this.groupBoxMacro.TabStop = false;
            this.groupBoxMacro.Text = "ITRA Macro";
            // 
            // lblItraMacroCarregado
            // 
            this.lblItraMacroCarregado.AutoSize = true;
            this.lblItraMacroCarregado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItraMacroCarregado.Location = new System.Drawing.Point(8, 83);
            this.lblItraMacroCarregado.Name = "lblItraMacroCarregado";
            this.lblItraMacroCarregado.Size = new System.Drawing.Size(0, 26);
            this.lblItraMacroCarregado.TabIndex = 1;
            // 
            // btnCarregarItraMacro
            // 
            this.btnCarregarItraMacro.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarItraMacro.Location = new System.Drawing.Point(13, 21);
            this.btnCarregarItraMacro.Name = "btnCarregarItraMacro";
            this.btnCarregarItraMacro.Size = new System.Drawing.Size(305, 44);
            this.btnCarregarItraMacro.TabIndex = 0;
            this.btnCarregarItraMacro.Text = "Carregar ITRA MACRO";
            this.btnCarregarItraMacro.UseVisualStyleBackColor = true;
            this.btnCarregarItraMacro.Click += new System.EventHandler(this.btnCarregarItraMacro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblItraSistemaCarregado);
            this.groupBox2.Controls.Add(this.btnCarregarItraSistema);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ITRA Sistema";
            // 
            // lblItraSistemaCarregado
            // 
            this.lblItraSistemaCarregado.AutoSize = true;
            this.lblItraSistemaCarregado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItraSistemaCarregado.Location = new System.Drawing.Point(8, 83);
            this.lblItraSistemaCarregado.Name = "lblItraSistemaCarregado";
            this.lblItraSistemaCarregado.Size = new System.Drawing.Size(0, 26);
            this.lblItraSistemaCarregado.TabIndex = 2;
            // 
            // btnCarregarItraSistema
            // 
            this.btnCarregarItraSistema.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarItraSistema.Location = new System.Drawing.Point(13, 21);
            this.btnCarregarItraSistema.Name = "btnCarregarItraSistema";
            this.btnCarregarItraSistema.Size = new System.Drawing.Size(305, 44);
            this.btnCarregarItraSistema.TabIndex = 1;
            this.btnCarregarItraSistema.Text = "Carregar ITRA SISTEMA";
            this.btnCarregarItraSistema.UseVisualStyleBackColor = true;
            this.btnCarregarItraSistema.Click += new System.EventHandler(this.btnCarregarItraSistema_Click);
            // 
            // openFileDialogItraSistema
            // 
            this.openFileDialogItraSistema.FileName = "openFileDialogItraMacro";
            // 
            // gridItraDiferentes
            // 
            this.gridItraDiferentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItraDiferentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCliente,
            this.CodISIN,
            this.Quantidade,
            this.Diferenca});
            this.gridItraDiferentes.Location = new System.Drawing.Point(12, 32);
            this.gridItraDiferentes.Name = "gridItraDiferentes";
            this.gridItraDiferentes.Size = new System.Drawing.Size(685, 150);
            this.gridItraDiferentes.TabIndex = 2;
            // 
            // CodCliente
            // 
            this.CodCliente.HeaderText = "CodCliente";
            this.CodCliente.Name = "CodCliente";
            this.CodCliente.Width = 150;
            // 
            // CodISIN
            // 
            this.CodISIN.HeaderText = "CodISIN";
            this.CodISIN.Name = "CodISIN";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Diferenca
            // 
            this.Diferenca.HeaderText = "Diferenca";
            this.Diferenca.Name = "Diferenca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridItraDiferentes);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diferenças encontradas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridItraIguais);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 200);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista dos clientes iguais";
            // 
            // gridItraIguais
            // 
            this.gridItraIguais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItraIguais.Location = new System.Drawing.Point(12, 32);
            this.gridItraIguais.Name = "gridItraIguais";
            this.gridItraIguais.Size = new System.Drawing.Size(685, 150);
            this.gridItraIguais.TabIndex = 2;
            // 
            // btnCompararItras
            // 
            this.btnCompararItras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCompararItras.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompararItras.Location = new System.Drawing.Point(215, 140);
            this.btnCompararItras.Name = "btnCompararItras";
            this.btnCompararItras.Size = new System.Drawing.Size(305, 44);
            this.btnCompararItras.TabIndex = 2;
            this.btnCompararItras.Text = "Comparar ITRAS";
            this.btnCompararItras.UseVisualStyleBackColor = false;
            this.btnCompararItras.Click += new System.EventHandler(this.btnCompararItras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 615);
            this.Controls.Add(this.btnCompararItras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxMacro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMacro.ResumeLayout(false);
            this.groupBoxMacro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItraDiferentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItraIguais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogItraMacro;
        private System.Windows.Forms.GroupBox groupBoxMacro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCarregarItraMacro;
        private System.Windows.Forms.Button btnCarregarItraSistema;
        private System.Windows.Forms.Label lblItraMacroCarregado;
        private System.Windows.Forms.Label lblItraSistemaCarregado;
        private System.Windows.Forms.OpenFileDialog openFileDialogItraSistema;
        private System.Windows.Forms.DataGridView gridItraDiferentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodISIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferenca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridItraIguais;
        private System.Windows.Forms.Button btnCompararItras;
    }
}


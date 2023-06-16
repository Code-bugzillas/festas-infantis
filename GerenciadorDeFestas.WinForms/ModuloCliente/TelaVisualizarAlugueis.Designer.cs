namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    partial class TelaVisualizarAlugueis
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
            lblFesta = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            tabelaAluguelControl1 = new ModuloAluguel.TabelaAluguelControl();
            SuspendLayout();
            // 
            // lblFesta
            // 
            lblFesta.AutoSize = true;
            lblFesta.Location = new Point(70, 28);
            lblFesta.Name = "lblFesta";
            lblFesta.Size = new Size(52, 15);
            lblFesta.TabIndex = 15;
            lblFesta.Text = "---------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 13;
            label1.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(27, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(578, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "OK";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // tabelaAluguelControl1
            // 
            tabelaAluguelControl1.Location = new Point(27, 58);
            tabelaAluguelControl1.Name = "tabelaAluguelControl1";
            tabelaAluguelControl1.Size = new Size(578, 269);
            tabelaAluguelControl1.TabIndex = 16;
            // 
            // TelaVisualizarAlugueis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 416);
            Controls.Add(tabelaAluguelControl1);
            Controls.Add(lblFesta);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "TelaVisualizarAlugueis";
            Text = "TelaVisualizarAlugueisClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFesta;
        private Label label1;
        private Button btnCancelar;
        private ModuloAluguel.TabelaAluguelControl tabelaAluguelControl1;
    }
}
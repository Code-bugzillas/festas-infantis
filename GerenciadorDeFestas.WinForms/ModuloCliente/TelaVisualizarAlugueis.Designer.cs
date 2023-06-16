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
            groupBox1 = new GroupBox();
            listAluguel = new ListBox();
            label1 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(listAluguel);
            groupBox1.Location = new Point(27, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 227);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes do Aluguel";
            // 
            // listAluguel
            // 
            listAluguel.FormattingEnabled = true;
            listAluguel.ItemHeight = 15;
            listAluguel.Location = new Point(6, 22);
            listAluguel.Name = "listAluguel";
            listAluguel.Size = new Size(312, 199);
            listAluguel.TabIndex = 0;
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
            btnCancelar.Location = new Point(27, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(325, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "OK";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaVisualizarAlugueisClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 361);
            Controls.Add(lblFesta);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "TelaVisualizarAlugueisClientes";
            Text = "TelaVisualizarAlugueisClientes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFesta;
        private GroupBox groupBox1;
        private ListBox listAluguel;
        private Label label1;
        private Button btnCancelar;
    }
}
namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class TelaVisualizarItensForm
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
            lblTema = new Label();
            groupBox1 = new GroupBox();
            listTemas = new ListBox();
            label1 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(54, 19);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(52, 15);
            lblTema.TabIndex = 15;
            lblTema.Text = "---------";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listTemas);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 281);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes do Tema";
            // 
            // listTemas
            // 
            listTemas.Dock = DockStyle.Fill;
            listTemas.FormattingEnabled = true;
            listTemas.ItemHeight = 15;
            listTemas.Location = new Point(3, 19);
            listTemas.Name = "listTemas";
            listTemas.Size = new Size(312, 259);
            listTemas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "Tema:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(15, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(315, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaVisualizarItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(339, 390);
            Controls.Add(lblTema);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "TelaVisualizarItensForm";
            Text = "Visualizar Itens";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTema;
        private GroupBox groupBox1;
        private ListBox listTemas;
        private Label label1;
        private Button btnCancelar;
    }
}
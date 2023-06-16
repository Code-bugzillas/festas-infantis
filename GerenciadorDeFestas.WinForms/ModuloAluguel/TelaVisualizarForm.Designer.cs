namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaVisualizarForm
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
            btnCancelar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listFestas = new ListBox();
            lblFesta = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(15, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(315, 41);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 9;
            label1.Text = "Festa:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listFestas);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 281);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes da Festa";
            // 
            // listFestas
            // 
            listFestas.Dock = DockStyle.Fill;
            listFestas.FormattingEnabled = true;
            listFestas.ItemHeight = 15;
            listFestas.Location = new Point(3, 19);
            listFestas.Name = "listFestas";
            listFestas.Size = new Size(312, 259);
            listFestas.TabIndex = 0;
            // 
            // lblFesta
            // 
            lblFesta.AutoSize = true;
            lblFesta.Location = new Point(54, 19);
            lblFesta.Name = "lblFesta";
            lblFesta.Size = new Size(52, 15);
            lblFesta.TabIndex = 11;
            lblFesta.Text = "---------";
            // 
            // TelaVisualizarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 389);
            Controls.Add(lblFesta);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "TelaVisualizarForm";
            Text = "TelaVisualizarForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblFesta;
        private ListBox listFestas;
    }
}
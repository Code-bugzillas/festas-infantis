namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class TelaTemaForm
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
            chListItens = new CheckedListBox();
            txtTema = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtValor = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // chListItens
            // 
            chListItens.FormattingEnabled = true;
            chListItens.Location = new Point(23, 92);
            chListItens.Name = "chListItens";
            chListItens.Size = new Size(425, 148);
            chListItens.TabIndex = 21;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(72, 19);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(282, 23);
            txtTema.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 22);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 19;
            label3.Text = "Tema";
            // 
            // txtId
            // 
            txtId.Location = new Point(420, 19);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 18;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 22);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 17;
            label2.Text = "Id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.PowderBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(266, 246);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(360, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(72, 48);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(96, 23);
            txtValor.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 51);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 22;
            label1.Text = "Valor";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(463, 299);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(chListItens);
            Controls.Add(txtTema);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaTemaForm";
            Text = "Registro de Tema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chListItens;
        private TextBox txtTema;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtValor;
        private Label label1;
    }
}
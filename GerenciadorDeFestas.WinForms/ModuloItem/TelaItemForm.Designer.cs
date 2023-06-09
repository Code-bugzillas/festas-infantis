namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    partial class TelaItemForm
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
            txtId = new TextBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtTema = new TextBox();
            label3 = new Label();
            chListItens = new CheckedListBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(424, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 15);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(270, 204);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(364, 204);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(76, 12);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(282, 23);
            txtTema.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 15);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "Tema:";
            // 
            // chListItens
            // 
            chListItens.FormattingEnabled = true;
            chListItens.Location = new Point(27, 50);
            chListItens.Name = "chListItens";
            chListItens.Size = new Size(425, 148);
            chListItens.TabIndex = 14;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 256);
            Controls.Add(chListItens);
            Controls.Add(txtTema);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaItemForm";
            Text = "TelaItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtTema;
        private Label label3;
        private CheckedListBox chListItens;
    }
}
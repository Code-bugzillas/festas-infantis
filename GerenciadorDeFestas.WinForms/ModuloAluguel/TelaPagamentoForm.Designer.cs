namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaPagamentoForm
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
            label1 = new Label();
            rdbQuarenta = new RadioButton();
            rdbCinquenta = new RadioButton();
            rdbCem = new RadioButton();
            lblCliente = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(182, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 23);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 9;
            label2.Text = "Id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.PowderBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(26, 98);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(120, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 11;
            label1.Text = "Cliente:";
            // 
            // rdbQuarenta
            // 
            rdbQuarenta.AutoSize = true;
            rdbQuarenta.Location = new Point(22, 56);
            rdbQuarenta.Name = "rdbQuarenta";
            rdbQuarenta.Size = new Size(47, 19);
            rdbQuarenta.TabIndex = 12;
            rdbQuarenta.TabStop = true;
            rdbQuarenta.Text = "40%";
            rdbQuarenta.UseVisualStyleBackColor = true;
            // 
            // rdbCinquenta
            // 
            rdbCinquenta.AutoSize = true;
            rdbCinquenta.Location = new Point(89, 56);
            rdbCinquenta.Name = "rdbCinquenta";
            rdbCinquenta.Size = new Size(47, 19);
            rdbCinquenta.TabIndex = 13;
            rdbCinquenta.TabStop = true;
            rdbCinquenta.Text = "50%";
            rdbCinquenta.UseVisualStyleBackColor = true;
            // 
            // rdbCem
            // 
            rdbCem.AutoSize = true;
            rdbCem.Location = new Point(157, 56);
            rdbCem.Name = "rdbCem";
            rdbCem.Size = new Size(53, 19);
            rdbCem.TabIndex = 14;
            rdbCem.TabStop = true;
            rdbCem.Text = "100%";
            rdbCem.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(74, 23);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(62, 15);
            lblCliente.TabIndex = 16;
            lblCliente.Text = "-----------";
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(232, 151);
            Controls.Add(lblCliente);
            Controls.Add(rdbCem);
            Controls.Add(rdbCinquenta);
            Controls.Add(rdbQuarenta);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaPagamentoForm";
            Text = "Gerenciador de Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private RadioButton rdbQuarenta;
        private RadioButton rdbCinquenta;
        private RadioButton rdbCem;
        private Label lblCliente;
    }
}
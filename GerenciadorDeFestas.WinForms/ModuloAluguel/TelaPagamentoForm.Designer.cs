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
            rdbZero = new RadioButton();
            rdbCinquenta = new RadioButton();
            rdbCem = new RadioButton();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(288, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 15);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.PowderBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(134, 93);
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
            btnCancelar.Location = new Point(228, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 11;
            label1.Text = "Porcentagem do valor que o cliente pagou";
            // 
            // rdbZero
            // 
            rdbZero.AutoSize = true;
            rdbZero.Location = new Point(40, 57);
            rdbZero.Name = "rdbZero";
            rdbZero.Size = new Size(41, 19);
            rdbZero.TabIndex = 12;
            rdbZero.TabStop = true;
            rdbZero.Text = "0%";
            rdbZero.UseVisualStyleBackColor = true;
            // 
            // rdbCinquenta
            // 
            rdbCinquenta.AutoSize = true;
            rdbCinquenta.Location = new Point(134, 57);
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
            rdbCem.Location = new Point(229, 57);
            rdbCem.Name = "rdbCem";
            rdbCem.Size = new Size(53, 19);
            rdbCem.TabIndex = 14;
            rdbCem.TabStop = true;
            rdbCem.Text = "100%";
            rdbCem.UseVisualStyleBackColor = true;
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(330, 148);
            Controls.Add(rdbCem);
            Controls.Add(rdbCinquenta);
            Controls.Add(rdbZero);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaPagamentoForm";
            Text = "TelaPagamentoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private RadioButton rdbZero;
        private RadioButton rdbCinquenta;
        private RadioButton rdbCem;
    }
}
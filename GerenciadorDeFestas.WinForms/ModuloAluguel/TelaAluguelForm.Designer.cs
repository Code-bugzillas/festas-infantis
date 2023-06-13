namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaAluguelForm
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
            label3 = new Label();
            cbCliente = new ComboBox();
            cbTema = new ComboBox();
            groupBox1 = new GroupBox();
            dtHoraFinal = new DateTimePicker();
            dtHoraInicio = new DateTimePicker();
            dtData = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtRua = new TextBox();
            txtNum = new TextBox();
            txtCep = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(384, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 20);
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
            btnGravar.Location = new Point(240, 184);
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
            btnCancelar.Location = new Point(334, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 20);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Tema";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(56, 17);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 13;
            // 
            // cbTema
            // 
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(229, 17);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(121, 23);
            cbTema.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtHoraFinal);
            groupBox1.Controls.Add(dtHoraInicio);
            groupBox1.Controls.Add(dtData);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 112);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // dtHoraFinal
            // 
            dtHoraFinal.CustomFormat = "HH:mm";
            dtHoraFinal.Format = DateTimePickerFormat.Custom;
            dtHoraFinal.Location = new Point(79, 80);
            dtHoraFinal.Name = "dtHoraFinal";
            dtHoraFinal.Size = new Size(115, 23);
            dtHoraFinal.TabIndex = 5;
            // 
            // dtHoraInicio
            // 
            dtHoraInicio.CustomFormat = "HH:mm";
            dtHoraInicio.Format = DateTimePickerFormat.Custom;
            dtHoraInicio.Location = new Point(79, 51);
            dtHoraInicio.Name = "dtHoraInicio";
            dtHoraInicio.Size = new Size(115, 23);
            dtHoraInicio.TabIndex = 4;
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(79, 22);
            dtData.Name = "dtData";
            dtData.Size = new Size(115, 23);
            dtData.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 86);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 2;
            label6.Text = "Hora Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 57);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 1;
            label5.Text = "Hora Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 28);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Data";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(txtNum);
            groupBox2.Controls.Add(txtCep);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(222, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 112);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Localização";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(78, 80);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(100, 23);
            txtRua.TabIndex = 8;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(78, 51);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(50, 23);
            txtNum.TabIndex = 7;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(78, 22);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 86);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 5;
            label7.Text = "Rua";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 57);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 4;
            label8.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 28);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 3;
            label9.Text = "CEP";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(434, 237);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cbTema);
            Controls.Add(cbCliente);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Label label3;
        private ComboBox cbCliente;
        private ComboBox cbTema;
        private GroupBox groupBox1;
        private DateTimePicker dtHoraFinal;
        private DateTimePicker dtHoraInicio;
        private DateTimePicker dtData;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtRua;
        private TextBox txtNum;
        private TextBox txtCep;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
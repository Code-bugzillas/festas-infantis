namespace GerenciadorDeFestas.WinForms
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuBar = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesMenuItem = new ToolStripMenuItem();
            TemasMenu = new ToolStripMenuItem();
            ItensMenuItem = new ToolStripMenuItem();
            TemasMenuItem = new ToolStripMenuItem();
            aluguelMenuItem = new ToolStripMenuItem();
            toolBar = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnPagamento = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menuBar.SuspendLayout();
            toolBar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.BackColor = Color.LightCyan;
            menuBar.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(657, 24);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.BackColor = Color.LightCyan;
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem, TemasMenu, aluguelMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.ForeColor = Color.Black;
            cadastrosToolStripMenuItem.Image = Properties.Resources.cake;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.BackColor = Color.LightCyan;
            clientesMenuItem.Image = Properties.Resources.avatar;
            clientesMenuItem.Name = "clientesMenuItem";
            clientesMenuItem.Size = new Size(115, 22);
            clientesMenuItem.Text = "Cliente";
            clientesMenuItem.Click += clientesMenuItem_Click;
            // 
            // TemasMenu
            // 
            TemasMenu.BackColor = Color.LightCyan;
            TemasMenu.DropDownItems.AddRange(new ToolStripItem[] { ItensMenuItem, TemasMenuItem });
            TemasMenu.Image = Properties.Resources.party;
            TemasMenu.Name = "TemasMenu";
            TemasMenu.Size = new Size(115, 22);
            TemasMenu.Text = "Temas";
            // 
            // ItensMenuItem
            // 
            ItensMenuItem.BackColor = Color.LightCyan;
            ItensMenuItem.Image = Properties.Resources.birthday;
            ItensMenuItem.Name = "ItensMenuItem";
            ItensMenuItem.Size = new Size(107, 22);
            ItensMenuItem.Text = "Itens";
            ItensMenuItem.Click += ItensMenuItem_Click;
            // 
            // TemasMenuItem
            // 
            TemasMenuItem.BackColor = Color.LightCyan;
            TemasMenuItem.Image = Properties.Resources.wind;
            TemasMenuItem.Name = "TemasMenuItem";
            TemasMenuItem.Size = new Size(107, 22);
            TemasMenuItem.Text = "Temas";
            TemasMenuItem.Click += TemasMenuItem_Click;
            // 
            // aluguelMenuItem
            // 
            aluguelMenuItem.BackColor = Color.LightCyan;
            aluguelMenuItem.Image = Properties.Resources.balloon;
            aluguelMenuItem.Name = "aluguelMenuItem";
            aluguelMenuItem.Size = new Size(115, 22);
            aluguelMenuItem.Text = "Aluguel";
            aluguelMenuItem.Click += aluguelMenuItem_Click;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.PowderBlue;
            toolBar.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnPagamento, toolStripSeparator2, labelTipoCadastro });
            toolBar.Location = new Point(0, 24);
            toolBar.Name = "toolBar";
            toolBar.RenderMode = ToolStripRenderMode.System;
            toolBar.Size = new Size(657, 53);
            toolBar.TabIndex = 2;
            toolBar.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = Properties.Resources._1486564407_plus_green_81521;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(50, 50);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources._3592815_compose_create_edit_edit_file_office_pencil_writing_107734;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(50, 50);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources._3592821_garbage_can_general_office_recycle_bin_rubbish_bin_trash_bin_trash_can_107760;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(50, 50);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 53);
            // 
            // btnPagamento
            // 
            btnPagamento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPagamento.Enabled = false;
            btnPagamento.Image = Properties.Resources._3592863_accounting_calculate_calculation_calculator_general_math_office_107744;
            btnPagamento.ImageScaling = ToolStripItemImageScaling.None;
            btnPagamento.ImageTransparentColor = Color.Magenta;
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Padding = new Padding(7);
            btnPagamento.Size = new Size(50, 50);
            btnPagamento.Text = "toolStripButton4";
            btnPagamento.Click += btnPagamento_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 53);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(84, 50);
            labelTipoCadastro.Text = "tipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 77);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(657, 259);
            panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 314);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(657, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "[rodape]";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodape]";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 336);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolBar);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            Text = "Gerenciador de Festas";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStripMenuItem TemasMenu;
        private ToolStripMenuItem ItensMenuItem;
        private ToolStripMenuItem aluguelMenuItem;
        private ToolStrip toolBar;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel labelTipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStripMenuItem TemasMenuItem;
        private ToolStripButton btnPagamento;
    }
}
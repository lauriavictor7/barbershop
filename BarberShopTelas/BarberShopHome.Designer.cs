﻿namespace BarberShopTelas
{
    partial class BarberShopHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeWCF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeWCF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeBDCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testesToolStripMenuItem,
            this.testeBDCONToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeWCF1ToolStripMenuItem,
            this.testeWCF2ToolStripMenuItem});
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.testesToolStripMenuItem.Text = "Testes";
            // 
            // testeWCF1ToolStripMenuItem
            // 
            this.testeWCF1ToolStripMenuItem.Name = "testeWCF1ToolStripMenuItem";
            this.testeWCF1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.testeWCF1ToolStripMenuItem.Text = "Teste WCF 1";
            this.testeWCF1ToolStripMenuItem.Click += new System.EventHandler(this.testeWCF1ToolStripMenuItem_Click);
            // 
            // testeWCF2ToolStripMenuItem
            // 
            this.testeWCF2ToolStripMenuItem.Name = "testeWCF2ToolStripMenuItem";
            this.testeWCF2ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.testeWCF2ToolStripMenuItem.Text = "Teste WCF 2";
            this.testeWCF2ToolStripMenuItem.Click += new System.EventHandler(this.testeWCF2ToolStripMenuItem_Click);
            // 
            // testeBDCONToolStripMenuItem
            // 
            this.testeBDCONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testandoToolStripMenuItem});
            this.testeBDCONToolStripMenuItem.Name = "testeBDCONToolStripMenuItem";
            this.testeBDCONToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.testeBDCONToolStripMenuItem.Text = "Teste BD CON";
            // 
            // testandoToolStripMenuItem
            // 
            this.testandoToolStripMenuItem.Name = "testandoToolStripMenuItem";
            this.testandoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testandoToolStripMenuItem.Text = "Testando";
            this.testandoToolStripMenuItem.Click += new System.EventHandler(this.testandoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // BarberShopHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 443);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BarberShopHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeWCF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeWCF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeBDCONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testandoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
    }
}

﻿namespace BarberShopTelas
{
    partial class ListaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaAgendamento));
            this.listViewAg = new System.Windows.Forms.ListView();
            this.Cod_Agendamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Servico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewAg
            // 
            this.listViewAg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod_Agendamento,
            this.CPF,
            this.Nome,
            this.Servico,
            this.Data,
            this.Hora});
            this.listViewAg.FullRowSelect = true;
            this.listViewAg.Location = new System.Drawing.Point(0, 0);
            this.listViewAg.Name = "listViewAg";
            this.listViewAg.Size = new System.Drawing.Size(657, 137);
            this.listViewAg.TabIndex = 2;
            this.listViewAg.UseCompatibleStateImageBehavior = false;
            this.listViewAg.View = System.Windows.Forms.View.Details;
            this.listViewAg.SelectedIndexChanged += new System.EventHandler(this.listViewAg_SelectedIndexChanged);
            // 
            // Cod_Agendamento
            // 
            this.Cod_Agendamento.Text = "Cod_Agendamento";
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Servico
            // 
            this.Servico.Text = "Servico";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            // 
            // ListaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(656, 135);
            this.Controls.Add(this.listViewAg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Agendamento";
            this.Load += new System.EventHandler(this.ListaAgendamento_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewAg;
        private System.Windows.Forms.ColumnHeader Cod_Agendamento;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Servico;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
    }
}
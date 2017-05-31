﻿using BarberShopTelas.localhost;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShopTelas
{
    public partial class CadastrarServico : Form
    {
        public CadastrarServico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();
                s.Cod_serv = Convert.ToInt32(textBox1.Text);
                s.Preco = Convert.ToInt32(textBox2.Text);
                s.Descricao = textBox3.Text;

                Service1 sv = new Service1();
                sv.inserirServico(s);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();
                s.Cod_serv = Convert.ToInt32(textBox1.Text);

                Service1 sv = new Service1();
                sv.removerServico(s);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();
                s.Cod_serv = Convert.ToInt32(textBox1.Text);
                s.Preco = Convert.ToInt32(textBox2.Text);
                s.Descricao = textBox3.Text;

                Service1 sv = new Service1();
                sv.atualizarServico(s);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Instância não necessária. Produtos são listados mesmo sem ela.
                localhost.Servico s = new localhost.Servico();

                Service1 sv = new Service1();
                dataGridView1.DataSource = sv.listarServico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }
    }
}


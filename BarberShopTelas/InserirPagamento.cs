﻿using BarberShopTelas.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BarberShopTelas
{
    public partial class InserirPagamento : Form
    {

        Random randNum = new Random();
        
        private new string Location;
        private static XmlDocument documento;

        public InserirPagamento()
        {
            InitializeComponent();
        }

        private void limpaTxt()
        {
            maskedTextBox1.Clear();
            textBoxCodCaixa.Clear();
            textBoxDataPg.Clear();
            textBoxHoraPg.Clear();
            textBoxNome.Clear();
            textBoxValorPg.Clear();
            comboBox1.Items.Clear();
        }
       
        private void InserirPagamento_Load(object sender, EventArgs e)
        {
            documento = new XmlDocument();

        }


        private void SaveXML(int rand)
        {
            
            
            BarberShopClasses.pagamento.Pagamento newPagamento = new BarberShopClasses.pagamento.Pagamento()
            {
               
               Cod_caixa = Convert.ToInt32(textBoxCodCaixa.Text),
               Cpf = maskedTextBox1.Text,
               Nome = textBoxNome.Text,
               Data = textBoxDataPg.Text,
               Hora = textBoxHoraPg.Text,
               Valor = Convert.ToDecimal(textBoxValorPg.Text)
               
            };

            #region Colocando numero randomico na Notafiscal
            
            //Location = @"C:\Users\victo\Desktop\NotasSalvas\NF" + rand + ".xml";
            Location = @"C:\Users\luizd\Desktop\Estudos\Persistindo os dados no XML\NF" + rand + ".xml";
            #endregion
            documento.LoadXml(newPagamento.ToXML());
            documento.Save(Location);
            }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string date;
            string hora;
            date = DateTime.Now.ToShortDateString();
            hora = DateTime.Now.ToLongTimeString();
            textBoxDataPg.Text = date;
            textBoxHoraPg.Text = hora;
            textBoxDataPg.Enabled = false;
            textBoxHoraPg.Enabled = false;
            textBoxValorPg.Enabled = false;
        }

        private void buttonCheckPg_Click(object sender, EventArgs e)
        {
            try
            {
                Service1 sv = new Service1();
                string cpf = maskedTextBox1.Text;
                string valor;
                var cliente = sv.buscarCliente(cpf);
                Servico s = new Servico();
                s = sv.buscarValor(cpf);
                valor = Convert.ToString(s.Preco);
                textBoxNome.Text = cliente.Nome;
                textBoxNome.Enabled = false;
                textBoxValorPg.Text = valor;
                textBoxValorPg.Enabled = false;
                if (textBoxValorPg.Text.Equals("0"))
                {
                    textBoxValorPg.Text = " ";
                    maskedTextBox1.Text = " ";
                    textBoxNome.Enabled = true;
                    MessageBox.Show("Insira um cliente valido");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void buttonPagamento_Click(object sender, EventArgs e)
        {
            
            Pagamento p = new Pagamento();
            Agendamento a = new Agendamento();
            a.Cliente = new Cliente();

            try
            {
                if (maskedTextBox1.Equals(" "))
                {
                    MessageBox.Show("Informe o CPF, e click no Check !");
                }
                if (textBoxValorPg.Enabled == true)
                {
                    MessageBox.Show("Por favor de um check no cpf, os campos preencheram automaticamente !");
                }
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Escolha o tipo de pagamento!");
                }
                if (comboBox1.SelectedIndex == 0)
                {

                    p.Metodo = "Db";
                    p.Valor = Convert.ToDecimal(textBoxValorPg.Text);
                    string horastr = textBoxHoraPg.Text.ToString();
                    p.Hora = horastr;
                    p.Data = textBoxDataPg.Text;
                    p.Cpf = maskedTextBox1.Text;

                }
                if (comboBox1.SelectedIndex == 1)
                {

                    p.Metodo = "Cd";
                    p.Valor = Convert.ToDecimal(textBoxValorPg.Text);
                    string horastr = textBoxHoraPg.Text.ToString();
                    p.Hora = horastr;
                    p.Data = textBoxDataPg.Text;
                    p.Cpf = maskedTextBox1.Text;

                }
                if (comboBox1.SelectedIndex == 2)
                {

                    p.Metodo = "Av";
                    p.Valor = Convert.ToDecimal(textBoxValorPg.Text);
                    string horastr = textBoxHoraPg.Text.ToString();
                    p.Hora = horastr;
                    p.Data = textBoxDataPg.Text;
                    p.Cpf = maskedTextBox1.Text;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algum campo incompleto");
            }

            try
            {
                Service1 sv = new Service1();
                sv.CadastrarPagamento(p);

                a.Cliente.Cpf = p.Cpf;
                sv.RemoverAgendamento(a);

                localhost.Caixa cx = new localhost.Caixa();
                int cod = Convert.ToInt16(textBoxCodCaixa.Text);

                Service1 s = new Service1();
                cx = s.pesquisarCaixa(cod);

                cx.Valor_atual += p.Valor;
                cx.Valor_final += p.Valor + cx.Valor_inicial;

                s.atualizarValorAtual(cx);


                int rand = randNum.Next(50);
                SaveXML(rand);
                limpaTxt();
                MessageBox.Show("Sucesso!. Numero da Nota Fiscal : " + rand);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum problema no cadastro");
            }


        }
    }
}

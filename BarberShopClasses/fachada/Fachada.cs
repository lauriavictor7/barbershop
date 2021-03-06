﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopClasses.cliente;
using BarberShopClasses.caixa;
using BarberShopClasses.notaFiscal;
using BarberShopClasses.pagamento;
using BarberShopClasses.servico;
using BarberShopClasses.agendamento;

namespace BarberShopClasses.fachada
{
    public class Fachada : InterfaceCliente, InterfaceCaixa, InterfaceNotaFiscal, InterfacePagamento, InterfaceServico, InterfaceAgendamento
    {
        public void AtualizarAgendamento(Agendamento a)
        {
            throw new NotImplementedException();
        }

        public void AtualizarCliente(Cliente c)
        {
            NegocioCliente nC = new NegocioCliente();
            nC.AtualizarCliente(c);
        }

        public void AtualizarServico(Servico s)
        {
            throw new NotImplementedException();
        }

        public Servico buscarValor(string cpf)
        {
            throw new NotImplementedException();
        }

        public void CadastrarAgendamento(Agendamento a)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCliente(Cliente c)
        {
            NegocioCliente nC = new NegocioCliente();
            nC.CadastrarCliente(c);
        }

        public void CadastrarPagamento(Pagamento p)
        {
            throw new NotImplementedException();
        }

        public void CadastrarServico(Servico s)
        {
            throw new NotImplementedException();
        }

        public void CadastrarValor(Caixa cx)
        {
            throw new NotImplementedException();
        }

        public List<Agendamento> ListarAgendamento()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarCliente()
        {
            NegocioCliente nC = new NegocioCliente();
            return nC.ListarCliente();
        }

        public List<Servico> ListarServico()
        {
            throw new NotImplementedException();
        }

        public Servico PesquisarServico(int cod)
        {
            throw new NotImplementedException();
        }

        public void RemoverAgendamento(Agendamento a)
        {
            throw new NotImplementedException();
        }

        public void RemoverCLiente(Cliente c)
        {
            NegocioCliente nC = new NegocioCliente();
            nC.RemoverCLiente(c);
        }

        public void RemoverServico(Servico s)
        {
            throw new NotImplementedException();
        }
    }
}

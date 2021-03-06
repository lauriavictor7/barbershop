﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.servico
{
    public class NegocioServico : InterfaceServico
    {
        public void AtualizarServico(Servico s)
        {
            if (s.Preco < 0)
            {
                throw new Exception("Informe o PREÇO do Serviço. ");
            }

            if (Convert.ToString(s.Preco) == "")
            {
                throw new Exception("Informe o PREÇO do serviço. ");
            }

            if (s.Descricao == "")
            {
                throw new Exception("Informe a DESCRIÇÃO do serviço. ");
            }

            DadosServico ds = new DadosServico();
            ds.AtualizarServico(s);
        }

        public void CadastrarServico(Servico s)
        {
            if (s.Cod_serv < 0)
            {
                throw new Exception("Informe o CÓDIGO do serviço. ");
            }

            if (Convert.ToString(s.Cod_serv) == "")
            {
                throw new Exception("Informe o CÓDIGO do Serviço. ");
            }

            if (s.Preco < 0)
            {
                throw new Exception("Informe o PREÇO do Serviço. ");
            }

            if (Convert.ToString(s.Preco) == "")
            {
                throw new Exception("Informe o PREÇO do serviço. ");
            }

            if (s.Descricao == "")
            {
                throw new Exception("Informe a DESCRIÇÃO do serviço. ");
            }

            DadosServico ds = new DadosServico();
            ds.CadastrarServico(s);
        }

        public List<Servico> ListarServico()
        {
            DadosServico ds = new DadosServico();
            return ds.ListarServico();
        }

        public Servico PesquisarServico(int cod)
        {
            if (cod < 0)
            {
                throw new Exception("Informe o CÓDIGO do serviço. ");
            }

            if (Convert.ToString(cod) == "")
            {
                throw new Exception("Informe o CÓDIGO do Serviço. ");
            }

            DadosServico ds = new DadosServico();
            return ds.PesquisarServico(cod);
        }

        public void RemoverServico(Servico s)
        {
            if (s.Cod_serv < 0)
            {
                throw new Exception("Informe o CÓDIGO do serviço. ");
            }

            if (Convert.ToString(s.Cod_serv) == "")
            {
                throw new Exception("Informe o CÓDIGO do Serviço. ");
            }

            DadosServico ds = new DadosServico();
            ds.RemoverServico(s);
        }
    }
}

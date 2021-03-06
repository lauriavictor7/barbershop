﻿using BarberShopClasses.cliente;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.agendamento
{
    public class Agendamento
    {
        private int cod_ag;
        private string data;
        private string hora;
        private Cliente cliente;
        private Servico servico;

        public Agendamento()
        {
            this.cliente = new Cliente();
            this.servico = new Servico();
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public Servico Servico
        {
            get
            {
                return servico;
            }

            set
            {
                servico = value;
            }
        }

        public int Cod_ag
        {
            get
            {
                return cod_ag;
            }

            set
            {
                cod_ag = value;
            }
        }
    }
}

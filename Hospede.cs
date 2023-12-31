﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apredizado
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public DateTime Nascimento { get; set; }
        public string NumeroQuarto { get; set; }
        public string Cpf { get; set; }
        public int Diashospedado { get; set; }
        public double Pagar { get; set; }


        public Hospede(string nome, string telefone, string email, string cpf, DateTime checkIn, DateTime checkOut, DateTime nascimento, string numeroQuarto, int diashospedado, double valor)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataCheckIn = checkIn;
            DataCheckOut = checkOut;
            NumeroQuarto = numeroQuarto;
            Diashospedado = diashospedado;
            Pagar = valor;
            Cpf = cpf;
            Nascimento = nascimento;
        }
    }

}

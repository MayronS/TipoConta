using System;
using Interfaces;

namespace Contas
{
    public class ContaPoupanca : IConta, Irendimento
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double valor { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(string nome, string cpf, double valor)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.valor = valor;

        }


        public double valorComRendimento()
        {
            return valor + valor * 8 / 100;
        }


        public void saldoFinal()
        {
            Console.WriteLine($"Previsão de saldo para daqui a 1 ano: R$ {valorComRendimento()}");
        }


    }
}
using System;
using Interfaces;

namespace Contas
{
    public class ContaCDB : IConta, Irendimento
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double valor { get; set; }

        public double saldoComRendimento { get; private set; }

        public ContaCDB() { }

        public ContaCDB(string nome, string cpf, double valor)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.valor = valor;

        }

        public double valorComRendimento()
        {
            return valor + valor * 12 / 100;
        }

        public void saldoFinal()
        {
            Console.WriteLine($"Previsão de saldo para daqui a 1 ano: R$ {valorComRendimento()}");
        }
    }

}
using System;
using Interfaces;
namespace Contas
{
    public class ContaCorrente : IConta
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double valor { get; set; }

        public ContaCorrente() { }

        public ContaCorrente(string nome, string cpf, double valor)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.valor = valor;

        }

        public void saldoFinal()
        {
            Console.WriteLine($"Previsão de saldo para daqui a 1 ano: R$ {valor}");
        }
    }
}
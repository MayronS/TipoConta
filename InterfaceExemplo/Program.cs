using System;

using Interfaces;
using Contas;

/*
Conta corrente: CC
Conta poupança: CP
Conta CDB: CDB

Tipo de conta: CDB
Nome: Maria
CPF: 98139905038
valor: R$ 100,00

Tipo de conta: CP
Nome: Joao
CPF: 54094737014
valor: R$ 450,00

Tipo de conta: CC
Nome: Luana
CPF: 65752468000
valor: R$ 1000,00
*/


namespace Program
{
  public class Program
  {
    public static void Main(String[] sqrt)
    {
      int qntClientes;
      string tipoConta;
      string nome;
      string cpf;
      double valor;
      List<IConta> contas = new List<IConta>();

      Console.WriteLine("Digite a quantidade de clientes: ");
      qntClientes = int.Parse(Console.ReadLine());

      for (int i = 0; qntClientes > i; i++)
      {
        Console.WriteLine("Qual tipo de conta Deseja escolher:");
        tipoConta = Console.ReadLine();
        Console.WriteLine("Nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("CPF: ");
        cpf = Console.ReadLine();

        Console.WriteLine("Valor: ");
        valor = double.Parse(Console.ReadLine());


        if (tipoConta.ToLower() == "cc")
        {
          contas.Add(new ContaCorrente(nome, cpf, valor));
        }
        else if (tipoConta.ToLower() == "cp")
        {
          contas.Add(new ContaPoupanca(nome, cpf, valor));
        }
        else if (tipoConta.ToLower() == "cdb")
        {
          contas.Add(new ContaCDB(nome, cpf, valor));
        }
        else
        {
          Console.WriteLine("Tipo de conta inválida. Tente novamente.");
          i--;
        }

      }

      foreach (IConta list in contas)
      {
        Console.WriteLine($"Nome: {list.nome}");
        Console.WriteLine($"CPF: {list.cpf}");
        list.saldoFinal();
        Console.WriteLine("");
      }
    }
  }
}
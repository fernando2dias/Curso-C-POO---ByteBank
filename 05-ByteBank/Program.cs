using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente fernando = new Cliente();
            fernando.nome = "Fernando";
            fernando.cpf = "234234234";
            fernando.profissao = "Web Developer";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = fernando;

            Console.WriteLine(fernando.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();


        }
    }
}

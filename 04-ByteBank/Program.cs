using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaFernando = new ContaCorrente();

            contaFernando.titular = "Fernando";
            contaFernando.Sacar(45.20);

            Console.WriteLine(contaFernando.saldo);

            contaFernando.Depositar(500);

            Console.WriteLine(contaFernando.saldo);

            ContaCorrente contaJuba = new ContaCorrente();
            contaJuba.titular = "Jubela";

            contaFernando.Transferir(300, contaJuba);

            Console.WriteLine("meu saldo: " + contaFernando.saldo);
            Console.WriteLine("saldo juba" + contaJuba.saldo );
            contaJuba.Sacar(100);

            Console.WriteLine("saldo belico " + contaJuba.saldo);
            contaJuba.Transferir(200, contaFernando);

            Console.WriteLine("saldo do fer: " + contaFernando.saldo);


            Console.ReadLine(); 

        }
    }
}

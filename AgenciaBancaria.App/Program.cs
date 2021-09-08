using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Av.Gato Vesgo", "12345678", "Jaçoiaba do Leste", "PI");  
                Cliente cliente = new Cliente("Aristeu Barbosa", "123456", "456789", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 150);

                Console.WriteLine("Conta " +  conta.NumeroConta + "-" + conta.DigitoVerificador + " " + conta.Situacao + " com sucesso." );

                string senha = "abcde123";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.NumeroConta + "-" + conta.DigitoVerificador + " " + conta.Situacao + " com sucesso.");

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
                 
    }
}


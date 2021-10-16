using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args) 
            {

            try {
                Endereco endereco = new Endereco("Rua Erasmo", "98765432", "Rua carnauba", "BH");
                Cliente cliente = new Cliente

                    ("Vanessa", "09878909876", "8765432", endereco);

                ContaBancaria conta = new ContaBancaria(cliente);


            }
           
            catch(Exception ex) {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}

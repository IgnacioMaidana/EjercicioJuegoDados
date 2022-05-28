using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();

            cliente.GetDado();
            
            Console.WriteLine("dados!");

            while (true/*metodo que devuelva un bool, verifica si la cantidad>1*/)
            {
                Console.WriteLine("Tiro {cantDados} Dados: {metodo que devuelva la lista de dados}");
                Console.WriteLine("Suma de puntos: {puntos}");
                Console.WriteLine("Dados restantes: {restante}");
                Console.WriteLine();                
            }

            Console.ReadLine();
        }
    }
}

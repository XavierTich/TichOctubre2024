using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            ticket.listaArticulos.Add(new ArticuloTich());
            ticket.listaArticulos.Add(new ArticuloXavier());         
            ticket.listaArticulos.Add(new XavOfeta());    
            ticket.Imprimir();
            ticket.listaArticulos.Add(new ArticuloJose());
            Console.ReadKey();  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication27.ServiceReference1;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client())
            {
               Console.WriteLine( client.GetSameInt());
                var data = client.GetData(Guid.NewGuid());
                Console.WriteLine($"Id: {data}, Name: {data.Name}");
            }
            //Та-дам)))) И все работает)
            Console.ReadKey();
        }
    }
}

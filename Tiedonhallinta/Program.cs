using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedonhallinta {
    class Program {
        static void Main(string[] args) {

            int lampotila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string userinput = Console.ReadLine();

            lampotila = int.Parse(userinput);

            string newFile = @"C:\Temp\Lämpötila.txt";
            File.WriteAllText(newFile, lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");

            Console.ReadLine();
        }
    }
}

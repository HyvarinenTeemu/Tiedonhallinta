using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedonhallinta {
    class Program {
        static void Main(string[] args) {

            string newFile = @"C:\Temp\Lämpötila.txt";

            //read from file temperature setup recently
            if(File.Exists(newFile)) {
                string prevTemp = File.ReadAllText(newFile);
                Console.WriteLine("Aiemmin annettu lämpötila " + prevTemp);
            } else {
                Console.WriteLine("Aseta ensimmäinen lämpötila");
            }

            int lampotila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string userinput = Console.ReadLine();

            lampotila = int.Parse(userinput);

            
            File.WriteAllText(newFile, lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");

            Console.ReadLine();
        }
    }
}

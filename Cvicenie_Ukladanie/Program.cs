using System.Data;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;

namespace Cvicenie_Ukladanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*osoba osoba = new osoba("Igor", 17);
            osoba osoba1 = new osoba("Peter", 27);
            osoba osoba2 = new osoba("Jano", 37);
            string line = osoba.UdajeOddelenCiarkou();
            string lineOs = osoba.UdajeOddelenCiarkou();
            string subor = "osoba.txt";
            File.WriteAllText(subor, lineOs);
            
                List<string> data = new List<string>();
            string Line1 = osoba.UdajeOddelenCiarkou();
            data.Add(Line1);
            data.Add(osoba2.UdajeOddelenCiarkou());
            data.Add(osoba2.UdajeOddelenCiarkou());
            File.WriteAllLines(subor, data);*/

            /*Console.WriteLine("Napis co treba");
            string subor = "osoba.txt";
            string command = Console.ReadLine();
            if (command == "write")
            {
                osoba osoba1 = new osoba("Igor", 17);
                File.WriteAllText(subor, data);
            }
            if (command == "read")
            {
                string read = File.ReadAllText(subor);
                string[] dataArr = read.Split(",");
                string name = dataArr[0];
                int vek =int.Parse(dataArr[1]);
                osoba nacitana = new osoba(name,vek);
            }*/

            Console.WriteLine("Napis co treba");
            string subor = "osoba.txt";
            string command = Console.ReadLine();
            if (command == "write") ;
            { 
            osoba osoba1 = new osoba("Igor", 17);
            osoba osoba2 = new osoba("Jano", 27);
            osoba osoba3 = new osoba("Peter", 37);
             List<osoba> ludia = new List<osoba>();
                ludia.Add(osoba1);
                ludia.Add(osoba2); 
                ludia.Add(osoba3);
                string json = JsonSerializer.Serialize(ludia);
                File.WriteAllText(subor, json);
            }
            if (command == "read")
            {
                if (!File.Exists(subor))
                {
                    Console.WriteLine("subor neexistuje");
                    return;
                }
               string celySuborNacitany = File.ReadAllText(subor);
                List<osoba> ludia = JsonSerializer.
                    Deserialize<List<osoba>>(celySuborNacitany);

                foreach (osoba o in ludia)
                {
                    Console.WriteLine(o.Meno + " " + o.Vek);
                }
            }

           
        }
    }
}

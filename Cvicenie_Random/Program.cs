using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Cvicenie_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random generator = new Random();
            int cislo = generator.Next(0, 5);
            double number = generator.Next();*/

            /*Random r = new Random();
            int ct = 0;
            for (int i = 0; i < 100; i++)
            {
                bool result = Prob(r);
                if (result == true)
                { 
                    ct++;
                }
                Console.WriteLine("True bolo: "+ct+"x");

            }*/

            Random r = new Random();


            var femaleFirstNames = new List<string>
{
    "Anna","Mária","Katarína","Zuzana","Lucia","Kristína","Monika","Veronika","Lenka","Petra",
    "Michaela","Eva","Jana","Jarmila","Martina","Barbora","Adriana","Alexandra","Alžbeta","Alica",
    "Daniela","Diana","Dominika","Natália","Nikola","Nikoleta","Silvia","Simona","Ivana","Iveta",
    "Ingrid","Renáta","Gabriela","Miriam","Pavlína","Laura","Karolína","Klára","Tatiana","Tereza",
    "Beáta","Bianka","Rebeka","Nela","Ema","Ela","Tamara","Viktória","Zora","Žaneta"
};

            var maleFirstNames = new List<string>
{
    "Peter","Martin","Jozef","Tomáš","Lukáš","Jakub","Michal","Marek","Andrej","Anton",
    "Samuel","Dominik","Richard","Róbert","Roman","Patrik","Filip","Juraj","Karol","Daniel",
    "Dávid","Adam","Erik","Igor","Ivan","Ľubomír","Pavol","Stanislav","Štefan","Matej",
    "Matúš","Vladimír","Viliam","Radovan","Rastislav","Šimon","Sebastián","Eduard","Marián","Gabriel",
    "Tobiáš","Boris","Alan","Oliver","Oskar","Leonard","Viktor","Alex","Benjamin","Tadeáš"
};
            var femaleSurnamesSk = new List<string>
{
    "Nováková","Horváthová","Kováčová","Vargová","Tóthová","Nagyová","Molnárová","Szabóová","Lukáčová","Kučerová",
    "Poláková","Kráľová","Urbanová","Krajčíová","Kováčiková","Kubišová","Holubová","Benková","Blašková","Mareková",
    "Tomášová","Balážová","Farkašová","Bartošová","Šimková","Pavlíková","Michalíková","Černáková","Švecová","Ševčíková",
    "Juríková","Hrušková","Chovancová","Rácová","Hudáková","Ondrušová","Sokolová","Pospíšilová","Gašparová","Gregorová",
    "Valentová","Ďuricová","Ďurišová","Vavrová","Žáková","Koreňová","Červeňová","Šramková","Mrázová","Mrvová"
};

            var maleSurnamesSk = new List<string>
{
    "Novák","Horváth","Kováč","Varga","Tóth","Nagy","Molnár","Szabó","Lukáč","Kučera",
    "Polák","Kráľ","Urban","Krajčí","Kováčik","Kubiš","Holub","Benko","Blaško","Marek",
    "Tomáš","Baláž","Farkaš","Bartoš","Šimko","Pavlík","Michalík","Černák","Švec","Ševčík",
    "Jurík","Hruška","Chovanec","Rác","Hudák","Ondruš","Sokol","Pospíšil","Gašpar","Gregor",
    "Valent","Ďurica","Ďuriš","Vavro","Žák","Koreň","Červeň","Šramko","Mráz","Mrva"
};


            string muzskemeno = GetRandomString(maleFirstNames, r);
            string Mpriezvisko = GetRandomString(maleSurnamesSk, r);
            string fmeno = GetRandomString(femaleFirstNames,r);
            string fpriezvisko = GetRandomString(femaleSurnamesSk, r);

            Persone zena = new Persone("Anna", "Biela");
            Persone muz = new Persone(muzskemeno, Mpriezvisko);

            

            //Console.WriteLine(muzskemeno + Mpriezvisko);
            //Console.WriteLine(fmeno + fpriezvisko);
        }
        /*public static bool Prob(Random r)
        {
            int nahodnecislo = r.Next(0, 101);
            if (nahodnecislo < 73)
            {
                return true;
            }
            return false;
        }*/

        public static string GetRandomString(List<string> strings, Random r)
        {
            int count = strings.Count;
            int index = r.Next(count);
            string name = strings[index];
            return name;
        }
    }
}

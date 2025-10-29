using System.Text;
using System.Xml;

namespace Cvicenie_Objekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            /*string name = "Oleksandra Katrushenko";
            string adress = "Zilina";
            int age = 15; 

            string name2= "Davyd Khanchenko";
            string adress2 = "Zilina";
            int age2 = 16;*/

            Student student1 = new Student();
            student1.Name ="Oleksandra Katrushenko";
            student1.Age = 15;
            student1.Adres = "Zilina";
            student1.Pohlavie = 'Z';

            Student student2 = new Student();
            student2.Name = "Davyd Khanchenko";
            student2.Age = 16;
            student2.Adres = "Zilina";
            student2.Pohlavie = 'M';
            

            Student staryStudent = student1;
            staryStudent.Name = "Peter Novak";
            //Console.WriteLine(staryStudent.Name);
            //Console.WriteLine(student1.IsAdult())

            student1.AddName = ("Novak");
            Console.WriteLine(student1.AddName);



            

        }
    }
}

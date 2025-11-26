namespace Cvicenie_Pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random r = new Random();
            int value = r.Next(0, 100);
            if (value < 80) // 80 na 20
            {
                Console.WriteLine("Vyhral 80");
            }
            else
            {
                Console.WriteLine("Vyhral  20");
            }*/

            Student student = new Student("Michal", 5);
            Student student1 = new Student("Roman", 15);
            Student student2 = new Student("Peter", 25);
            Student student3 = new Student("Matus", 55);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student);

            List<Student> klobucik = new List<Student>();
            foreach (Student stud in students)
            {
                for (int i = 0; i < stud.TicketCount; i++)
                {
                    klobucik.Add(stud);
                }
            }
            Random r = new Random();
            int index = r.Next(klobucik.Count);
            Student vyherca = klobucik[index];
            Console.WriteLine(vyherca.Meno + vyherca.TicketCount);


        }
    }
}

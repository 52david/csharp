namespace Cvicenie_DayTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            foreach (var s in args)
            {
                //
                //
                //
            }
            DateTime dt2 = DateTime.Now;
            TimeSpan ts = dt2 - dt;
            Console.WriteLine(ts.TotalMilliseconds);
            DateTime birthday = new DateTime(year: 2009, month: 10, day: 20,hour: 8, minute: 29, second:26);
            string datum = "20.10.2009";
            DateTime dat = DateTime.Now;
            Console.WriteLine(dat.ToString("dd.MM.yyyy"));
        }
    }
}

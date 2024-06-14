using System;
using System.Globalization;

namespace EstudosTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30); //hora, minuto, segundo
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);//hora, minuto, segundo
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);//dia ,hora, minuto, segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);//dia ,hora, minuto, segundo, milissegundos

            TimeSpan y1 = TimeSpan.FromDays(1.5); //traz um resultado de 1 dia e meio, no caso 1 dia e 12 horas
            TimeSpan y2 = TimeSpan.FromHours(1.5); //resultado de 1 hora e meia
            TimeSpan y3 = TimeSpan.FromMinutes(1.5); //resultado de 1 minuto e meio
            TimeSpan y4 = TimeSpan.FromSeconds(1.5);//resultado de 1 segundo e meio
            TimeSpan y5 = TimeSpan.FromMilliseconds(1.5);//resultado de 1 milissegundo e meio
            TimeSpan y6 = TimeSpan.FromTicks(900000000L); //resultado por ticks


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
            Console.WriteLine(y5);
            Console.WriteLine(y6);
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace EstudosTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan r1 = new TimeSpan(1, 30, 10);
            TimeSpan r2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = r1.Add(r2); //fez a soma dos dois horarios
            TimeSpan dif = r1.Subtract(r2); //faz a subtração a diferença
            TimeSpan mult = r2.Multiply(2.0); //multiplicação do tempo
            TimeSpan div = r2.Divide(2.0); //divisão

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


            Console.WriteLine();
            Console.WriteLine("------------------------------");

            TimeSpan q1 = TimeSpan.MaxValue; //vai pegar a duração maxima possivel de se guardar em um timespan
            TimeSpan q2 = TimeSpan.MinValue; //valor minimo q se pode guardar
            TimeSpan q3 = TimeSpan.Zero;//duração 0

            Console.WriteLine(q1);
            Console.WriteLine(q2);
            Console.WriteLine(q3);
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            TimeSpan w = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(w);
            Console.WriteLine(w.Days); //saber o numero de dias
            Console.WriteLine(w.Minutes);//saber o numero de minutos
            Console.WriteLine(w.Milliseconds);//saber o numero de milissegundos
            Console.WriteLine(w.Seconds);//saber o numero de segundos
            Console.WriteLine(w.Ticks);//saber o tick
            Console.WriteLine(w.TotalDays); //total de tudo em dias
            Console.WriteLine(w.TotalHours); //total de tudo em horas
            Console.WriteLine(w.TotalMinutes); //total de tudo em minutos
            Console.WriteLine(w.TotalSeconds); //total de tudo em segundos
            Console.WriteLine(w.TotalMilliseconds); //total de tudo em milissegundos

            Console.WriteLine();
            Console.WriteLine("------------------------");

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

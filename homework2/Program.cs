using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main (string[] args)
        {
            string      fullName = "Титов Аким (Андреевич)";
            int         age = 26;
            string      eMail = "takda.cs@gmail.com";
            float       programmingScores = 16; // Будем считать, что с программированием все плохо ) 
            float       mathScores = 51;
            float       physicsScores = 49;

            Console.WriteLine($"ФИ(О*): {fullName, 22} " +
                $"\nВозраст: {age, 21} " + 
                $"\nEmail: {eMail, 23} " +
                $"\nБаллы по программированию: {programmingScores, 3} " +
                $"\nБаллы по математике: {mathScores, 9} " +
                $"\nБаллы по физике: {physicsScores, 13} " +
                $"\n* отчество выводится при наличии");
            Console.ReadKey();

            float       totalPoints;
            totalPoints = programmingScores + mathScores + physicsScores;
            Console.WriteLine($"Сумма баллов: { totalPoints, 16}");
            Console.ReadKey();

            float       averageScore;
            averageScore = totalPoints / 3;
            Console.WriteLine($"Средний балл: { averageScore.ToString("#.#"),16}");
            Console.ReadKey();
        }
    }
}

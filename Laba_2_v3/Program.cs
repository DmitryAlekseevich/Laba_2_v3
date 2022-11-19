using Laba_2_v3;
using Laba2;
using Peredelanaya_Laba_2_3var;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_v3
{
    class Program
    {
        private static object team;

        static void Main(string[] args)

        {
            TickCounter tc = new TickCounter();
            char[] Separators = { '+', '-' };
            ResearchTeam st = new ResearchTeam();
            Paper[] _ex = { new Paper() };
            st.AddPapers(_ex);
            Console.WriteLine(st.ToFullString() + "\n\n\n\n");
            st._nazvanieisled = new Person("Квадратный", "Колобок", new DateTime(2009, 1, 1));
            st._regnomer = 20;
            Paper[] papers = new Paper[5];
            papers[0] = new Paper("Космический нинздя", new DateTime(1887, 6, 1));
            papers[1] = new Paper("ООО Колобок", new DateTime(1889, 8, 21));
            papers[2] = new Paper("ООО Колобок", new DateTime(1889, 8, 21));
            papers[3] = new Paper("ООО Колобок", new DateTime(1889, 8, 21));
            papers[4] = new Paper("ООО Колобок", new DateTime(1889, 8, 21));

            //team.AddPapers(papers);

            //st.Education = TimeFrame.Year;
            //Console.WriteLine(st.ToFullString());
            //Console.WriteLine("Средний рейтинг: " + st.AverageGrade);

            Console.WriteLine("Ввести число строк: ");
            int nrow, ncolumn;

            Console.WriteLine("Введите число строк и столбцов, используя разделители: + или -");
            string UserInput = Console.ReadLine();
            string[] SeparatedInput = UserInput.Split(Separators); //Возвращает строковый массив, содержащий подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.
            if (SeparatedInput.Length < 2)
            {
                Console.WriteLine("Неверный формат. Пример ввода: 43+6");
                Console.ReadKey();
                return;

            }
            nrow = Convert.ToInt32(SeparatedInput[0]);
            ncolumn = Convert.ToInt32(SeparatedInput[1]);
            Console.WriteLine(nrow + " " + ncolumn);
            //одномерный

            Paper[] ex = new Paper[nrow * ncolumn];

            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    ex[j] = new Paper();
                }
            }
            tc.Start();
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    ex[j].Evaluation = 5;
                }
            }
            tc.Finish();
            Console.WriteLine($"Одномерный массив:{tc.TickCount} тиков");

            //двумерный(прямоугольный)
            Paper[,] ex2 = new Paper[nrow, ncolumn];
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    ex2[i, j] = new Paper();
                }
            }
            tc.Start();

            for (int i = 0; i < nrow; i++)
                for (int j = 0; j < ncolumn; j++)
                {
                    ex2[i, j].Evaluation = 5;
                }
            tc.Finish();
            Console.WriteLine($"Двумерный массив(прямоугольный):{tc.TickCount} тиков");

            //двумерный ступенчатый
            Paper[][] ex3 = new Paper[nrow][];
            for (int i = 0; i < nrow; i++)
            {
                ex3[i] = new Paper[ncolumn];
                for (int j = 0; j < ncolumn; j++)
                {
                    ex3[i][j] = new Paper();
                }
            }
            tc.Start();
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    ex3[i][j].Evaluation = 5;
                }
            }
            tc.Finish();
            Console.WriteLine($"Двумерный массив(ступенчатый):{tc.TickCount} тиков");
            Console.ReadKey();
        }



    }
}
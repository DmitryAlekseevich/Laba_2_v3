namespace AllStaffNet6.laba2
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("У вас есть выбор!!! разделителя: 1) ':', 2) ';'");
            char separator = Console.ReadKey().KeyChar;
            Console.WriteLine("Введите кол-во столбцов и кол-во строк через разделитель:");
            string value = Console.ReadLine();
            string[] splitted = value.Split(separator);
            int nrow = Convert.ToInt32(splitted[1]);
            int ncolumn = Convert.ToInt32(splitted[0]);

            Paper[] papersOneD = new Paper[nrow * ncolumn];
            Paper[,] papersTwoD = new Paper[nrow, ncolumn];
            Paper[][] papersStepwise = new Paper[nrow][];

            var stopWatch = System.Diagnostics.Stopwatch.StartNew();

            stopWatch.Start();

            for (int i = 0; i < papersOneD.Length; i++)
            {
                papersOneD[i] = new();
                papersOneD[i].Title = "sdasd";
            }
            stopWatch.Stop();

            Console.WriteLine($"Время загрузки: {stopWatch.Elapsed:mm\\:ss\\:ff}");

            stopWatch.Reset();

            stopWatch.Start();

            for (int i = 0; i < papersTwoD.GetLength(0); i++)
            {
                for (int k = 0; k < papersTwoD.GetLength(1); k++)
                {
                    papersTwoD[i, k] = new();
                    papersTwoD[i, k].Title = "sdasd";
                }
            }

            stopWatch.Stop();

            Console.WriteLine($"Время выгрузки: {stopWatch.Elapsed:mm\\:ss\\:ff}\n");

            stopWatch.Reset();

            stopWatch.Start();

            for (int i = 0; i < papersStepwise.Length; i++)
            {
                papersStepwise[i] = new Paper[ncolumn]; // элемент массива с размерностью ncolumn

                for (int j = 0; j < papersStepwise[i].Length; j++)
                {
                    papersStepwise[i][j] = new();
                    papersStepwise[i][j].Title = "sdasd";
                }
            }

            stopWatch.Stop();

            Console.WriteLine($"Тики после ступенчатого: {stopWatch.Elapsed:mm\\:ss\\:ff}\n");

            Paper[] papers = new Paper[] //Вписать новые эти самые
            {
                    new Paper("Ленин был грибом??", new Person("Суетолог", "Суетологович", new DateTime(2000, 4, 29)), new DateTime(2024, 12, 4)),
                    new Paper("Статья о важном", new Person("Ашот", "Калашников", new DateTime(2000, 4, 26)), new DateTime(2026, 12, 4)),
                    new Paper("Киберспорт", new Person("ААААА", "БББББ", new DateTime(2000, 4, 26)), new DateTime(2026, 12, 4)),
                   

            };
            ResearchTeam research = new ResearchTeam("Исследование древнего мира", "Был ли древний мир?", 22141251, TimeFrame.Long, papers);
            Console.WriteLine(research.ToFullString());
            research.AddPapers(new Paper());
           // Console.WriteLine(research.PaperLast.Title);
        }
        //private static void Main(string[] args)
        //{

        //}
    }
}
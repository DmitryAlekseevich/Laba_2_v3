using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_v3
{
    class Paper
    {
        public string Name; //Название экзамена
        public int Evaluation; //Оценка
        public System.DateTime DateOfExam; //Дата проведения экзамена
        private string v;
        private DateTime dateTime;

        public Paper(string name, int eval, DateTime date)
        {

            Name = name;
            Evaluation = eval;
            DateOfExam = date;
        }

        public Paper()
        {
            Name = "Ленин был грибом??!";
            Evaluation = 5;
            DateOfExam = new DateTime(2022, 10, 10);

        }

        public Paper(string v, DateTime dateTime)
        {
            this.v = v;
            this.dateTime = dateTime;
        }

        public string ToFullString()
        {
            return "Название экзамена: " + Name + "\n" +
                "Оценка: " + Evaluation + "\n" +
                "Дата проведения экзамена: " + DateOfExam.ToLongDateString() + "\n" + "\n";
        }


    }

}

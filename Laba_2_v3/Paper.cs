using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_v3
{
    public class Paper
    {
        public string Title { get; set; }
        public Person Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public Paper(string title, Person author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }
        public Paper()
        {
            Title = "Ленин был грибом????";
            Author = new();
            PublicationDate = new(2009, 8, 25, 11, 12, 13);
        }
        public string ToFullString() => $"Полей нет, есть только свойства";
    }
}

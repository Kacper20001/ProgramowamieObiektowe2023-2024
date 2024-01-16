using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class DocumentaryBook : Book
    {
        private string topic;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public DocumentaryBook(string title, Person author, DateTime dateOfPublication, string topic) :
            base(title, author, dateOfPublication)
        {
            Topic = topic;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Topic: {Topic}");
        }
    }
}

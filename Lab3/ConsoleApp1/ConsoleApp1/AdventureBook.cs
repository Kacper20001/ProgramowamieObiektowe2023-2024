using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class AdventureBook : Book
    {
        private string mainCharacter;

        public string MainCharacter
        {
            get { return mainCharacter; }
            set { mainCharacter = value; }
        }

        public AdventureBook(string title, Person author, DateTime dateOfPublication, string mainCharacter) :
            base(title, author, dateOfPublication)
        {
            MainCharacter = mainCharacter;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Main Character: {MainCharacter}");
        }
    }
}

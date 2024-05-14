using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDecorator2
{
    public class Book
    {
        public string Title { get; set; } 
        public string Author { get; set; } 
        public int Copies { get; set; } 

        public virtual void Loan()
        {
            if (Copies <= 0)
            {
                Console.WriteLine("Book not available");
            }
            else
            {
                Copies--;
            }
        }
    }


}

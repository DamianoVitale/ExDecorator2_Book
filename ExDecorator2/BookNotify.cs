using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDecorator2
{
    public class BookNotify : BookDecorator
    {
        public BookNotify(Book book) : base(book)
        {
        }

        public void Notify()
        {
            if (base.ExpiryDate > DateTime.Now)
            {
                Console.WriteLine("email sent due to late delivery");
            }
            else
            {
                Console.WriteLine("days not yet over");
            }
        }
    }
}

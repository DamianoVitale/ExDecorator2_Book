using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDecorator2
{
    public abstract class BookDecorator : Book
    {
        public DateTime ExpiryDate { get; set; }
        private  Book book;
        public BookDecorator(Book book) 
        {
            this.book = book;
        }

        public override void Loan()
        {
            book.Loan();
            ExpiryDate = DateTime.Now.AddDays(7);
        }
    }
}

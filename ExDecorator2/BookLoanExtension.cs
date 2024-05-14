using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDecorator2
{
    internal class BookLoanExtension : BookDecorator
    {
        public BookLoanExtension(Book book) : base(book)
        {
        }
        public void ExtendLoan(int days)
        {
            ExpiryDate = ExpiryDate.AddDays(days);
            Console.WriteLine($"Loan extended for {days} days");
        }
    }
}

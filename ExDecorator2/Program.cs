// See https://aka.ms/new-console-template for more information
using ExDecorator2;

var book = new Book()
{
    Title = "Il signore degli anelli",
    Author = "J.R.R Tolkien",
    Copies = 20
};

var bookLoan = new BookLoanExtension(book);
bookLoan.Loan();
Console.WriteLine(book.Copies);
Console.WriteLine(bookLoan.ExpiryDate.ToString("dd/MM/yyyy"));
bookLoan.ExtendLoan(7);
Console.WriteLine(bookLoan.ExpiryDate.ToString("dd/MM/yyyy"));
var bookNotify = new BookNotify(bookLoan);
bookNotify.Notify();


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Disaheim
//{
//    public class BookRepository
//    {
//        private List<Book> books = new List<Book>();
//        public void AddBook(Book book)
//        {
//            books.Add(book);
//        }

//        public Book GetBook(string itemId)
//        {
//            return books.Find(x => x.ItemId.Contains(itemId));
//            //if (itemId exists do - Else return null; ->> Hvis der findes en bog i books, der har itemID som ItemId, returneres denne, ellers returneres null .
//        }
//        public double GetTotalValue()
//        {
//            double totalPrice = 0;
//            foreach (Book b in books)
//            {
//                totalPrice += b.Price;
//            }
//            return totalPrice;
//        } //Den samlede værdi af alle bøger i books returneres.

//    }
//}

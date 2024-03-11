using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> a()
        {
            return ListOfBooks.Where(BookDetails=>BookDetails.Price > 30);
        }
        public IEnumerable<BookDetails> b()
        {
            return ListOfBooks.OrderBy(BookDetails => BookDetails.Id);
        }
        public IEnumerable<BookDetails> c()
        {
            var result= ListOfBooks.Where(BookDetails => BookDetails.IsComics=true).Select(BookDetails => BookDetails.Price);
            return result;
        }
        public IEnumerable<BookDetails> d()
        {
            var result = ListOfBooks.Where(for9).Select(BookDetails => BookDetails.Name);
            return result;
        }

        private bool for9(BookDetails BookDetails)
        {
            if(BookDetails.MaxAge>9&& BookDetails.MinAge<9)
              return true; 
            return false;
        }
    }
    
}

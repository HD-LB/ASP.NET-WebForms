using LibrarySystemLiveDemo.Data.Models;
using System.Linq;

namespace LibrarySystemLiveDemo.MVP.Books
{
    public class BooksViewModel
    {
        public IQueryable<Category> Categories { get; set; }
    }
}

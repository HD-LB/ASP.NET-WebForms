using LibrarySystemLiveDemo.Data.Models;
using System.Linq;

namespace LibrarySystemLiveDemo.MVP.Search
{
    public class SearchViewModel
    {
        public IQueryable<Book> Books { get; set; }
    }
}

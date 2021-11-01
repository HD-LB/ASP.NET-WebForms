using LibrarySystemLiveDemo.Data.Models;
using LibrarySystemLiveDemo.MVP.Books;
using LibrarySystemLiveDemo.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystemLiveDemo.MVP.Tests.Books.BooksPresenterTests
{
    [TestFixture]
    public class View_OnCategoriesGetData_Should
    {
        [Test]
        public void AddCategoriesToViewModel_WhenOnCategoriesGetDataEventIsRaised()
        {
            //Arrange
            var viewMock = new Mock<IBooksView>();
            viewMock.Setup(v => v.Model).Returns(new BooksViewModel());

            var categories = GetCAtegoriesWithBooks();
            var categoryServiceMock = new Mock<ICategoryService>();
            categoryServiceMock.Setup(c => c.GetAllCategoriesWithBooksIncluded()).Returns(GetCAtegoriesWithBooks());

            BooksPresenter booksPresenter = new BooksPresenter(viewMock.Object, categoryServiceMock.Object);

            //Act
            viewMock.Raise(v => v.OnCategoriesGetData += null, EventArgs.Empty);

            //Assert
            CollectionAssert.AreEqual(categories, viewMock.Object.Model.Categories);
        }

        private void V_OnCategoriesGetData(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private IQueryable<Category> GetCAtegoriesWithBooks()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Category 1",
                    Books = new List<Book> {new Book() { Id = Guid.NewGuid() } }
                },

                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Category 2"
                }
            }.AsQueryable();
        }
    }
}

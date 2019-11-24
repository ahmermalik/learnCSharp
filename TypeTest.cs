using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42,x);
        }

        private void SetInt(ref int x)
        {
           x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name"); // it is important to write ref so the reader can understand the var is a ref and could have been changed

            Assert.Equal("New Name", book1.Name);
        }

        
        private void GetBookSetName(ref Book book, string name)   // ref gives memory reference to the variable in memory. 
        {
           book = new Book(name);
           book.Name = name;
        }
        

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange      
            var book1 = GetBook("Book 1");
             GetBookSetName(ref book1, "New Name");  // sets New Name for book1
            // act 
           
            // assert
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange      
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            // act 
           
            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2",book2.Name);
            Assert.NotSame(book1, book2);
        }

                [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange      
            var book1 = GetBook("Book 1");
            var book2 = book1;
            // act 
           
            // assert
          Assert.Same(book1, book2);  //checks for references, that both books are point to the same memory
            Assert.True(Object.ReferenceEquals(book1, book2));  //checks for references, that both books are point to the same memory
        }

        Book GetBook(string name)   // return type 'Book' is an object, which is the lowest base type in .Net
        {
          return new Book(name);
        }
    }
}

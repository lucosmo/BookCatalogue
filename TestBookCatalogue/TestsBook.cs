namespace TestBookCatalogue
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Book_IfExists_True()
        {
            //Arrange
            Book book = new Book();
            //Act
            //Assert
            Assert.That(typeof(Book).Equals(book.GetType()));
        }
        
        [Test]

    }
}
using System;
using System.Security.Cryptography.X509Certificates;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStarRating_ShouldSetCorrectInt()
        {
            StreamingContent content = new StreamingContent();
            content.StarRating = 5;

            int expected = 5;
            int actual = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetDescription_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Description = "bromance between Woody and Buzz";

            string expected = "bromance between Woody and Buzz";
            string actual = "bromance between Woody and Buzz";

            Assert.AreEqual(expected, actual);

        }

        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            //Act
            content.TypeOfGenre = typeOfGenre;
            //Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}

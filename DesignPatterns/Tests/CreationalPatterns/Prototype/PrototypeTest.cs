using FluentAssertions;
using PrototypePattern;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.CreationalPatterns.Prototype
{
    public class PrototypeTest
    {
        [Fact]
        public void AuthorTest()
        {
            AuthorForShallowCopy author = new AuthorForShallowCopy()
            { 
                Name = "Oscar Cama",
                TwitterAccount = "http://twitter.com/OscarCama",
                HomeAddress = new Address()
                {
                    City = "Cercado de Lima",
                    State = "Lima"
                }
            };

            AuthorForShallowCopy cloneAuthor = (AuthorForShallowCopy)author.Clone();

            author.Name.Should().Equals(cloneAuthor.Name);

            cloneAuthor.Name = "Jose";

            cloneAuthor.Name.Should().NotBe(author.Name);
        }
    }
}

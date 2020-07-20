using System;
using Xunit;

using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          var sut = new Class1();

          var actual = sut.Checker();

          Assert.True(actual);
        }
    }
}

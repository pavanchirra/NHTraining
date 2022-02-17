using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            //Arrange
            int n = 131;
            bool expected = true;

            //Act
           bool actual = Algebra.IsPalindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
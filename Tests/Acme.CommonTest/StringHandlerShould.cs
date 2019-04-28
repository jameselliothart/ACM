using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerShould
    {
        [TestMethod]
        public void InsertSpaceOnPascalCase()
        {
            // Arrange
            var source = "TheAnsible";
            var expected = "The Ansible";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotInsertDuplicateSpace()
        {
            // Arrange
            var source = "The Ansible";
            var expected = "The Ansible";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

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

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotInsertDuplicateSpace()
        {
            // Arrange
            var source = "The Ansible";
            var expected = "The Ansible";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

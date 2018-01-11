using System;
using ListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListClassUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_3Ints()
        {
            // Arrange
            ListClass<T> list = new ListClass<T>();
            // Act 
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] result = new int[] {1, 2, 3};
            // Assert
            Assert.AreEqual(result, list);
        }
        [TestMethod]
        public void Add_3Strings()
        {
            // Arrange
            ListClass<T> list = new ListClass<T>();
            // Act 
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            string[] result = new string[] {"One", "Two", "Three"};
            // Assert
            Assert.AreEqual(result, list);
        }
        [TestMethod]
        public void Add_ToEmpty()
        {
            // Arrange
            ListClass<T> list = new ListClass<T>();
            // Act 
            list.Add(1);
            int[] result = new int[] {1};
            // Assert
            Assert.AreEqual(result, list);
        }
        [TestMethod]
        public void Add_Ints_SameCount()
        {
            // Arrange
            ListClass<T> list = new ListClass<T>();
            // Act 
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] result = new int[] { 1, 2, 3 };
            // Assert
            Assert.AreEqual(result.Length, list.Length);
        }
    }
}

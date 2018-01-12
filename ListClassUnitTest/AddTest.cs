using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddTest
    {
        //Add method tests
        [TestMethod]
        public void Add_3Ints()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expected = new CustomList<int> { 1, 2, 3 }();
            // Act 

            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(list[0], expected[0]);
        }
        [TestMethod]
        public void Add_3Strings()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            CustomList<string> expected = new CustomList<string> { "One", "Two", "Three" }();
            // Act 
            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            // Assert
            Assert.AreEqual(expected[0], list[0]);
        }
        [TestMethod]
        public void Add_ToEmpty()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expected = new CustomList<int> { 1 }();
            // Act 
            list.Add(1);
            int[] result = new int[] { 1 };
            // Assert
            Assert.AreEqual(expected.Count, list.Count);
        }
        [TestMethod]
        public void AddObjects()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            CustomList<object> expected = new CustomList<object> { 1 }();
            // Act 
            list.Add(1);
            int[] result = new int[] { 1 };
            // Assert
            Assert.AreEqual(expected.Count, list.Count);
        }
        [TestMethod]
        public void Add_Ints_SameCount()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            // Act 
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int result = 3;
            // Assert
            Assert.AreEqual(result, list.Length);
        }

        //Count method tests
        [TestMethod]
        public void Count_Empty()
        {
            CustomList<int> list = new CustomList<int>();

        }
    }
}

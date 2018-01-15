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
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3 };
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
            CustomList<string> expected = new CustomList<string>() { "One", "Two", "Three" };
            // Act 
            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            // Assert
            Assert.AreEqual(expected[0], list[0]);
        }
        [TestMethod]
        public void Add_ToEmptyCount()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() { 1 };
            // Act 
            list.Add(1);
            // Assert
            Assert.AreEqual(expected.Count, list.Count);
        }
        [TestMethod]
        public void Add_ToEmpty()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            
            // Act 
            list.Add(1);
            int expected = 1;
            // Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void AddObjects()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            CustomList<object> expected = new CustomList<object>() { 1 };
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
            Assert.AreEqual(result, list.Count);
        }
        [TestMethod]
        public void Add_OutsideOfBounds()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            // Act
            object obj = new object();
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            int expected = 19;
            // Assert
            Assert.AreEqual(expected, list.Count);

        }

        [TestMethod]
        public void Count_Empty()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();

            // Act
            int expected = 0;

            // Assert
            Assert.AreEqual(expected, list.Count);
        }



        //Remove method tests
        [TestMethod]
        public void Remove_ToEmpty()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            int notExpected = 1;
            // Act
            list.Remove(1);
            // Assert
            Assert.AreNotEqual(notExpected, list[0]);
        }
        [TestMethod]
        public void Remove_IntToEmpty()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1 };
            // Act
            list.Remove(1);
            int expected = 0;
            // Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Remove_CountCheck()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            // Act
            int notExpected = list.Count;
            list.Remove(1);
            // Assert
            Assert.AreNotEqual(notExpected, list.Count);
        }
        [TestMethod]
        public void Remove_SingleString()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "One", "Two", "Three" };
            string one = "One";
            // Act

            list.Remove(one);
            string expected = "Three";
            // Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Remove_MultipleInts()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            int expected = 7;
            // Act
            list.Remove(0);
            list.Remove(3);
            // Assert
            Assert.AreEqual(expected, list[5]);
        }
        [TestMethod]
        public void Remove_Objects()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            object notExpected = list;
            // Act
            list.Add(list);
            list.Add(list);
            list.Add(list);
            list.Remove(list);
            list.Remove(list);
            list.Remove(list);


            // Assert
            Assert.AreNotEqual(notExpected, list[0]);
        }
        [TestMethod]
        public void Remove_OneObjectFromListCountCheck()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            list.Add(list);
            list.Add(list);
            // Act
            int expected = 1;
            list.Remove(list);
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void RemoveBoolCheck()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            list.Add(list);
            list.Add(list);
            // Act
            bool expected = true;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }
        [TestMethod]
        public void RemoveBoolCheck_False()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            
            // Act
            bool expected = false;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }
    }
}

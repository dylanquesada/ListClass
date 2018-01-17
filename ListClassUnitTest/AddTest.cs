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
        public void Add_3Ints_UpdateArray()
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
        public void Add_3Strings_UpdateArray()
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
        public void Add_1Int_IncreaseCount()
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
        public void Add_1Int_ArrayInitializes()
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
        public void Add_Objects_UpdateArray()
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
        public void Add_Ints_IncreaseCount()
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
        public void Add_ManyObjects_CapacityExpands()
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
        public void Count_SetToZero_CountEqualZero()
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
        [ExpectedException(typeof(System.Exception))]
        public void Remove_AllInts_ThrowException()
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
        public void Remove_1Int_CountDecrease()
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
        public void Remove_SingleString_IndexShift()
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
        public void Remove_MultipleInts_IndexShift()
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
        [ExpectedException(typeof(System.Exception))]
        public void Remove_Objects_ThrowException()
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
        public void Remove_OneObject_CountDecrease()
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
        public void Remove_Object_ReturnTrue()
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
        public void Remove_Nothing_ReturnFalse()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            // Act
            bool expected = false;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }        
        [TestMethod]
        public void ToString_ThreeStrings_ReturnOneString()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "One", "Two", "Three" };
            // Act
            string expected = "OneTwoThree";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToString_ThreeInts_ReturnOneString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 1, 4 };
            // Act
            string expected = "114";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToString_EmptyList_ReturnEmptyString()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            // Act
            string expected = "";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_Bools_ReturnOneString()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>() { true, false, true };
            // Act
            string expected = "TrueFalseTrue";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        // Plus Operator Test Methods
        [TestMethod]
        public void PlusOp_Strings_ConcatLists()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "One", "Two" };
            // Act
            list = list + list;
            string expected = "Two";
            // Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void PlusOp_Ints_CountIncrease()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            // Act
            list = list + list;
            int expected = 6;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void PlusOp_EmptyList_ConcatLists()
        {
            CustomList<string> list = new CustomList<string>() { "One", "Two" };
            CustomList<string> empty = new CustomList<string>();
            // Act
            empty = list + empty;
            string expected = "Two";
            // Assert
            Assert.AreEqual(expected, empty[1]);
        }
        [TestMethod]
        public void PlusOp_StringToEmpty_CountIdles()
        {
            CustomList<string> list = new CustomList<string>() { "One", "Two" };
            CustomList<string> empty = new CustomList<string>();
            // Act
            empty = list + empty;
            int expected = 2;
            // Assert
            Assert.AreEqual(expected, empty.Count);

        }
        [TestMethod]
        public void PlusOp_Bools_ListsConcat()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>() { true, false };
            // Act
            list = list + list;
            bool expected = true;
            // Assert
            Assert.AreEqual(expected, list[2]);
        }
        // Minus Operator Test Methods
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void MinusOp_Bools_ThrowException()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>() {true, true, true };
            // Act
            bool notExpected = true;
            list = list - list;
            // Assert
            Assert.AreNotEqual(notExpected, list[0]);
        }
        [TestMethod]
        public void MinusOp_Strings_IndexShifts()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "true", "true", "false" };
            CustomList<string> otherList = new CustomList<string>() { "true" };
            // Act
            string expected = "false";
            list = list - otherList;
            // Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void MinusOp_Bools_CountDecrease()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>() { true, true, true };
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void MinusOp_AllInts_CountDecrease()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 4, 9};
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void MinusOp_Objects_CountDecreases()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>() { };
            list.Add(list);
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        // Zip TestMethods
        [TestMethod]
        public void Zip_Ints_ReturnOneString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 3, 5};
            CustomList<int> otherList = new CustomList<int>() { 2, 4, 6 };
            // Act
            list = list.Zip(otherList);
            int expected = 6;
            // Assert
            Assert.AreEqual(expected, list[5]);
        }
        [TestMethod]
        public void Zip_Ints_CountIncreases()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> otherList = new CustomList<int>() { 2, 4, 6 };
            // Act
            list = list.Zip(otherList);
            int expected = 6;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Zip_IntListsOfUnbalancedLength_IndexShifts()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> biggerList = new CustomList<int>() { 9, 9, 9, 9, 9, 9, 9 };

            // Act
            list = list.Zip(biggerList);
            int expected = 9;
            // Assert
            Assert.AreEqual(expected, list[10]);
        }
        [TestMethod]
        public void Zip_Strings_CountIncreases()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "One", "Two", "Three" };
            // Act
            list = list.Zip(list);
            int expected = 6;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Zip_StringListsOfUnbalancedLength_IndexShifts()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "One", "Two", "Three" };
            CustomList<string> biggerList = new CustomList<string>() { "One", "Two", "Three", "Four", "Five", "Six" };
            // Act
            list = biggerList.Zip(list);
            string expected = "Six";
            // Assert
            Assert.AreEqual(expected, list[8]);
        }
        [TestMethod]
        public void Sort_Ints_IndexShifts()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() { 1, 4, 10, 2 };
            // Act
            list.Sort();
            int expected = 10;
            // Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void Sort_Strings_IndexShifts()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "The", "He", "A", "Hat" };
            // Act
            list.Sort();
            string expected = "A";
            // Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Sort_Strings_ReturnOrderedList()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>() { "The", "He", "A", "Hat" };
            // Act
            list.Sort();
            string expected = "AHatHeThe";
            // Assert
            Assert.AreEqual(expected, list.ToString());
        }
    }
}

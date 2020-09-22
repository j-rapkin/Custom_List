using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Custom_List.UnitTests
{
	[TestClass]
	public class Custom_List
	{
		[TestMethod]
		public void Create_ArrayOfValues_ReturnCapacity()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expectedCapacity = 4;

			//act
			int actualCapacity = aCustomList.Capacity;
			//assert
			Assert.AreEqual(expectedCapacity, actualCapacity);
		}
		//ADD METHOD TESTS
		[TestMethod]
		public void Add_OneElement_IncrementCountOfList()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 1;

			//act
			aCustomList.Add(expected);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}
		[TestMethod]
		public void Add_TwoElements_ReturnElementAtIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 15;
			int firstElement = 10;
			int secondElement = 15;

			//act
			aCustomList.Add(firstElement);
			aCustomList.Add(secondElement);

			//Assert
			Assert.AreEqual(expected, aCustomList[1]);
		}
		[TestMethod]
		public void Add_ThreeElements_CapacityIsFour()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 4;
			int elementOne = 10;
			int elementTwo = 15;
			int elementThree = 20;

			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);

			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);
		}
		[TestMethod]
		public void Add_SixElements_CapacityIsEight()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 8;
			int elementOne = 1;
			int elementTwo = 2;
			int elementThree = 3;
			int elementFour = 4;
			int elementFive = 5;
			int elementSix = 6;

			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);
			aCustomList.Add(elementFour);
			aCustomList.Add(elementFive);
			aCustomList.Add(elementSix);


			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);
		}
		//REMOVE METHOD TESTS
		[TestMethod]
		public void Remove_OneElement_DecrementCountOfList()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 1;
			int removeValue = 1;
			aCustomList.Add(1);
			aCustomList.Add(2);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}
	}
}

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
	}
}

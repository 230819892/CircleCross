using CircleCross.App.Abstract;
using CircleCross.App.Concrete;
using CircleCross.App.Managers;
using CircleCross.Domain.Entity;
using FluentAssertions;
using Moq;

namespace CircleCrossTest
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			//Arrange
			Item item = new Item(1, "Circle", 2);
			Item item1 = new Item(3, "Cross", 4);
			var mock = new Mock<IService<Item>>();
			mock.Setup(s => s.GetItemById(1)).Returns(item);
			var manager = new ItemManager(new MenuActionService(), mock.Object);
			//Act
			var returnedItem= manager.GetItemById(item.Id);
			
			//Assert.Equal(item, returnedItem);
			returnedItem.Should().BeOfType(typeof(Item));
			returnedItem.Should().NotBeNull();
			returnedItem.Should().BeSameAs(item);
			

		}
	}
}

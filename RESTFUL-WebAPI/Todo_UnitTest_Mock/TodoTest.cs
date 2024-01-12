using Moq;
using TodoApp.Controllers;
using TodoApp.Services;
using TodoApp.Models;
using Xunit;

namespace Todo_UnitTest_Mock
{
    public class TodoTest
    {
        #region Property
        public Mock<ITodoService> mock = new Mock<ITodoService>();
        #endregion

        [Fact]
        public async void GetItemById()
        {
            mock.Setup(p => p.GetItemById(1)).ReturnsAsync(new ItemData() {
                Id = 1,
                Title = "Wongko",
                Description = "Jember",
                Done = true
            }) ;
            TodoController todo = new TodoController(mock.Object);
            ItemData result = (ItemData)await todo.GetItemById(1);
            Assert.Equal(new ItemData()
            {
                Id = 1,
                Title = "Wongko",
                Description = "Jember",
                Done = true
            }, result);
        }
    }
}

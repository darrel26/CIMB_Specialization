using Moq;
using TodoApp.Controllers;
using TodoApp.Services;
using TodoApp.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace Todo_UnitTest_Mock
{
    public class TodoTest
    {
        #region Property
        private readonly Mock<ITodoService> _mock;
        private readonly TodoController _controller;
        #endregion

        #region Constructor
        public TodoTest()
        {
            _mock = new Mock<ITodoService>();
            _controller = new TodoController(_mock.Object);
        }
        #endregion  

        [Fact]
        public async void GetItemById()
        {
            _mock.Setup(p => p.GetItemById(1)).ReturnsAsync(new ItemData() {
                Id = 1,
                Title = "Wongko",
                Description = "Jember",
                Done = true
            }) ;
            TodoController todo = new TodoController(_mock.Object);
            var result = await todo.GetItemById(1);
            ItemData itemData = new ItemData()
            {
                Id = 1,
                Title = "Wongko",
                Description = "Jember",
                Done = true
            };

            Assert.Equal(itemData, result);
        }
    }
}

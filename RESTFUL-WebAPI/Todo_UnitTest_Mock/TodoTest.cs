using Moq;
using TodoApp.Controllers;
using TodoApp.Services;
using TodoApp.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            _mock.Setup(service => service.GetItemById(1)).ReturnsAsync(new ItemData() { 
                Id = 1,
                Title = "Wongko",
                Description = "Jember",
                Done = true
            });

            var result = await _controller.GetItemById(1);
            _mock.Verify(r => r.GetItemById(1));
            // Check the response is OK (StatusCode 200)
            Assert.IsType<OkObjectResult>(result);

            // Check value type inside OK result 
            var item = result as OkObjectResult;
            Assert.IsType<ItemData>(item.Value);

            // Check returned item value 
            var data = item.Value as ItemData;
            Assert.Equal("Wongko", data.Title);
        }

        // Unit Test without Mock (Moq)
        [Fact]
        public async void GetItems()
        {
            _mock.Setup(service => service.GetItems()).ReturnsAsync(new List<ItemData>() { 
                new ItemData(), 
                new ItemData() 
            });

            var result = await _controller.GetItems();
            _mock.Verify(r => r.GetItems());

            Assert.IsType<OkObjectResult>(result);
            
            var item = result as OkObjectResult;

            Assert.IsType<List<ItemData>>(item.Value);

            var itemData = item.Value as List<ItemData>;

            Assert.Equal(2, itemData.Count);
        }
    }
}

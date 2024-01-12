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

        public IActionResult GetItemById()
        {
            var item = _controller.GetItemById(1);
            return View(item);
        }
    }
}

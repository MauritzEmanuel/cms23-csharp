using _03_TodoList.Interfaces;
using _03_TodoList.Models;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace _03_TodoList.Tests.UnitTests
{
    public class TodoService_Should
    {
        [Fact]
        public void AddTodo_Should_AddOneTodoToList_AndReturnTrue()
        {
            //Arrange
            ITodoService todoService = new TodoService();
            ITodo todo = new Todo();

            todo.Id = Guid.NewGuid();
            todo.Activity = "Testaktivitet";
            todo.Created = DateTime.Now;

            //Act
            bool result = todoService.AddTodo(todo);

            //Assert
            Assert.True(result);
        }

        [Fact]
        private static void GetAllTodos_Should_GetAListOfTodos_returnOneTodo()
        {
            // Arrange
            ITodoService todoService = new TodoService();
            ITodo todo = new Todo();

            todo.Id = Guid.NewGuid();
            todo.Activity = "Testaktivitet";
            todo.Created = DateTime.Now;

            todoService.AddTodo(todo);

            // Act
            IEnumerable<ITodo> result = todoService.GetAllTodos();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
        }
    }
}

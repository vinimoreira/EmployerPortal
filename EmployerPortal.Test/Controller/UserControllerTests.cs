using EmployerPortal.Controllers;
using EmployerPortal.Models;
using EmployerPortal.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Employer.Test.Controllers
{
    public class UserControllerTests
    {
        [Fact]
        public async Task GetUser_ShouldReturnBadRequest_WhenUsernameIsEmpty()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
            var controller = new UserController(mockUserService.Object);

            // Act
            var result = await controller.GetUser(null);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task GetUser_ShouldReturnNotFound_WhenUserDoesNotExist()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(service => service.GetUserByUsernameAssync(It.IsAny<string>()))
                           .ReturnsAsync((User)null);

            var controller = new UserController(mockUserService.Object);

            // Act
            var result = await controller.GetUser("non-existent-user");

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task GetUser_ShouldReturnOk_WhenUserExists()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(service => service.GetUserByUsernameAssync("test"))
                           .ReturnsAsync(new User { Name = "Test User" });

            var controller = new UserController(mockUserService.Object);

            // Act
            var result = await controller.GetUser("test");

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
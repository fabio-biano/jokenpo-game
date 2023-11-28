using JokenpoGameSample.Api.Models;
using JokenpoGameSample.Api.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace JokenpoGameSample.UnityTests
{
    [TestClass]
    public class PlayerControllerTests
    {
        private PlayerController controller { get; }

        public PlayerControllerTests()
        {
            var logger = new Mock<ILogger<PlayerController>>().Object;
            controller = new PlayerController(logger);
        }

        #region Play method

        [TestMethod]
        public void GivenNullPlayerModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = null;

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid players.", ((ObjectResult)result).Value);
        }

        [TestMethod]
        public void GivenNullPlayer1ModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = null, Player2 = null };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid player 1.", ((ObjectResult)result).Value);

        }

        [TestMethod]
        public void GivenNullPlayer2ModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = "stone", Player2 = null };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid player 2.", ((ObjectResult)result).Value);

        }

        [TestMethod]
        public void GivenEmptyPlayer1ModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = string.Empty, Player2 = null };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid player 1.", ((ObjectResult)result).Value);

        }

        [TestMethod]
        public void GivenWhiteSpacePlayer2ModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = "stone", Player2 = " " };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid player 2.", ((ObjectResult)result).Value);

        }

        [TestMethod]
        public void GivenUnknownPlayer1ModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = "foo", Player2 = "paper" };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid player 1.", ((ObjectResult)result).Value);

        }

        [TestMethod]
        public void GivenUnknownPlayer2ModelMustReturnBadRequest()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = "stone", Player2 = "bar" };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status400BadRequest, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Invalid player 2.", ((ObjectResult)result).Value);

        }

        [TestMethod]
        public void GivenValidPlayerModelMustResolveMatch()
        {   // Arrange
            PlayerModel model = new PlayerModel { Player1 = "stone", Player2 = "paper" };

            // Act
            var result = controller.Play(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, ((ObjectResult)result).StatusCode);
            Assert.AreEqual("Stone lose.", ((PlayResponseModel)((ObjectResult)result).Value).Result);
        }

        #endregion Play method
    }
}
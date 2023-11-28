using JokenpoGameSample.Api.Models;
using JokenpoGameSample.Api.Models.Response;
using JokenpoGameSample.Api.Tools;
using JokenpoGameSample.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace JokenpoGameSample.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Play")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlayResponseModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Play([FromBody] PlayerModel players)
        {
            string message = string.Empty;

            if (players == null)
            {
                message = "Invalid players.";
                _logger.Log(LogLevel.Error, message);
                return BadRequest(message);
            }

            Player player1 = PlayerFactory.CreatePlayer(players.Player1);
            Player player2 = PlayerFactory.CreatePlayer(players.Player2);

            if (player1 == null)
            {
                message = "Invalid player 1.";
                _logger.Log(LogLevel.Error, message);
                return BadRequest(message);
            }

            if (player2 == null)
            {
                message = "Invalid player 2.";
                _logger.Log(LogLevel.Error, message);
                return BadRequest(message);
            }

            var result = new PlayResponseModel() { Result = player1.Play(player2) };

            _logger.Log(LogLevel.Information, $"{player1.Character} vs {player2.Character} = {result.Result}");

            return Ok(result);
        }
    }
}
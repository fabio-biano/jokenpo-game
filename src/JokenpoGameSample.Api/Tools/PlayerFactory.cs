using JokenpoGameSample.Domain.Models;

namespace JokenpoGameSample.Api.Tools
{
    public static class PlayerFactory
    {
        public static Player CreatePlayer(string character)
        {
            if (string.IsNullOrWhiteSpace(character))
                return null;

            return character.ToUpper() switch
            {
                "PAPER" => new Paper(),
                "STONE" => new Stone(),
                "SCISSOR" => new Scissor(),
                _ => null
            };
        }
    }
}
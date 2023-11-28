using JokenpoGameSample.Domain.Contracts;

namespace JokenpoGameSample.Domain.Models
{
    public class Stone : Player
    {
        public override string Character
        {
            get { return "Stone"; }
        }

        public override string Play(IPlayable player)
        {
            Validate(player);

            return player.Character switch
            {
                "Paper" => $"{Character} lose.",
                "Stone" => "Match draw.",
                "Scissor" => $"{Character} wins.",
                _ => "Impossible to resolve."
            };
        }
    }
}
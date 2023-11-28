using JokenpoGameSample.Domain.Contracts;

namespace JokenpoGameSample.Domain.Models
{
    public class Paper : Player
    {
        public override string Character
        {
            get { return "Paper"; }
        }

        public override string Play(IPlayable player)
        {
            Validate(player);

            return player.Character switch
            {
                "Paper" => "Match draw.",
                "Stone" => $"{Character} wins.",
                "Scissor" => $"{Character} lose.",
                _ => "Impossible to resolve."
            };
        }
    }
}
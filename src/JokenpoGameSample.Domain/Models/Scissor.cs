using JokenpoGameSample.Domain.Contracts;

namespace JokenpoGameSample.Domain.Models
{
    public class Scissor : Player
    {
        public override string Character
        {
            get { return "Scissor"; } 
        }

        public override string Play(IPlayable player)
        {
            Validate(player);

            return player.Character switch
            {
                "Paper" => $"{Character} wins.",
                "Stone" => $"{Character} lose.",
                "Scissor" => "Match draw.",
                _ => "Impossible to resolve."
            };
        }
    }
}
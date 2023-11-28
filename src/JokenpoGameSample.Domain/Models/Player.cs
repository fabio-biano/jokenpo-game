using JokenpoGameSample.Domain.Contracts;

namespace JokenpoGameSample.Domain.Models
{
    public abstract class Player : IPlayable
    {
        public abstract string Character { get; }

        public abstract string Play(IPlayable player);

        public static void Validate(IPlayable player)
        {
            if (string.IsNullOrWhiteSpace(player.Character))
                throw new ApplicationException("Invalid player.");
        }
    }
}
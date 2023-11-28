namespace JokenpoGameSample.Domain.Contracts
{
    public interface IPlayable
    {
        string Character { get; }

        string Play(IPlayable player);
    }
}
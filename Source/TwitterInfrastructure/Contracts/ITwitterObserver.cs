using TwitterInfrastructure.Contracts.Models;

namespace TwitterInfrastructure.Contracts
{
    public interface ITwitterObserver
    {
        void Notify(Tweet tweet);
    }
}
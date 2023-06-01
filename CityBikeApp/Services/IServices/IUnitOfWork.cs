namespace CityBikeApp.Services.IServices
{
    public interface IUnitOfWork
    {
        IStationService Station { get; }
        ITripService Trip { get; }
        void Save();
    }
}


namespace Sales
{
    public interface IRepository
    {
          Task<List<SeasonalData>> GetDataAsync(int topN);
    }
}

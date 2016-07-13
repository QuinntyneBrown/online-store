namespace OnlineStore.Data
{
    public interface IUow
    {
        IRepository<Models.Product> Products { get; }
        void SaveChanges();
    }
}

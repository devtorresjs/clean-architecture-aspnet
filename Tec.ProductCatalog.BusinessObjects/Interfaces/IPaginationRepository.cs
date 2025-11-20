namespace Tec.ProductCatalog.BusinessObjects.Interfaces
{
    public interface IPaginationRepository<T>
    {
        IQueryable<Prod> GetQueryable();
    }
}

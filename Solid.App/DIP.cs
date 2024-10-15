namespace Solid.App
{
    public class ProductService
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositoryFromSqlServer:IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Kalem 1", "Kalem 2" };
        }
    }

    public class ProductRepositoryFromOracle : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Oracle 1", "Oracle 2" };
        }
    }

    public interface IRepository
    {
        List<string> GetAll();
    }
}

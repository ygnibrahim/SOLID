using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App
{

    //BAD  prencip

    //public class ReadProductRepository : IProductRepository
    //{
    //    public Product Create(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetList()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Update(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class ReadProductRepository : IReadRepository 
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();

        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }

    public class WriteProductRepository : IWriteRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //BAD prencip

    //public interface IProductRepository
    //{
    //    List<Product> GetList();
    //    Product GetById(int id);
    //    Product Create(Product product);
    //    Product Update(Product product);
    //    Product Delete(int id);
    //}

    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        
    }

    public interface IWriteRepository
    {
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(int id);
    }
}

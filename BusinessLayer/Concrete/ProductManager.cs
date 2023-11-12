using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal )
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.Add( entity );
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
           return _productDal.GetAll().ToList();
        }

        public Product TGetId(int id)
        {
            return _productDal.GetId(id);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}

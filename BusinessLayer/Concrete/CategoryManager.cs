using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TAdd(Category entity)
        {
            _categorydal.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categorydal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categorydal.GetAll().ToList();
        }

        public Category TGetId(int id)
        {
            return _categorydal.GetId(id);

        }

        public void TUpdate(Category entity)
        {
            _categorydal.Update(entity);
        }  
    }
}

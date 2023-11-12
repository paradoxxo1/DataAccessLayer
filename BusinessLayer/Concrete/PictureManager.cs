using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    internal class PictureManager : IPictureService
    {
        IPictureDal _picturedal;

        public PictureManager(IPictureDal picturedal)
        {
            _picturedal = picturedal;
        }

        public void TAdd(Pictures entity)
        {
            _picturedal.Add(entity);
        }

        public void TDelete(Pictures entity)
        {
            _picturedal.Delete(entity);
        }

        public List<Pictures> TGetAll()
        {
            return _picturedal.GetAll().ToList();
        }

        public Pictures TGetId(int id)
        {
           return _picturedal.GetId(id);
        }

        public void TUpdate(Pictures entity)
        { 
            _picturedal.Update(entity);
        }
    }
}

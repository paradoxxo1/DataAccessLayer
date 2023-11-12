using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SizeManager : ISizeService
    {
        ISizeDal _sizedal;

        public SizeManager(ISizeDal sizedal)
        {
            _sizedal = sizedal;
        }

        public void TAdd(Sizes entity)
        {
            _sizedal.Add(entity);
        }

        public void TDelete(Sizes entity)
        {
            _sizedal.Delete(entity);
        }

        public List<Sizes> TGetAll()
        {
           return _sizedal.GetAll().ToList();
        }

        public Sizes TGetId(int id)
        {
            return _sizedal.GetId(id);
        }

        public void TUpdate(Sizes entity)
        {
            _sizedal.Update(entity);
        }
    }
}

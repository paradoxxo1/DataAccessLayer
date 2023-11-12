using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    internal class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void TAdd(Colors entity)
        {
            _colorDal.Add(entity);
        }

        public void TDelete(Colors entity)
        {
            _colorDal.Delete(entity);
        }

        public List<Colors> TGetAll()
        {
           return _colorDal.GetAll().ToList();
        }

        public Colors TGetId(int id)
        {
           return _colorDal.GetId(id);
        }

        public void TUpdate(Colors entity)
        {
            _colorDal.Update(entity);
        }
    }
}

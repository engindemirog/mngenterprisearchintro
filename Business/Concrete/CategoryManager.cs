using DataAccess.Abstract;
using System;

namespace Business
{
    public class CategoryManager
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //resharper
        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
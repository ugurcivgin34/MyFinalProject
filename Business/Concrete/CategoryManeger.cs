using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManeger : ICategoryService
    {
        //Veri erişim hibernate , entityfremework den gelebilir.Bu yüzden yaptık
        ICategoryDal _categoryDal;

        public CategoryManeger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
            
        }

        //select * from Categories where CategoryId 
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}

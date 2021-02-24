using Business.Abstract;
using Core.Utilities.Results;
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

        public IDataResult <List<Category>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<Category>>( _categoryDal.GetAll());
            
        }

        //select * from Categories where CategoryId 
        public IDataResult <Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>( _categoryDal.Get(c => c.CategoryId == categoryId));
        }

       
    }
}

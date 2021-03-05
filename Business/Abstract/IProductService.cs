using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //Data olanlarda IDataResult şeklinde hazırladık, Add kısmında data olmadığı için IResult şeklinde hazırladık.
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);

        //IResult AddTransactionalTest(Product product);

        //Transcation yönetimi uygulamalarda tutartlılığı korumak için ypaılan bir yöntemdir.Örneğin benim hesabımda 100 lira var,Başka hesaba 10 lira aktarcaz
        //Benim hesabım 10 lira düşcek şekilde update edilmesi lazoım, karşı tarafın da 10 lira aratacak şekilde artması gerekir.
        //2 tane veri tarabnı işlemi var.Benim hesaptan güncelledi ama karşı tarafa azarken sistem hata verdi,paramı geri almak için işlem
        //Geri alınması gerekir.Bu gibi konularda transaction kullanılır

    }
}

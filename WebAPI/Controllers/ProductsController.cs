using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] //route bu isteği yaparken bu insanlar bize nasıl ulaşssın
    [ApiController]  //ATTRIBUTE   java da ise ANNOTATION
    //Attırubute bir class ile ilgili bilgi verme ve imzalama yöntemidir
    public class ProductsController : ControllerBase
    {
        //constructor injection yaparak bağımlılığı çözdük

        //Looser coupled  - gevşek bağımlılık. Bİr bağımlılığı var ama bir soyuta bağımlılığı var.Service değişirse manager yani bir problemle karşılaşmazsın
        //hiç bir zaman bir katman diğer katmanın somutunu (maneger ,dal vs interface olmayanlar ) onlar dışında bağlantı kuramazsın

        //fieldların default private dir
        //naming convention isimlendirme kuralı _productService
        //hiç bir katman diğer katmanı newlwmez.Somut sınıf üzerinden gitmez


        //IoC Container -- Inversion of control-Değişimin kontrolü=>
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain -- bağımlılık zinciri
            
            var result= _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);   
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

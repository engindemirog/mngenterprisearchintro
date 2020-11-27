using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            if (!_productDal.GetAll().Any(p => p.ProductName == product.ProductName))
            {
                _productDal.Add(product);
                return product;
            }
            else
            {
                return null;
            }
            
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?
            //Bla bla
            return _productDal.GetAll();
        }
    }
}

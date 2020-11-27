using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Oracle
{
    public class OracleProductDal : IProductDal
    {
        List<Product> _products;
        public OracleProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop",
                QuantityPerUnit="64 GB Ram", UnitPrice=10000, UnitsInStock=2},
            new Product{ProductId=2, CategoryId=1, ProductName="Hp Laptop",
                QuantityPerUnit="32 GB Ram", UnitPrice=8000, UnitsInStock=3},
            };
        }
        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            var productToRemove = _products.Find(p => p.ProductId == entity.ProductId);
            _products.Remove(productToRemove);
        }

        public List<Product> GetAll()
        {
            return _products;
        }



        public Product GetById(int id)
        {
            return _products.Find(p => p.ProductId == id);
        }

        public void Update(Product entity)
        {
            var productToUpdate = _products.Find(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.QuantityPerUnit = entity.QuantityPerUnit;
            productToUpdate.UnitPrice = entity.UnitPrice;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
            productToUpdate.CategoryId = entity.CategoryId;

            //Automapper
        }
    }
}

using MoviMani.DataAccess.Data;
using MoviMani.DataAccess.Repository.IRepository;
using MoviMani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviMani.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISAN = obj.ISAN;
                objFromDb.Price = obj.Price;
                objFromDb.Price5 = obj.Price5;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price10 = obj.Price10;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Director = obj.Director;
               objFromDb.ProductImages = obj.ProductImages;
               // if (obj.ImageUrl != null)
              //  {
                //    objFromDb.ImageUrl = obj.ImageUrl;
              //  }
            }
        }
    }
}


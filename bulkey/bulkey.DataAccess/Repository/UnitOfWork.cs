using bulkey.DataAccess.Repositories;
using bulkey.DataAccess.Repository.IRepository;

using bulkey.Models;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkey.DataAccess.Repository
{
    public class UnitOfWork :IUnitOfWork
    {

        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)

        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product=new ProductRepository(_db);
            Compan = new CompanRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanRepository Compan { get; private set; }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
}

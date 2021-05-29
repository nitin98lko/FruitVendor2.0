using FruitUserApi.Data;
using FruitUserApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Repository
{
    public class UserRepository
    {
        private readonly FruitVendorContext db = null;
        public UserRepository()
        {
            db = new FruitVendorContext();
        }

        public List<Author> GetAll()
        {
            return db.Authers.ToList();
        }
    }
}

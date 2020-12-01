using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BritoWebMVC.Data;
using BritoWebMVC.Models;

namespace BritoWebMVC.Services
{
    public class SellerService
    {
        private readonly BritoWebMVCContext _context;

        public SellerService(BritoWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

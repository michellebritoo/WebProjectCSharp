using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BritoWebMVC.Data;
using BritoWebMVC.Models;
using BritoWebMVC.Services.Exeptions;
using System.Threading.Tasks;

namespace BritoWebMVC.Services
{
    public class SellerService
    {
        private readonly BritoWebMVCContext _context;

        public SellerService(BritoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.department).
                FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsycn(int id)
        {
            var obj =await  _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found.");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                //throw new DbUpdateConcurrencyException(e.Message);
                throw new Exception(e.Message);
            }

        }
    }
}

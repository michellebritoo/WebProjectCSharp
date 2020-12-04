using BritoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BritoWebMVC.Data;

namespace BritoWebMVC.Services
{
    public class SallesRecordService
    {
        private readonly BritoWebMVCContext _context;

        public SallesRecordService(BritoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SallesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SallesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using BritoWebMVC.Data;
using BritoWebMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BritoWebMVC.Services
{
    public class DepartmentService
    {
        private readonly BritoWebMVCContext _context;

        public DepartmentService(BritoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

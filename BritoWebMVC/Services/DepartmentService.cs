using System;
using System.Collections.Generic;
using System.Linq;
using BritoWebMVC.Data;
using BritoWebMVC.Models;

namespace BritoWebMVC.Services
{
    public class DepartmentService
    {
        private readonly BritoWebMVCContext _context;

        public DepartmentService(BritoWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

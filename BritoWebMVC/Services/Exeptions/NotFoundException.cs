using System;
using System.Linq;

namespace BritoWebMVC.Services.Exeptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException (string message): base(message)
        {

        }
    }
}

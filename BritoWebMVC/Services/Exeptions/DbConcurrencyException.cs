using System;

namespace BritoWebMVC.Services.Exeptions
{
    public class DbConcurrencyException : ApplicationException
    {

        public DbConcurrencyException(string message): base(message)
        {

        }
    }
}

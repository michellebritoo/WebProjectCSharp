using System;
namespace BritoWebMVC.Services.Exeptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message): base(message)
        {
        }
    }
}

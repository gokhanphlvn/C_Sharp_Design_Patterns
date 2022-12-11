using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Component 2
    /// </summary>
    public class OnPremiseMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" sent via {nameof(OnPremiseMailService)}");
            return true;
        }
    }
}

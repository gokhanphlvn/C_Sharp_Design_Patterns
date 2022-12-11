using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        public Logger()
        {
            _guid= Guid.NewGuid();
        }
        private Guid _guid;

        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
            }
        }
        private static Logger? _instanceOld;
        /// <summary>
        /// Instance
        /// </summary>
        public static Logger InstanceOld
        {
            get
            {
                if (_instanceOld == null)
                {
                    _instanceOld = new Logger();
                }
                return _instanceOld;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"{message} - {_guid.ToString("N")}");
        }
    }
}

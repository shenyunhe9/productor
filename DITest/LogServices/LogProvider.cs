using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServices
{
    public interface LogProvider
    {
        
        public void LoggError(String error);
        public void LoggInfo(String msg);
    }
}

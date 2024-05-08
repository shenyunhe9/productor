using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices
{
    public interface ImailService
    {
        public void Send(String title, String to ,String body);
    }
}

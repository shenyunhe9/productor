using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconfigServices
{
    public class IconfigServiceImp : IconfigService
    {
        public string getValue(string vale)
        {
            return Environment.GetEnvironmentVariable(vale);
        }
    }
}

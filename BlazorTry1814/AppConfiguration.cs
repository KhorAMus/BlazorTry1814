using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTry1814
{
    public class AppConfiguration
    {
        public string ServerAddress { get; init; }

        public AppConfiguration()
        {
            var isDebug = false;
#if DEBUG
            isDebug = true;
#endif
            if (isDebug)
            {
                ServerAddress = "";
            }
            else
            {
                ServerAddress = "https://blazortry1814api.azurewebsites.net/";
            }
        }
    }
}

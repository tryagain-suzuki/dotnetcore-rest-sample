using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSample.Services
{
    public class GreetingService
    {

        public string CreateGreeting(string name) 
            => $@"Hello, {name}!!";
        

    }
}

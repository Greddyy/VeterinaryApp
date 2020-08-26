using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetApp
{
    public class FakeStartup : Startup
    {
        public FakeStartup (IConfiguration configuration) : base(configuration)
        {

        }

        public override void Configure()
        {

        }

       
    }
}

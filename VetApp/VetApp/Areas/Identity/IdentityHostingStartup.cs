using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetApp.Areas.Identity.Data;
using VetApp.Data;

[assembly: HostingStartup(typeof(VetApp.Areas.Identity.IdentityHostingStartup))]
namespace VetApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VetAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VetAppContextConnection")));

                services.AddDefaultIdentity<VetAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<VetAppContext>();
            });
        }
    }
}
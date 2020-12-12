using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalKendaraan_098.Data;

[assembly: HostingStartup(typeof(RentalKendaraan_098.Areas.Identity.IdentityHostingStartup))]
namespace RentalKendaraan_098.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RentalKendaraan_098Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RentalKendaraan_098ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<RentalKendaraan_098Context>();
            });
        }
    }
}
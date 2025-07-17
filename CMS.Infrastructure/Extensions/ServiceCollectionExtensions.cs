using CMS.Core.Entities;
using CMS.Infrastructure.Persistence.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. Database Connection
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // 2. Identity
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            // 3. Repositories
            //services.AddScoped<IStudentRepository, StudentRepository>();

            // 4. File Storage
            // services.AddScoped<IFileStorageService, LocalFileStorageService>();

            // 5. Email
            // services.AddScoped<IEmailService, SmtpEmailService>();

            // 6. Caching
            // services.AddMemoryCache(); // or AddStackExchangeRedisCache()

            return services;
        }
    }

}

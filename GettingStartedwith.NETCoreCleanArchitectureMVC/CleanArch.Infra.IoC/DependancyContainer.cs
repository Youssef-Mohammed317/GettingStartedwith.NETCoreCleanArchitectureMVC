using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // CleanArch.Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // CleanArch.Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}

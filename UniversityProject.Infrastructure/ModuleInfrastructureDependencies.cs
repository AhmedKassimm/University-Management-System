using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Abstraction;
using UniversityProject.Infrastructure.Repostiories;

namespace UniversityProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {

        public static IServiceCollection ApplyInfrastructureDependencies(this IServiceCollection serviceProvider)
        {
          return  serviceProvider.AddTransient<IStudentRepository , StudentRepository>();

        }
    }
}

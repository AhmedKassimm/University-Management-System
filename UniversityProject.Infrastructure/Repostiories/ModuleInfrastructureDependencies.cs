using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Abstraction;

namespace UniversityProject.Infrastructure.Repostiories
{
    public static class ModuleInfrastructureDependencies
    {

        public static IServiceCollection ApplyDependencies (this IServiceCollection serviceProvider)
        {
          return  serviceProvider.AddTransient<IStudentRepository , StudentRepository>();

        }
    }
}

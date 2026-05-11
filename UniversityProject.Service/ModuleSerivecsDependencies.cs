using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Abstraction;
using UniversityProject.Service.Servies.StudentServies;

namespace UniversityProject.Service
{
    public static class ModuleSerivecsDependencies
    {

        public static IServiceCollection ApplySerivecsDependencies(this IServiceCollection services)
         => services.AddTransient<IStudentServies, StudentServcies>();
       
    }
}

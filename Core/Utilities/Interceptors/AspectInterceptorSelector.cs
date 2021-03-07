using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using Core.Aspects.Autofac.Performance;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttiributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true);

            classAttributes.AddRange(methodAttiributes);
            classAttributes.Add(new PerformanceAspect(5));

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}

﻿using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Castle.DynamicProxy;
using System.Linq;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private readonly int _duration;
        private readonly ICacheManager _cacheManager;

        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName=string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}"); //string.Format fazla
            var arguments=invocation.Arguments.ToList();
            var key=$"{methodName}({string.Join(",",arguments.Select(a=>a?.ToString()??"<Null>"))})";

            if (_cacheManager.IsAdd(key)) //kontrol ederken out ile degeri okunabilir
            {
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }

            invocation.Proceed();
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}

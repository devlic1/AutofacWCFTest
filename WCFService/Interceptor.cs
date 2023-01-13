using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService
{
    public class Interceptor : Castle.DynamicProxy.IInterceptor
    {
        public Interceptor() { }

        public void Intercept(IInvocation invocation)
        {
            var camein = "";

            invocation.Proceed();
        }
    }
}
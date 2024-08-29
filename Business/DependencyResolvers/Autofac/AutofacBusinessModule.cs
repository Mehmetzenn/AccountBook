using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAcces.Abstracts;
using DataAcces.Concretes.EntityFreamwork;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SafeManager>().As<ISafeService>().SingleInstance();
            builder.RegisterType<EfSafeDal>().As<ISafeDal>().SingleInstance();

            builder.RegisterType<BankManager>().As<IBankService>().SingleInstance();
            builder.RegisterType<EfBankDal>().As<IBankDal>().SingleInstance();

            builder.RegisterType<CollectionPaymentsManager>().As<ICollectionPaymentsService>().SingleInstance();
            builder.RegisterType<EfCollectionPaymentsDal>().As<ICollectionPaymentsDal>().SingleInstance();

            builder.RegisterType<SafeBalanceManager>().As<ISafeBalanceService>().SingleInstance();
            builder.RegisterType<SafeBalanceDal>().As<ISafeBalanceDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();    
        }
    }
}
    
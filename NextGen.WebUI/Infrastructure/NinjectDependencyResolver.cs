using NextGen.Domain;
using NextGen.Domain.Abstract;
using NextGen.Domain.Core;
using NextGen.Domain.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NextGen.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            // put bindings here
            kernel.Bind<IDbContext>().To<DataContext>();
            kernel.Bind<IDbSession>().To<DbSession>();
            kernel.Bind(typeof(IEntityRepository<>)).To(typeof(EntityRepository<>));
            
        }
    }
}
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using WebDolomit.DAL;
using WebDolomit.Repositories;

namespace WebDolomit
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBinding();
        }

        // извлекаем экземпляр контроллера для заданного контекста 
        //запроса и типа контроллера
        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ?
                null : (IController)ninjectKernel.Get(controllerType);
        }

        // определяем все привязки
        private void AddBinding()
        {
            ninjectKernel.Bind<IUserRepository>().To<EFUserRepository>();
            ninjectKernel.Bind<ILogicRepository>().To<EFLogicRepository>();
            ninjectKernel.Bind<PrimaryContext>().ToSelf().WithConstructorArgument(
            "connectionString", ConfigurationManager.ConnectionStrings[0].ConnectionString);
            ninjectKernel.Inject(Membership.Provider);

        }
    }
}
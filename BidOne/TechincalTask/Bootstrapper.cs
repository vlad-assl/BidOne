using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using BidOne.TechnicalTask.Lib.Services.Interfaces;
using BidOne.TechnicalTask.Lib.Services;
using BidOne.TechnicalTask.Lib.Repositories.Interfaces;
using BidOne.TechnicalTask.Lib.Repositories;

using BidOne.TechincalTask.Web.Controllers;

namespace BidOne.TechincalTask
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            container.RegisterType<IWriteJsonToFileService, WriteJsonToFileService>();
            container.RegisterType<IFileRepository, FileRepository>();
            container.RegisterType<IPersonRepository, PersonRepository>();

            //container.RegisterType<IController, HomeController>("Store");
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}
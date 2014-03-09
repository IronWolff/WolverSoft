using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Repository
{
    public static class ApplicationModuleAdapter
    {
        public static ApplicationModule GetModelObject(DataAccess.ApplicationModule applicationModuleDA)
        {
            return new ApplicationModule()
            {
                ApplicationModuleId = applicationModuleDA.ApplicationModuleId,
                Name = applicationModuleDA.Name,
                ApplicationId = applicationModuleDA.ApplicationId
            };
        }

        public static IList<ApplicationModule> GetModelObjectList(IList<DataAccess.ApplicationModule> applicationModulesDA)
        {
            return applicationModulesDA.Select(app => GetModelObject(app)).ToList();
        }

        public static DataAccess.ApplicationModule GetDAObject(ApplicationModule application)
        {
            return new DataAccess.ApplicationModule
            {
                ApplicationModuleId = application.ApplicationModuleId,
                Name = application.Name,
                ApplicationId = application.ApplicationId
            };
        }
    }
}

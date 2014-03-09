using System;
using System.Collections.Generic;
using System.Linq;
using WS.Security.Model;

namespace WS.Security.Repository
{
    public static class ApplicationAdapter
    {
        public static Application GetModelObject(DataAccess.Application applicationDA)
        {
            return new Application()
            {
                ApplicationCode = applicationDA.ApplicationCode,
                ApplicationName = applicationDA.ApplicationName,
                ApplicationId = applicationDA.ApplicationId
            };
        }

        public static IList<Application> GetModelObjectList(IList<DataAccess.Application> applicationsDA)
        {
            return applicationsDA.Select(app => GetModelObject(app)).ToList();
        }

        public static DataAccess.Application GetDAObject(Application application)
        {
            return new DataAccess.Application
            {
                ApplicationCode = application.ApplicationCode,
                ApplicationId = application.ApplicationId,
                ApplicationName = application.ApplicationName
            };
        }
    }
}

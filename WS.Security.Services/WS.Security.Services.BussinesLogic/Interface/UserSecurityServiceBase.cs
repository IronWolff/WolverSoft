using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Services.BussinesLogic
{
    [ServiceContract(Namespace = "http://www.wolversoft.com/UserSecurity/IUserSecurityBLService/20130615")]
    public interface IUserSecurityBLService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        int CreateUser(User user, IList<Role> userRoles);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void UpdateUser(User user, IList<Role> userRoles);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Services.Task
{
    [ServiceContract(Namespace = "http://www.wolversoft.com/UserSecurity/UserService/20120530", SessionMode = SessionMode.Allowed)]
    public interface IUserService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        int InsertUser(User user);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateUser(User user);

        [OperationContract]
        [FaultContract(typeof (ServiceFault))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void ChangePassword(User user);

        [OperationContract]
        [FaultContract(typeof (ServiceFault))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        User GetUserByLogin(string userName, string password);
    }
}

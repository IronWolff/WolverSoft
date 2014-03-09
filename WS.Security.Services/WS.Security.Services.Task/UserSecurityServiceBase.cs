using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WS.Security.Model;
using WS.Security.Repository;
using WS.Security.Repository.Implementation;

namespace WS.Security.Services.Task
{
    public class UserSecurityServiceBase : IDisposable
    {
        protected IUserSecurityRepository _userSecurityRepository;

        public UserSecurityServiceBase()
        {
            _userSecurityRepository = new UserSecurityRepository();
        }

        public UserSecurityServiceBase(IUserSecurityRepository userSecurityRepository)
        {
            _userSecurityRepository = userSecurityRepository;
        }

        ~UserSecurityServiceBase()
        {
            Dispose(false);
        }

        #region FaultExceptions

        protected FaultException<ServiceFault> GetFaultException(Exception ex)
        {
            var fault = new ServiceFault
            {
                ErrorCode = ex.GetType().ToString(),
                ErrorDetail = ex.ToString(),
                ErrorMessage = ex.Message
            };

            return new FaultException<ServiceFault>(fault, new FaultReason(ex.Message));
        }
        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userSecurityRepository != null)
                {
                    _userSecurityRepository.Dispose();
                }
            }
        }

        #endregion
    }
}

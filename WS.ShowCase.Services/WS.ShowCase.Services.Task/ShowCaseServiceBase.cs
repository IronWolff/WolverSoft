using System;
using System.ServiceModel;
using WS.ShowCase.Model.Models;
using WS.ShowCase.Repository;

namespace WS.ShowCase.Services.Task
{
    public class ShowCaseServiceBase : IDisposable
    {
        protected IShowCaseRepository _showCaseRepository;

        public ShowCaseServiceBase()
        {
            _showCaseRepository = new ShowCaseRepository();
        }

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

        ~ShowCaseServiceBase()
        {
            Dispose(false);
        }

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
                if (_showCaseRepository != null)
                {
                    _showCaseRepository.Dispose();
                }
            }
        }

        #endregion
    }
}

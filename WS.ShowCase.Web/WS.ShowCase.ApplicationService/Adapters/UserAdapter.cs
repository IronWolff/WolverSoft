using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.ViewModels;

namespace WS.ShowCase.ApplicationService
{
    public static class UserAdapter
    {
        public static UserSvc.User GetDomainModel(UserModel userModel)
        {
            return new UserSvc.User
            {
                Email = userModel.Email,
                FirstName = userModel.FirstName,
                IsActive = userModel.IsActive,
                LastName = userModel.LastName,
                MustChangePassword = userModel.MustChangePassword,
                Password = userModel.Password,
                Phone = userModel.Phone,
                UserId = userModel.UserId,
                Username = userModel.Username
            };
        }

        public static UserModel GetViewModel(UserSvc.User userDomainModel)
        {
            return new UserModel
            {
                Email = userDomainModel.Email,
                FirstName = userDomainModel.FirstName,
                IsActive = userDomainModel.IsActive,
                LastName = userDomainModel.LastName,
                MustChangePassword = userDomainModel.MustChangePassword,
                Password = userDomainModel.Password,
                Phone = userDomainModel.Phone,
                UserId = userDomainModel.UserId,
                Username = userDomainModel.Username
            };
        }
    }
}

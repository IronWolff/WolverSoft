using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.ViewModels;
using WS.ShowCase.ViewModels;

namespace WS.ShowCase.ApplicationService
{
    public static class UserAdapter
    {
        public static UserSecurityBLService.User GetViewModel(UserModel userModel)
        {
            return new UserSecurityBLService.User
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

        public static UserModel GetDomainModel(UserSecurityBLService.User userDomainModel)
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

        public static UserSecurityBLService.User GetUserDomainModelForSignUp(UserSignUpModel signUpUser)
        {
            return new UserSecurityBLService.User
            {
                Username = signUpUser.Username,
                Email = signUpUser.Email,
                FirstName = signUpUser.FirstName,
                LastName = signUpUser.LastName,
                Phone = signUpUser.Password,
                Password = signUpUser.Password
            };
        }
    }
}

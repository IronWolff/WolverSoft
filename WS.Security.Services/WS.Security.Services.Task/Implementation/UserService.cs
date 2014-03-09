using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;
using WS.Security.Repository;

namespace WS.Security.Services.Task
{
    public class UserService : UserSecurityServiceBase, IUserService
    {
        public int InsertUser(User user)
        {
            try
            {
                ValidateUser(user, false);

                user.IsActive = true;

                return _userSecurityRepository.InsertUser(user);
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public void UpdateUser(Model.User user)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(Model.User user)
        {
            throw new NotImplementedException();
        }

        private void ValidateUser(User user, bool validateUserId)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user", "User object is required");
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentNullException("user", "Email is required in the user object.");
            }
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentNullException("user", "UserName is required in the user object.");
            }
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                throw new ArgumentNullException("user", "FirstName is required in the user object.");
            }
            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                throw new ArgumentNullException("user", "LastName is required in the user object.");
            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentNullException("user", "Password is required");
            }

            if (validateUserId)
            {
                if (user.UserId < 1)
                {
                    throw new ArgumentNullException("user", "UserId is required");
                }
            }
        }

        public User GetUserByLogin(string userName, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userName))
                {
                    throw new ArgumentNullException("userName", "userName is required");
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentNullException("password", "password is required");
                }

                IList<User> users = _userSecurityRepository.GetFilteredUsers(new UserFilter { Username = userName, Password = password });

                if (users != null && users.Count > 0)
                {
                    return users.SingleOrDefault();
                }

                return null;
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Exceptions;
using WS.Security.Model;
using WS.Security.Repository.Adapters;
using WolverUtilities;
using WS.Security.Repository.Enums;

namespace WS.Security.Repository.Implementation
{
    public partial class UserSecurityRepository
    {
        public IList<User> GetFilteredUsers(UserFilter userFilter)
        {
            IQueryable<DataAccess.User> usersDA = UserSecurityDataContext.Users.AsQueryable();

            if (userFilter.UserId > 0)
            {
                usersDA = usersDA.Where(u => u.UserId == userFilter.UserId);
            }
            else
            {
                // RoleId
                if (userFilter.RoleId > 0)
                {
                    //usersDA = usersDA.Where(u => u.Role.Where(role => role.RoleId == userFilter.RoleId).Count() > 0);
                }

                // FirstName
                if (!string.IsNullOrWhiteSpace(userFilter.FirstName))
                {
                    usersDA = usersDA.Where(u => u.FirstName.Contains(userFilter.FirstName));
                }

                // LastName
                if (!string.IsNullOrWhiteSpace(userFilter.LastName))
                {
                    usersDA = usersDA.Where(u => u.LastName.Contains(userFilter.LastName));
                }

                // Phone
                if (!string.IsNullOrWhiteSpace(userFilter.Phone))
                {
                    usersDA = usersDA.Where(u => string.Compare(u.Phone, userFilter.Phone, true) == 0);
                }

                // UserName
                if (!string.IsNullOrWhiteSpace(userFilter.Username))
                {
                    usersDA = usersDA.Where(u => u.Username.Contains(userFilter.Username));
                }

                // GetActive
                if (!userFilter.GetInactive)
                {
                    usersDA = usersDA.Where(u => u.IsActive);
                }

                //// GetInactive
                //if (userFilter.GetInactive)
                //{
                //    usersDA = usersDA.Where(u => !u.IsActive);
                //}

                //Client
                if (userFilter.ClientId > 0)
                {
                    //usersDA = usersDA.Where(u => u.Role.Any(r => r.ClientId == userFilter.ClientId));
                }
            }

            if (usersDA.Count() > 0)
            {
                foreach (var user in usersDA)
                {
                    //If data has already been retrieved, the password will be unencrypted.  Check before attempting unencrypt
                    string password = user.Password.Trim();
                    if (password.Length >= 36)
                    {
                        password = Crypto.DecryptString(password, "psw");
                    }

                    user.Password = password;

                    if (!string.IsNullOrWhiteSpace(userFilter.Password))
                    {
                        if (string.Compare(user.Password, userFilter.Password) != 0)
                        {
                            return null;
                        }
                    }
                }
                return UserAdapter.GetModelObjectList(usersDA.ToList());
            }

            return null;
        }

        public int InsertUser(User user)
        {
            VerifyUsernameDoesNotExist(user.Username);

            //Encrypt Password
            user.Password = Crypto.EncryptString(user.Password,"psw");

            DataAccess.User userDA = UserAdapter.GetDAObject(user);
            UserSecurityDataContext.Users.Add(userDA);
            UserSecurityDataContext.SaveChanges();

            return userDA.UserId;
        }

        public void UpdateUser(User user, bool changePassword)
        {
            VerifyUsernameDoesNotExist(user.Username, user.UserId);

            DataAccess.User userDA = UserSecurityDataContext.Users.Where(u => u.UserId == user.UserId).SingleOrDefault();

            if (userDA == null)
            {
                throw new PermissionDoesNotExistException(string.Format("User '{0}' with Id '{1}' does not exist", user.Username, user.UserId));
            }

            userDA.FirstName = user.FirstName;
            userDA.LastName = user.LastName;
            userDA.Username = user.Username;
            userDA.IsActive = user.IsActive;
            userDA.Phone = user.Phone;
            userDA.Email = user.Email;
            userDA.MustChangePassword = user.MustChangePassword;

            if (changePassword)
            {
                userDA.Password = Crypto.EncryptString(user.Password, "psw");
            }
        }

        public void DeactivateUser(int userId)
        {
            DataAccess.User userDA = UserSecurityDataContext.Users.Where(u => u.UserId == userId).SingleOrDefault();

            if (userDA == null)
            {
                throw new PermissionDoesNotExistException(string.Format("User with Id '{0}' does not exist", userId));
            }

            userDA.IsActive = false;
        }      

        private void VerifyUsernameDoesNotExist(string username, int userId = 0)
        {
            bool exists = false;

            if (userId == 0)
            {
                exists = UserSecurityDataContext.Users.Where(u => string.Compare(u.Username, username, true) == 0).FirstOrDefault() != null;
            }
            else
            {
                exists = UserSecurityDataContext.Users.Where(u => string.Compare(u.Username, username, true) == 0 && u.UserId != userId).FirstOrDefault() != null;
            }

            if (exists)
            {
                throw new UserAlreadyExistsException(string.Format("User with username {0} already exists", username));
            }
        }
    }
}

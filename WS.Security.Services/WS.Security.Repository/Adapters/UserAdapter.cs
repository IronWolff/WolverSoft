using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Repository.Adapters
{
    public static class UserAdapter
    {
        public static User GetModelObject(DataAccess.User userDA)
        {
            DataAccess.UserSecurityEntities context = new DataAccess.UserSecurityEntities();

            return new User()
            {
                UserId = userDA.UserId,
                FirstName = userDA.FirstName,
                LastName = userDA.LastName,
                Password = userDA.Password,
                Phone = userDA.Phone,
                IsActive = userDA.IsActive,
                Username = userDA.Username,
                Email = userDA.Email,
                MustChangePassword = userDA.MustChangePassword
            };
        }

        public static DataAccess.User GetDAObject(User user)
        {
            return new DataAccess.User()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = !string.IsNullOrEmpty(user.Phone) ? user.Phone : string.Empty,
                IsActive = user.IsActive,
                Password = user.Password,
                Email = user.Email,
                Username = user.Username,
                MustChangePassword = user.MustChangePassword
            };
        }

        public static IList<User> GetModelObjectList(IList<DataAccess.User> usersDA)
        {
            return usersDA.Select(userDA => GetModelObject(userDA)).ToList();
        }
    }
}

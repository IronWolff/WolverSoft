using System.Collections.Generic;
using System.Linq;
using WS.ShowCase.Model;

namespace WS.ShowCase.Repository
{
    public static class UserAdapter
    {
        public static User GetModelObject(DataAccess.User user)
        {
            return new User
            {
                CreatedByUserId = user.CreatedByUserId,
                CreatedDate = user.CreatedDate,
                Email = user.Email,
                FirstName = user.FirstName,
                IsActive = user.IsActive,
                IsSuperAdmin = user.IsSuperAdmin,
                LastName = user.LastName,
                ModifiedByUserId = user.ModifiedByUserId,
                ModifiedDate = user.ModifiedDate,
                UserId = user.UserId
            };
        }

        public static DataAccess.User GetDAModel(User user)
        {
            return new DataAccess.User
            {
                CreatedByUserId = user.CreatedByUserId,
                CreatedDate = user.CreatedDate,
                Email = user.Email,
                FirstName = user.FirstName,
                IsActive = user.IsActive,
                IsSuperAdmin = user.IsSuperAdmin,
                LastName = user.LastName,
                ModifiedByUserId = user.ModifiedByUserId,
                ModifiedDate = user.ModifiedDate,
                UserId = user.UserId
            };
        }

        public static List<User> GetModelObjectList(List<DataAccess.User> users)
        {
            return users.Select(user => GetModelObject(user)).ToList();
        }

        public static List<DataAccess.User> GetDAModelList(List<User> users)
        {
            return users.Select(user => GetDAModel(user)).ToList();
        }
    }
}

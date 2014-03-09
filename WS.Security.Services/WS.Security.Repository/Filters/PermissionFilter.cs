using System;
using WS.Security.Model;

namespace WS.Security.Repository
{
    public class PermissionFilter : Permission
    {
        public int UserId { get; set; }

        public string Username { get; set; }
    }
}

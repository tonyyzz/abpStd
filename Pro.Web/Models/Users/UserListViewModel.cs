using System.Collections.Generic;
using Pro.Roles.Dto;
using Pro.Users.Dto;

namespace Pro.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
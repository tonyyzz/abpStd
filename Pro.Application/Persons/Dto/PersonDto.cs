using Abp.AutoMapper;
using Pro.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Persons.Dto
{
	//[AutoMapTo(typeof(User))]
	public class PersonDto
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }
	}
}
